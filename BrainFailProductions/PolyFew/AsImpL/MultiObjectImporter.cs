using System;
using System.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200036B RID: 875
	public class MultiObjectImporter : ObjectImporter
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x000759FE File Offset: 0x00073BFE
		public string RootPath
		{
			get
			{
				if (!(this.pathSettings != null))
				{
					return "";
				}
				return this.pathSettings.RootPath;
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00075A20 File Offset: 0x00073C20
		public void ImportModelListAsync(ModelImportInfo[] modelsInfo)
		{
			if (modelsInfo == null)
			{
				return;
			}
			for (int i = 0; i < modelsInfo.Length; i++)
			{
				if (!modelsInfo[i].skip)
				{
					string name = modelsInfo[i].name;
					string text = modelsInfo[i].path;
					if (string.IsNullOrEmpty(text))
					{
						Debug.LogErrorFormat("File path missing for the model at position {0} in the list.", new object[]
						{
							i
						});
					}
					else
					{
						text = this.RootPath + text;
						ImportOptions loaderOptions = modelsInfo[i].loaderOptions;
						if (loaderOptions == null || loaderOptions.modelScaling == 0f)
						{
							loaderOptions = this.defaultImportOptions;
						}
						base.ImportModelAsync(name, text, base.transform, loaderOptions, "", "");
					}
				}
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00075ACB File Offset: 0x00073CCB
		protected virtual void Start()
		{
			if (this.autoLoadOnStart)
			{
				this.ImportModelListAsync(this.objectsList.ToArray());
			}
		}

		// Token: 0x0400145F RID: 5215
		[Tooltip("Load models in the list on start")]
		public bool autoLoadOnStart;

		// Token: 0x04001460 RID: 5216
		[Tooltip("Models to load on startup")]
		public List<ModelImportInfo> objectsList = new List<ModelImportInfo>();

		// Token: 0x04001461 RID: 5217
		[Tooltip("Default import options")]
		public ImportOptions defaultImportOptions = new ImportOptions();

		// Token: 0x04001462 RID: 5218
		[SerializeField]
		private PathSettings pathSettings;
	}
}
