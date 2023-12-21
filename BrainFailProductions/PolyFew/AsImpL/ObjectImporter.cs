using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200036C RID: 876
	public class ObjectImporter : MonoBehaviour
	{
		// Token: 0x06001269 RID: 4713 RVA: 0x00075B04 File Offset: 0x00073D04
		public ObjectImporter()
		{
			ObjectImporter.isException = false;
			ObjectImporter.downloadProgress = new PolyfewRuntime.ReferencedNumeric<float>(0f);
			ObjectImporter.objDownloadProgress = 0f;
			ObjectImporter.textureDownloadProgress = 0f;
			ObjectImporter.materialDownloadProgress = 0f;
			ObjectImporter.activeDownloads = 6;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600126A RID: 4714 RVA: 0x00075B50 File Offset: 0x00073D50
		// (remove) Token: 0x0600126B RID: 4715 RVA: 0x00075B88 File Offset: 0x00073D88
		public event Action ImportingStart;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600126C RID: 4716 RVA: 0x00075BC0 File Offset: 0x00073DC0
		// (remove) Token: 0x0600126D RID: 4717 RVA: 0x00075BF8 File Offset: 0x00073DF8
		public event Action ImportingComplete;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600126E RID: 4718 RVA: 0x00075C30 File Offset: 0x00073E30
		// (remove) Token: 0x0600126F RID: 4719 RVA: 0x00075C68 File Offset: 0x00073E68
		public event Action<GameObject, string> CreatedModel;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001270 RID: 4720 RVA: 0x00075CA0 File Offset: 0x00073EA0
		// (remove) Token: 0x06001271 RID: 4721 RVA: 0x00075CD8 File Offset: 0x00073ED8
		public event Action<GameObject, string> ImportedModel;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001272 RID: 4722 RVA: 0x00075D10 File Offset: 0x00073F10
		// (remove) Token: 0x06001273 RID: 4723 RVA: 0x00075D48 File Offset: 0x00073F48
		public event Action<string> ImportError;

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00075D7D File Offset: 0x00073F7D
		public int NumImportRequests
		{
			get
			{
				return this.numTotalImports;
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00075D88 File Offset: 0x00073F88
		private Loader CreateLoader(string absolutePath, bool isNetwork = false)
		{
			if (isNetwork)
			{
				LoaderObj loaderObj = base.gameObject.AddComponent<LoaderObj>();
				loaderObj.ModelCreated += this.OnModelCreated;
				loaderObj.ModelLoaded += this.OnImported;
				loaderObj.ModelError += this.OnImportError;
				return loaderObj;
			}
			string text = Path.GetExtension(absolutePath);
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("No extension defined, unable to detect file format. Please provide a full path to the file that ends with the file name including its extension.");
			}
			text = text.ToLower();
			Loader loader;
			if (text.StartsWith(".php"))
			{
				if (!text.EndsWith(".obj"))
				{
					throw new InvalidOperationException("Unable to detect file format in " + text);
				}
				loader = base.gameObject.AddComponent<LoaderObj>();
			}
			else
			{
				if (!(text == ".obj"))
				{
					throw new InvalidOperationException("File format not supported (" + text + ")");
				}
				loader = base.gameObject.AddComponent<LoaderObj>();
			}
			loader.ModelCreated += this.OnModelCreated;
			loader.ModelLoaded += this.OnImported;
			loader.ModelError += this.OnImportError;
			return loader;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00075EA4 File Offset: 0x000740A4
		public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			ObjectImporter.<ImportModelAsync>d__31 <ImportModelAsync>d__;
			<ImportModelAsync>d__.<>t__builder = AsyncTaskMethodBuilder<GameObject>.Create();
			<ImportModelAsync>d__.<>4__this = this;
			<ImportModelAsync>d__.objName = objName;
			<ImportModelAsync>d__.filePath = filePath;
			<ImportModelAsync>d__.parentObj = parentObj;
			<ImportModelAsync>d__.options = options;
			<ImportModelAsync>d__.texturesFolderPath = texturesFolderPath;
			<ImportModelAsync>d__.materialsFolderPath = materialsFolderPath;
			<ImportModelAsync>d__.<>1__state = -1;
			<ImportModelAsync>d__.<>t__builder.Start<ObjectImporter.<ImportModelAsync>d__31>(ref <ImportModelAsync>d__);
			return <ImportModelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00075F1C File Offset: 0x0007411C
		public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options)
		{
			ObjectImporter.<ImportModelFromNetwork>d__32 <ImportModelFromNetwork>d__;
			<ImportModelFromNetwork>d__.<>t__builder = AsyncTaskMethodBuilder<GameObject>.Create();
			<ImportModelFromNetwork>d__.<>4__this = this;
			<ImportModelFromNetwork>d__.objURL = objURL;
			<ImportModelFromNetwork>d__.objName = objName;
			<ImportModelFromNetwork>d__.diffuseTexURL = diffuseTexURL;
			<ImportModelFromNetwork>d__.bumpTexURL = bumpTexURL;
			<ImportModelFromNetwork>d__.specularTexURL = specularTexURL;
			<ImportModelFromNetwork>d__.opacityTexURL = opacityTexURL;
			<ImportModelFromNetwork>d__.materialURL = materialURL;
			<ImportModelFromNetwork>d__.downloadProgress = downloadProgress;
			<ImportModelFromNetwork>d__.options = options;
			<ImportModelFromNetwork>d__.<>1__state = -1;
			<ImportModelFromNetwork>d__.<>t__builder.Start<ObjectImporter.<ImportModelFromNetwork>d__32>(ref <ImportModelFromNetwork>d__);
			return <ImportModelFromNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00075FB0 File Offset: 0x000741B0
		public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			if (this.loaderList == null)
			{
				this.loaderList = new List<Loader>();
			}
			if (this.loaderList.Count == 0)
			{
				this.numTotalImports = 0;
				Action importingStart = this.ImportingStart;
				if (importingStart != null)
				{
					importingStart();
				}
			}
			Loader loader = this.CreateLoader("", true);
			if (loader == null)
			{
				OnError(new SystemException("Loader initialization failed due to unknown reasons."));
			}
			this.numTotalImports++;
			this.loaderList.Add(loader);
			loader.buildOptions = options;
			this.allLoaded = false;
			if (string.IsNullOrWhiteSpace(objName))
			{
				objName = "";
			}
			ObjectImporter.downloadProgress = downloadProgress;
			base.StartCoroutine(loader.LoadFromNetworkWebGL(objURL, diffuseTexURL, bumpTexURL, specularTexURL, opacityTexURL, materialURL, objName, OnSuccess, OnError));
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00076078 File Offset: 0x00074278
		public virtual void UpdateStatus()
		{
			if (this.allLoaded)
			{
				return;
			}
			if (this.numTotalImports - Loader.totalProgress.singleProgress.Count >= this.numTotalImports)
			{
				this.allLoaded = true;
				if (this.loaderList != null)
				{
					foreach (Loader obj in this.loaderList)
					{
						Object.Destroy(obj);
					}
					this.loaderList.Clear();
				}
				this.OnImportingComplete();
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00076114 File Offset: 0x00074314
		protected virtual void Update()
		{
			this.UpdateStatus();
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0007611C File Offset: 0x0007431C
		protected virtual void OnImportingComplete()
		{
			if (this.ImportingComplete != null)
			{
				this.ImportingComplete();
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00076131 File Offset: 0x00074331
		protected virtual void OnModelCreated(GameObject obj, string absolutePath)
		{
			if (this.CreatedModel != null)
			{
				this.CreatedModel(obj, absolutePath);
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00076148 File Offset: 0x00074348
		protected virtual void OnImported(GameObject obj, string absolutePath)
		{
			if (this.ImportedModel != null)
			{
				this.ImportedModel(obj, absolutePath);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0007615F File Offset: 0x0007435F
		protected virtual void OnImportError(string absolutePath)
		{
			if (this.ImportError != null)
			{
				this.ImportError(absolutePath);
			}
		}

		// Token: 0x04001463 RID: 5219
		public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		// Token: 0x04001464 RID: 5220
		public static int activeDownloads;

		// Token: 0x04001465 RID: 5221
		private static float objDownloadProgress;

		// Token: 0x04001466 RID: 5222
		private static float textureDownloadProgress;

		// Token: 0x04001467 RID: 5223
		private static float materialDownloadProgress;

		// Token: 0x04001468 RID: 5224
		public static bool isException;

		// Token: 0x04001469 RID: 5225
		protected int numTotalImports;

		// Token: 0x0400146A RID: 5226
		protected bool allLoaded;

		// Token: 0x0400146B RID: 5227
		protected ImportOptions buildOptions;

		// Token: 0x0400146C RID: 5228
		protected List<Loader> loaderList;

		// Token: 0x0400146D RID: 5229
		private ObjectImporter.ImportPhase importPhase;

		// Token: 0x02000C35 RID: 3125
		private enum ImportPhase
		{
			// Token: 0x04003E01 RID: 15873
			Idle,
			// Token: 0x04003E02 RID: 15874
			TextureImport,
			// Token: 0x04003E03 RID: 15875
			ObjLoad,
			// Token: 0x04003E04 RID: 15876
			AssetBuild,
			// Token: 0x04003E05 RID: 15877
			Done
		}
	}
}
