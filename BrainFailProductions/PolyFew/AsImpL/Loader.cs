using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x02000365 RID: 869
	public abstract class Loader : MonoBehaviour
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000739F1 File Offset: 0x00071BF1
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x00073A08 File Offset: 0x00071C08
		public bool ConvertVertAxis
		{
			get
			{
				return this.buildOptions != null && this.buildOptions.zUp;
			}
			set
			{
				if (this.buildOptions == null)
				{
					this.buildOptions = new ImportOptions();
				}
				this.buildOptions.zUp = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00073A29 File Offset: 0x00071C29
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00073A44 File Offset: 0x00071C44
		public float Scaling
		{
			get
			{
				if (this.buildOptions == null)
				{
					return 1f;
				}
				return this.buildOptions.modelScaling;
			}
			set
			{
				if (this.buildOptions == null)
				{
					this.buildOptions = new ImportOptions();
				}
				this.buildOptions.modelScaling = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06001224 RID: 4644
		protected abstract bool HasMaterialLibrary { get; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001225 RID: 4645 RVA: 0x00073A68 File Offset: 0x00071C68
		// (remove) Token: 0x06001226 RID: 4646 RVA: 0x00073AA0 File Offset: 0x00071CA0
		public event Action<GameObject, string> ModelCreated;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001227 RID: 4647 RVA: 0x00073AD8 File Offset: 0x00071CD8
		// (remove) Token: 0x06001228 RID: 4648 RVA: 0x00073B10 File Offset: 0x00071D10
		public event Action<GameObject, string> ModelLoaded;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001229 RID: 4649 RVA: 0x00073B48 File Offset: 0x00071D48
		// (remove) Token: 0x0600122A RID: 4650 RVA: 0x00073B80 File Offset: 0x00071D80
		public event Action<string> ModelError;

		// Token: 0x0600122B RID: 4651 RVA: 0x00073BB5 File Offset: 0x00071DB5
		public static GameObject GetModelByPath(string absolutePath)
		{
			if (Loader.loadedModels.ContainsKey(absolutePath))
			{
				return Loader.loadedModels[absolutePath];
			}
			return null;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00073BD4 File Offset: 0x00071DD4
		public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			Loader.<Load>d__33 <Load>d__;
			<Load>d__.<>t__builder = AsyncTaskMethodBuilder<GameObject>.Create();
			<Load>d__.<>4__this = this;
			<Load>d__.objName = objName;
			<Load>d__.objAbsolutePath = objAbsolutePath;
			<Load>d__.parentObj = parentObj;
			<Load>d__.texturesFolderPath = texturesFolderPath;
			<Load>d__.materialsFolderPath = materialsFolderPath;
			<Load>d__.<>1__state = -1;
			<Load>d__.<>t__builder.Start<Loader.<Load>d__33>(ref <Load>d__);
			return <Load>d__.<>t__builder.Task;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00073C44 File Offset: 0x00071E44
		public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName)
		{
			Loader.<LoadFromNetwork>d__34 <LoadFromNetwork>d__;
			<LoadFromNetwork>d__.<>t__builder = AsyncTaskMethodBuilder<GameObject>.Create();
			<LoadFromNetwork>d__.<>4__this = this;
			<LoadFromNetwork>d__.objURL = objURL;
			<LoadFromNetwork>d__.diffuseTexURL = diffuseTexURL;
			<LoadFromNetwork>d__.bumpTexURL = bumpTexURL;
			<LoadFromNetwork>d__.specularTexURL = specularTexURL;
			<LoadFromNetwork>d__.opacityTexURL = opacityTexURL;
			<LoadFromNetwork>d__.materialURL = materialURL;
			<LoadFromNetwork>d__.objName = objName;
			<LoadFromNetwork>d__.<>1__state = -1;
			<LoadFromNetwork>d__.<>t__builder.Start<Loader.<LoadFromNetwork>d__34>(ref <LoadFromNetwork>d__);
			return <LoadFromNetwork>d__.<>t__builder.Task;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00073CC4 File Offset: 0x00071EC4
		public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			string text = objName + ".obj";
			Loader.totalProgress.singleProgress.Add(this.objLoadingProgress);
			this.objLoadingProgress.fileName = text;
			this.objLoadingProgress.error = false;
			this.objLoadingProgress.message = "Loading " + text + "...";
			Loader.loadedModels[objURL] = null;
			Loader.instanceCount[objURL] = 0;
			float lastTime = Time.realtimeSinceStartup;
			float startTime = lastTime;
			yield return base.StartCoroutine(this.LoadModelFileNetworkedWebGL(objURL, OnError));
			if (ObjectImporter.isException)
			{
				yield return null;
			}
			this.loadStats.modelParseTime = Time.realtimeSinceStartup - lastTime;
			if (this.objLoadingProgress.error)
			{
				this.OnLoadFailed(objURL);
				OnError(new Exception("Load failed due to unknown reasons."));
				yield return null;
			}
			lastTime = Time.realtimeSinceStartup;
			if (this.HasMaterialLibrary)
			{
				yield return base.StartCoroutine(this.LoadMaterialLibraryWebGL(materialURL));
			}
			else
			{
				ObjectImporter.activeDownloads--;
			}
			if (ObjectImporter.isException)
			{
				yield return null;
			}
			this.loadStats.materialsParseTime = Time.realtimeSinceStartup - lastTime;
			lastTime = Time.realtimeSinceStartup;
			yield return base.StartCoroutine(this.NetworkedBuildWebGL(null, objName, objURL, diffuseTexURL, bumpTexURL, specularTexURL, opacityTexURL));
			if (ObjectImporter.isException)
			{
				yield return null;
			}
			this.loadStats.buildTime = Time.realtimeSinceStartup - lastTime;
			this.loadStats.totalTime = Time.realtimeSinceStartup - startTime;
			Loader.totalProgress.singleProgress.Remove(this.objLoadingProgress);
			this.OnLoaded(Loader.loadedModels[objURL], objURL);
			OnSuccess(Loader.loadedModels[objURL]);
			yield break;
		}

		// Token: 0x0600122F RID: 4655
		public abstract string[] ParseTexturePaths(string absolutePath);

		// Token: 0x06001230 RID: 4656
		protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

		// Token: 0x06001231 RID: 4657
		protected abstract Task LoadModelFileNetworked(string objURL);

		// Token: 0x06001232 RID: 4658
		protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

		// Token: 0x06001233 RID: 4659
		protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

		// Token: 0x06001234 RID: 4660
		protected abstract Task LoadMaterialLibrary(string materialURL);

		// Token: 0x06001235 RID: 4661
		protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

		// Token: 0x06001236 RID: 4662 RVA: 0x00073D24 File Offset: 0x00071F24
		protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "")
		{
			Loader.<Build>d__43 <Build>d__;
			<Build>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Build>d__.<>4__this = this;
			<Build>d__.absolutePath = absolutePath;
			<Build>d__.objName = objName;
			<Build>d__.parentTransform = parentTransform;
			<Build>d__.texturesFolderPath = texturesFolderPath;
			<Build>d__.<>1__state = -1;
			<Build>d__.<>t__builder.Start<Loader.<Build>d__43>(ref <Build>d__);
			return <Build>d__.<>t__builder.Task;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00073D88 File Offset: 0x00071F88
		protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			Loader.<NetworkedBuild>d__44 <NetworkedBuild>d__;
			<NetworkedBuild>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<NetworkedBuild>d__.<>4__this = this;
			<NetworkedBuild>d__.parentTransform = parentTransform;
			<NetworkedBuild>d__.objName = objName;
			<NetworkedBuild>d__.objURL = objURL;
			<NetworkedBuild>d__.diffuseTexURL = diffuseTexURL;
			<NetworkedBuild>d__.bumpTexURL = bumpTexURL;
			<NetworkedBuild>d__.specularTexURL = specularTexURL;
			<NetworkedBuild>d__.opacityTexURL = opacityTexURL;
			<NetworkedBuild>d__.<>1__state = -1;
			<NetworkedBuild>d__.<>t__builder.Start<Loader.<NetworkedBuild>d__44>(ref <NetworkedBuild>d__);
			return <NetworkedBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00073E08 File Offset: 0x00072008
		protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			float prevTime = Time.realtimeSinceStartup;
			if (this.materialData != null)
			{
				this.objLoadingProgress.message = "Loading textures...";
				int count = 0;
				foreach (MaterialData mtl in this.materialData)
				{
					this.objLoadingProgress.percentage = Loader.LOAD_PHASE_PERC + Loader.TEXTURE_PHASE_PERC * (float)count / (float)this.materialData.Count;
					int num = count;
					count = num + 1;
					if (mtl.diffuseTexPath != null)
					{
						if (!string.IsNullOrWhiteSpace(diffuseTexURL))
						{
							yield return base.StartCoroutine(this.LoadMaterialTextureWebGL(diffuseTexURL));
						}
						else
						{
							ObjectImporter.activeDownloads--;
						}
						mtl.diffuseTex = this.loadedTexture;
					}
					else
					{
						ObjectImporter.activeDownloads--;
					}
					ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
					if (mtl.bumpTexPath != null)
					{
						if (!string.IsNullOrWhiteSpace(bumpTexURL))
						{
							yield return base.StartCoroutine(this.LoadMaterialTextureWebGL(bumpTexURL));
						}
						else
						{
							ObjectImporter.activeDownloads--;
						}
						mtl.bumpTex = this.loadedTexture;
					}
					else
					{
						ObjectImporter.activeDownloads--;
					}
					ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
					if (mtl.specularTexPath != null)
					{
						if (!string.IsNullOrWhiteSpace(specularTexURL))
						{
							yield return base.StartCoroutine(this.LoadMaterialTextureWebGL(specularTexURL));
						}
						else
						{
							ObjectImporter.activeDownloads--;
						}
						mtl.specularTex = this.loadedTexture;
					}
					else
					{
						ObjectImporter.activeDownloads--;
					}
					ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
					if (mtl.opacityTexPath != null)
					{
						if (!string.IsNullOrWhiteSpace(opacityTexURL))
						{
							yield return base.StartCoroutine(this.LoadMaterialTextureWebGL(opacityTexURL));
						}
						else
						{
							ObjectImporter.activeDownloads--;
						}
						mtl.opacityTex = this.loadedTexture;
					}
					else
					{
						ObjectImporter.activeDownloads--;
					}
					ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
					mtl = null;
				}
				List<MaterialData>.Enumerator enumerator = default(List<MaterialData>.Enumerator);
			}
			this.loadStats.buildStats.texturesTime = Time.realtimeSinceStartup - prevTime;
			prevTime = Time.realtimeSinceStartup;
			ObjectBuilder.ProgressInfo progressInfo = new ObjectBuilder.ProgressInfo();
			this.objLoadingProgress.message = "Loading materials...";
			this.objectBuilder.buildOptions = this.buildOptions;
			bool hasColors = this.dataSet.colorList.Count > 0;
			bool flag = this.materialData != null;
			this.objectBuilder.InitBuildMaterials(this.materialData, hasColors);
			float percentage = this.objLoadingProgress.percentage;
			if (flag)
			{
				while (this.objectBuilder.BuildMaterials(progressInfo))
				{
					this.objLoadingProgress.percentage = percentage + Loader.MATERIAL_PHASE_PERC * (float)this.objectBuilder.NumImportedMaterials / (float)this.materialData.Count;
				}
				this.loadStats.buildStats.materialsTime = Time.realtimeSinceStartup - prevTime;
				prevTime = Time.realtimeSinceStartup;
			}
			this.objLoadingProgress.message = "Building scene objects...";
			GameObject gameObject = new GameObject(objName);
			if (this.buildOptions.hideWhileLoading)
			{
				gameObject.SetActive(false);
			}
			if (parentTransform != null)
			{
				gameObject.transform.SetParent(parentTransform.transform, false);
			}
			this.OnCreated(gameObject, objURL);
			float percentage2 = this.objLoadingProgress.percentage;
			this.objectBuilder.StartBuildObjectAsync(this.dataSet, gameObject, null);
			while (this.objectBuilder.BuildObjectAsync(ref progressInfo))
			{
				this.objLoadingProgress.message = "Building scene objects... " + (progressInfo.objectsLoaded + progressInfo.groupsLoaded).ToString() + "/" + (this.dataSet.objectList.Count + progressInfo.numGroups).ToString();
				this.objLoadingProgress.percentage = percentage2 + Loader.BUILD_PHASE_PERC * ((float)(progressInfo.objectsLoaded / this.dataSet.objectList.Count) + (float)progressInfo.groupsLoaded / (float)progressInfo.numGroups);
			}
			this.objLoadingProgress.percentage = 100f;
			Loader.loadedModels[objURL] = gameObject;
			this.loadStats.buildStats.objectsTime = Time.realtimeSinceStartup - prevTime;
			yield break;
			yield break;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00073E58 File Offset: 0x00072058
		protected string GetDirName(string absolutePath)
		{
			string text;
			if (absolutePath.Contains("//"))
			{
				text = absolutePath.Remove(absolutePath.LastIndexOf('/') + 1);
			}
			else
			{
				string directoryName = Path.GetDirectoryName(absolutePath);
				text = (string.IsNullOrEmpty(directoryName) ? "" : directoryName);
				if (!text.EndsWith("/"))
				{
					text += "/";
				}
			}
			return text;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00073EB8 File Offset: 0x000720B8
		protected virtual void OnLoaded(GameObject obj, string absolutePath)
		{
			if (obj == null)
			{
				if (this.ModelError != null)
				{
					this.ModelError(absolutePath);
					return;
				}
			}
			else
			{
				if (this.buildOptions != null)
				{
					obj.transform.localPosition = this.buildOptions.localPosition;
					obj.transform.localRotation = Quaternion.Euler(this.buildOptions.localEulerAngles);
					obj.transform.localScale = this.buildOptions.localScale;
					if (this.buildOptions.inheritLayer)
					{
						obj.layer = obj.transform.parent.gameObject.layer;
						MeshRenderer[] componentsInChildren = obj.transform.GetComponentsInChildren<MeshRenderer>(true);
						for (int i = 0; i < componentsInChildren.Length; i++)
						{
							componentsInChildren[i].gameObject.layer = obj.transform.parent.gameObject.layer;
						}
					}
				}
				if (this.buildOptions.hideWhileLoading)
				{
					obj.SetActive(true);
				}
				if (this.ModelLoaded != null)
				{
					this.ModelLoaded(obj, absolutePath);
				}
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00073FC6 File Offset: 0x000721C6
		protected virtual void OnCreated(GameObject obj, string absolutePath)
		{
			if (obj == null)
			{
				if (this.ModelError != null)
				{
					this.ModelError(absolutePath);
					return;
				}
			}
			else if (this.ModelCreated != null)
			{
				this.ModelCreated(obj, absolutePath);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00073FFB File Offset: 0x000721FB
		protected virtual void OnLoadFailed(string absolutePath)
		{
			if (this.ModelError != null)
			{
				this.ModelError(absolutePath);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00074014 File Offset: 0x00072214
		private string GetTextureUrl(string basePath, string texturePath)
		{
			string text = texturePath.Replace("\\", "/").Replace("//", "/");
			if (!Path.IsPathRooted(text))
			{
				text = basePath + texturePath;
			}
			if (!text.Contains("//"))
			{
				text = "file:///" + text;
			}
			this.objLoadingProgress.message = "Loading textures...\n" + text;
			return text;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00074084 File Offset: 0x00072284
		private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "")
		{
			Loader.<LoadMaterialTexture>d__51 <LoadMaterialTexture>d__;
			<LoadMaterialTexture>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadMaterialTexture>d__.<>4__this = this;
			<LoadMaterialTexture>d__.basePath = basePath;
			<LoadMaterialTexture>d__.path = path;
			<LoadMaterialTexture>d__.texturesFolderPath = texturesFolderPath;
			<LoadMaterialTexture>d__.<>1__state = -1;
			<LoadMaterialTexture>d__.<>t__builder.Start<Loader.<LoadMaterialTexture>d__51>(ref <LoadMaterialTexture>d__);
			return <LoadMaterialTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000740E0 File Offset: 0x000722E0
		private Task LoadMaterialTexture(string textureURL)
		{
			Loader.<LoadMaterialTexture>d__52 <LoadMaterialTexture>d__;
			<LoadMaterialTexture>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadMaterialTexture>d__.<>4__this = this;
			<LoadMaterialTexture>d__.textureURL = textureURL;
			<LoadMaterialTexture>d__.<>1__state = -1;
			<LoadMaterialTexture>d__.<>t__builder.Start<Loader.<LoadMaterialTexture>d__52>(ref <LoadMaterialTexture>d__);
			return <LoadMaterialTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0007412B File Offset: 0x0007232B
		private IEnumerator LoadMaterialTextureWebGL(string textureURL)
		{
			this.loadedTexture = null;
			bool isWorking = true;
			float value = this.individualProgress.Value;
			try
			{
				base.StartCoroutine(this.DownloadTexFileWebGL(textureURL, this.individualProgress, delegate(Texture2D texture)
				{
					isWorking = false;
					this.loadedTexture = texture;
				}, delegate(string error)
				{
					ObjectImporter.activeDownloads--;
					isWorking = false;
					Debug.LogWarning("Failed to load the associated texture file." + error);
				}));
				goto IL_125;
			}
			catch (Exception ex)
			{
				ObjectImporter.activeDownloads--;
				this.individualProgress.Value = value;
				ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
				isWorking = false;
				throw ex;
			}
			IL_E3:
			yield return new WaitForSeconds(0.1f);
			ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
			IL_125:
			if (!isWorking)
			{
				ObjectImporter.downloadProgress.Value = this.individualProgress.Value / (float)ObjectImporter.activeDownloads * 100f;
				if (this.loadedTexture == null)
				{
					Debug.LogWarning("Failed to load texture.");
				}
				yield break;
			}
			goto IL_E3;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00074144 File Offset: 0x00072344
		private Texture2D LoadTexture(UnityWebRequest loader)
		{
			string text = Path.GetExtension(loader.url).ToLower();
			Texture2D texture2D = null;
			if (text == ".tga")
			{
				texture2D = TextureLoader.LoadTextureFromUrl(loader.url);
			}
			else if (text == ".png" || text == ".jpg" || text == ".jpeg")
			{
				texture2D = DownloadHandlerTexture.GetContent(loader);
			}
			else
			{
				Debug.LogWarning("Unsupported texture format: " + text);
			}
			if (texture2D == null)
			{
				Debug.LogErrorFormat("Failed to load texture {0}", new object[]
				{
					loader.url
				});
			}
			return texture2D;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000741E2 File Offset: 0x000723E2
		public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError)
		{
			UnityWebRequest webrequest = null;
			float oldProgress = downloadProgress.Value;
			try
			{
				webrequest = new UnityWebRequest(url);
				webrequest.downloadHandler = new DownloadHandlerBuffer();
			}
			catch (Exception ex)
			{
				downloadProgress.Value = oldProgress;
				OnError(ex.ToString());
			}
			Coroutine progress = base.StartCoroutine(this.GetProgress(webrequest, downloadProgress));
			yield return webrequest.SendWebRequest();
			if (!string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			else if (webrequest.downloadedBytes == 0UL)
			{
				if (string.IsNullOrWhiteSpace(webrequest.error))
				{
					downloadProgress.Value = oldProgress;
					OnError("No bytes downloaded. The file might be empty.");
				}
				else
				{
					downloadProgress.Value = oldProgress;
					OnError(webrequest.error);
				}
			}
			else if (string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress + 1f;
				DownloadComplete(webrequest.downloadHandler.data);
			}
			else
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			base.StopCoroutine(progress);
			webrequest.Dispose();
			yield break;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0007420E File Offset: 0x0007240E
		private IEnumerator GetProgress(UnityWebRequest webrequest, PolyfewRuntime.ReferencedNumeric<float> downloadProgress)
		{
			float oldProgress = downloadProgress.Value;
			if (webrequest != null && downloadProgress != null)
			{
				while (!webrequest.downloadHandler.isDone && string.IsNullOrWhiteSpace(webrequest.error))
				{
					yield return new WaitForSeconds(0.1f);
					downloadProgress.Value = oldProgress + webrequest.downloadProgress;
				}
				if (webrequest.downloadHandler.isDone && string.IsNullOrWhiteSpace(webrequest.error))
				{
					downloadProgress.Value = oldProgress + webrequest.downloadProgress;
					Debug.Log("Progress  " + webrequest.downloadProgress.ToString());
				}
			}
			yield break;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00074224 File Offset: 0x00072424
		public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError)
		{
			UnityWebRequest webrequest = null;
			float oldProgress = downloadProgress.Value;
			try
			{
				webrequest = new UnityWebRequest(url);
				webrequest.downloadHandler = new DownloadHandlerBuffer();
			}
			catch (Exception ex)
			{
				downloadProgress.Value = oldProgress;
				OnError(ex.ToString());
			}
			Coroutine progress = base.StartCoroutine(this.GetProgress(webrequest, downloadProgress));
			yield return webrequest;
			if (!string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			else if (webrequest.downloadedBytes == 0UL)
			{
				if (string.IsNullOrWhiteSpace(webrequest.error))
				{
					downloadProgress.Value = oldProgress;
					OnError("No bytes downloaded. The file might be empty.");
				}
				else
				{
					downloadProgress.Value = oldProgress;
					OnError(webrequest.error);
				}
			}
			else if (string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress + 1f;
				DownloadComplete(webrequest.downloadHandler.text);
			}
			else
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			try
			{
				base.StopCoroutine(progress);
			}
			catch (Exception)
			{
			}
			webrequest.Dispose();
			yield break;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00074250 File Offset: 0x00072450
		public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError)
		{
			UnityWebRequest webrequest = null;
			float oldProgress = downloadProgress.Value;
			try
			{
				webrequest = new UnityWebRequest(url);
				webrequest.downloadHandler = new DownloadHandlerBuffer();
			}
			catch (Exception ex)
			{
				downloadProgress.Value = oldProgress;
				OnError(ex.ToString());
			}
			Coroutine progress = base.StartCoroutine(this.GetProgress(webrequest, downloadProgress));
			yield return webrequest;
			if (!string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			else if (webrequest.downloadedBytes == 0UL)
			{
				if (string.IsNullOrWhiteSpace(webrequest.error))
				{
					downloadProgress.Value = oldProgress;
					OnError("No bytes downloaded. The file might be empty.");
				}
				else
				{
					downloadProgress.Value = oldProgress;
					OnError(webrequest.error);
				}
			}
			else if (string.IsNullOrWhiteSpace(webrequest.error))
			{
				downloadProgress.Value = oldProgress + 1f;
				DownloadComplete(((DownloadHandlerTexture)webrequest.downloadHandler).texture);
			}
			else
			{
				downloadProgress.Value = oldProgress;
				OnError(webrequest.error);
			}
			base.StopCoroutine(progress);
			webrequest.Dispose();
			yield break;
		}

		// Token: 0x04001440 RID: 5184
		public static LoadingProgress totalProgress = new LoadingProgress();

		// Token: 0x04001441 RID: 5185
		public ImportOptions buildOptions;

		// Token: 0x04001442 RID: 5186
		public PolyfewRuntime.ReferencedNumeric<float> individualProgress = new PolyfewRuntime.ReferencedNumeric<float>(0f);

		// Token: 0x04001443 RID: 5187
		protected static float LOAD_PHASE_PERC = 8f;

		// Token: 0x04001444 RID: 5188
		protected static float TEXTURE_PHASE_PERC = 1f;

		// Token: 0x04001445 RID: 5189
		protected static float MATERIAL_PHASE_PERC = 1f;

		// Token: 0x04001446 RID: 5190
		protected static float BUILD_PHASE_PERC = 90f;

		// Token: 0x04001447 RID: 5191
		protected static Dictionary<string, GameObject> loadedModels = new Dictionary<string, GameObject>();

		// Token: 0x04001448 RID: 5192
		protected static Dictionary<string, int> instanceCount = new Dictionary<string, int>();

		// Token: 0x04001449 RID: 5193
		protected DataSet dataSet = new DataSet();

		// Token: 0x0400144A RID: 5194
		protected ObjectBuilder objectBuilder = new ObjectBuilder();

		// Token: 0x0400144B RID: 5195
		protected List<MaterialData> materialData;

		// Token: 0x0400144C RID: 5196
		protected SingleLoadingProgress objLoadingProgress = new SingleLoadingProgress();

		// Token: 0x0400144D RID: 5197
		protected Loader.Stats loadStats;

		// Token: 0x0400144E RID: 5198
		private Texture2D loadedTexture;

		// Token: 0x02000C17 RID: 3095
		protected struct BuildStats
		{
			// Token: 0x04003D1E RID: 15646
			public float texturesTime;

			// Token: 0x04003D1F RID: 15647
			public float materialsTime;

			// Token: 0x04003D20 RID: 15648
			public float objectsTime;
		}

		// Token: 0x02000C18 RID: 3096
		protected struct Stats
		{
			// Token: 0x04003D21 RID: 15649
			public float modelParseTime;

			// Token: 0x04003D22 RID: 15650
			public float materialsParseTime;

			// Token: 0x04003D23 RID: 15651
			public float buildTime;

			// Token: 0x04003D24 RID: 15652
			public Loader.BuildStats buildStats;

			// Token: 0x04003D25 RID: 15653
			public float totalTime;
		}
	}
}
