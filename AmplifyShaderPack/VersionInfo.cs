using System;

namespace AmplifyShaderPack
{
	// Token: 0x020003B4 RID: 948
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x0008BE28 File Offset: 0x0008A028
		public static string StaticToString()
		{
			return string.Format("{0}.{1}.{2}", 1, 0, 3) + ((VersionInfo.Revision > 0) ? ("r" + VersionInfo.Revision.ToString()) : "");
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0008BE79 File Offset: 0x0008A079
		public static int FullNumber
		{
			get
			{
				return 10300 + (int)VersionInfo.Revision;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0008BE88 File Offset: 0x0008A088
		public static string FullLabel
		{
			get
			{
				return "Version=" + VersionInfo.FullNumber.ToString();
			}
		}

		// Token: 0x040016F5 RID: 5877
		public const byte Major = 1;

		// Token: 0x040016F6 RID: 5878
		public const byte Minor = 0;

		// Token: 0x040016F7 RID: 5879
		public const byte Release = 3;

		// Token: 0x040016F8 RID: 5880
		public static byte Revision;
	}
}
