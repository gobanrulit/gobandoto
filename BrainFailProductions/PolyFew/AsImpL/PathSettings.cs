using System;
using System.IO;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200036F RID: 879
	public class PathSettings : MonoBehaviour
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x000765E0 File Offset: 0x000747E0
		public string RootPath
		{
			get
			{
				switch (this.defaultRootPath)
				{
				case RootPathEnum.DataPath:
					return Application.dataPath + "/";
				case RootPathEnum.DataPathParent:
					return Application.dataPath + "/../";
				case RootPathEnum.PersistentDataPath:
					return Application.persistentDataPath + "/";
				default:
					return "";
				}
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00076640 File Offset: 0x00074840
		public static PathSettings FindPathComponent(GameObject obj)
		{
			PathSettings pathSettings = obj.GetComponent<PathSettings>();
			if (pathSettings == null)
			{
				pathSettings = Object.FindObjectOfType<PathSettings>();
			}
			if (pathSettings == null)
			{
				pathSettings = obj.AddComponent<PathSettings>();
			}
			return pathSettings;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00076674 File Offset: 0x00074874
		public string FullPath(string path)
		{
			string result = path;
			if (!Path.IsPathRooted(path))
			{
				result = this.RootPath + path;
			}
			return result;
		}

		// Token: 0x0400147D RID: 5245
		[Tooltip("Default root path for models")]
		public RootPathEnum defaultRootPath;

		// Token: 0x0400147E RID: 5246
		[Tooltip("Root path for models on mobile devices")]
		public RootPathEnum mobileRootPath;
	}
}
