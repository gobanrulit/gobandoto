using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200036A RID: 874
	[Serializable]
	public class ModelImportInfo
	{
		// Token: 0x0400145B RID: 5211
		[Tooltip("Name for the game object created\n(leave it blank to use its file name)")]
		public string name;

		// Token: 0x0400145C RID: 5212
		[Tooltip("Path relative to the project folder")]
		public string path;

		// Token: 0x0400145D RID: 5213
		[Tooltip("Check this to skip this model")]
		public bool skip;

		// Token: 0x0400145E RID: 5214
		public ImportOptions loaderOptions;
	}
}
