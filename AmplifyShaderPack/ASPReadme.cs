using System;
using UnityEngine;

namespace AmplifyShaderPack
{
	// Token: 0x020003B2 RID: 946
	public class ASPReadme : ScriptableObject
	{
		// Token: 0x06001416 RID: 5142 RVA: 0x0008BDC0 File Offset: 0x00089FC0
		public ASPReadme()
		{
			this.Description = new ASPReadme.ASPSection(string.Empty, "Place description here", string.Empty, string.Empty);
			this.PropertiesHeader = new ASPReadme.ASPSection("Properties", string.Empty, string.Empty, string.Empty);
		}

		// Token: 0x040016EB RID: 5867
		public Texture2D Icon;

		// Token: 0x040016EC RID: 5868
		public string Title;

		// Token: 0x040016ED RID: 5869
		public ASPReadme.ASPSection Description;

		// Token: 0x040016EE RID: 5870
		public ASPReadme.ASPSection PropertiesHeader;

		// Token: 0x040016EF RID: 5871
		public ASPReadme.ASPSection[] Properties;

		// Token: 0x040016F0 RID: 5872
		public ASPReadme.ASPBlock[] AdditionalProperties;

		// Token: 0x040016F1 RID: 5873
		public ASPReadme.ASPBlock[] AdditionalScripts;

		// Token: 0x040016F2 RID: 5874
		public bool LoadedLayout;

		// Token: 0x040016F3 RID: 5875
		public ASPReadme.SampleRPType RPType;

		// Token: 0x02000C65 RID: 3173
		public enum SampleRPType
		{
			// Token: 0x04003F27 RID: 16167
			Builtin,
			// Token: 0x04003F28 RID: 16168
			HDRP,
			// Token: 0x04003F29 RID: 16169
			URP,
			// Token: 0x04003F2A RID: 16170
			None
		}

		// Token: 0x02000C66 RID: 3174
		[Serializable]
		public class ASPSection
		{
			// Token: 0x06005BA8 RID: 23464 RVA: 0x001FB619 File Offset: 0x001F9819
			public ASPSection(string heading, string text, string linkText, string url)
			{
				this.Heading = heading;
				this.Text = text;
				this.LinkText = linkText;
				this.Url = url;
			}

			// Token: 0x04003F2B RID: 16171
			public string Heading;

			// Token: 0x04003F2C RID: 16172
			public string Text;

			// Token: 0x04003F2D RID: 16173
			public string LinkText;

			// Token: 0x04003F2E RID: 16174
			public string Url;
		}

		// Token: 0x02000C67 RID: 3175
		[Serializable]
		public class ASPBlock
		{
			// Token: 0x04003F2F RID: 16175
			public ASPReadme.ASPSection BlockHeader;

			// Token: 0x04003F30 RID: 16176
			public ASPReadme.ASPSection[] BlockContent;
		}
	}
}
