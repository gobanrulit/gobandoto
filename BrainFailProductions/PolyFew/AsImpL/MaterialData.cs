using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x02000360 RID: 864
	public class MaterialData
	{
		// Token: 0x04001418 RID: 5144
		public string materialName;

		// Token: 0x04001419 RID: 5145
		public Color ambientColor;

		// Token: 0x0400141A RID: 5146
		public Color diffuseColor;

		// Token: 0x0400141B RID: 5147
		public Color specularColor;

		// Token: 0x0400141C RID: 5148
		public Color emissiveColor;

		// Token: 0x0400141D RID: 5149
		public float shininess;

		// Token: 0x0400141E RID: 5150
		public float overallAlpha = 1f;

		// Token: 0x0400141F RID: 5151
		public int illumType;

		// Token: 0x04001420 RID: 5152
		public bool hasReflectionTex;

		// Token: 0x04001421 RID: 5153
		public string diffuseTexPath;

		// Token: 0x04001422 RID: 5154
		public Texture2D diffuseTex;

		// Token: 0x04001423 RID: 5155
		public string bumpTexPath;

		// Token: 0x04001424 RID: 5156
		public Texture2D bumpTex;

		// Token: 0x04001425 RID: 5157
		public string specularTexPath;

		// Token: 0x04001426 RID: 5158
		public Texture2D specularTex;

		// Token: 0x04001427 RID: 5159
		public string opacityTexPath;

		// Token: 0x04001428 RID: 5160
		public Texture2D opacityTex;
	}
}
