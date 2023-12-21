using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x02000361 RID: 865
	public class ModelUtil
	{
		// Token: 0x06001209 RID: 4617 RVA: 0x00071C5C File Offset: 0x0006FE5C
		public static void SetupMaterialWithBlendMode(Material mtl, ModelUtil.MtlBlendMode mode)
		{
			switch (mode)
			{
			case ModelUtil.MtlBlendMode.OPAQUE:
				mtl.SetOverrideTag("RenderType", "Opaque");
				mtl.SetFloat("_Mode", 0f);
				mtl.SetInt("_SrcBlend", 1);
				mtl.SetInt("_DstBlend", 0);
				mtl.SetInt("_ZWrite", 1);
				mtl.DisableKeyword("_ALPHATEST_ON");
				mtl.DisableKeyword("_ALPHABLEND_ON");
				mtl.DisableKeyword("_ALPHAPREMULTIPLY_ON");
				mtl.renderQueue = -1;
				return;
			case ModelUtil.MtlBlendMode.CUTOUT:
				mtl.SetOverrideTag("RenderType", "TransparentCutout");
				mtl.SetFloat("_Mode", 1f);
				mtl.SetFloat("_Mode", 1f);
				mtl.SetInt("_SrcBlend", 1);
				mtl.SetInt("_DstBlend", 0);
				mtl.SetInt("_ZWrite", 1);
				mtl.EnableKeyword("_ALPHATEST_ON");
				mtl.DisableKeyword("_ALPHABLEND_ON");
				mtl.DisableKeyword("_ALPHAPREMULTIPLY_ON");
				mtl.renderQueue = 2450;
				return;
			case ModelUtil.MtlBlendMode.FADE:
				mtl.SetOverrideTag("RenderType", "Transparent");
				mtl.SetFloat("_Mode", 2f);
				mtl.SetInt("_SrcBlend", 5);
				mtl.SetInt("_DstBlend", 10);
				mtl.SetInt("_ZWrite", 0);
				mtl.DisableKeyword("_ALPHATEST_ON");
				mtl.EnableKeyword("_ALPHABLEND_ON");
				mtl.DisableKeyword("_ALPHAPREMULTIPLY_ON");
				mtl.renderQueue = 3000;
				return;
			case ModelUtil.MtlBlendMode.TRANSPARENT:
				mtl.SetOverrideTag("RenderType", "Transparent");
				mtl.SetFloat("_Mode", 3f);
				mtl.SetInt("_SrcBlend", 1);
				mtl.SetInt("_DstBlend", 10);
				mtl.SetInt("_ZWrite", 0);
				mtl.DisableKeyword("_ALPHATEST_ON");
				mtl.DisableKeyword("_ALPHABLEND_ON");
				mtl.EnableKeyword("_ALPHAPREMULTIPLY_ON");
				mtl.renderQueue = 3000;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00071E54 File Offset: 0x00070054
		public static bool ScanTransparentPixels(Texture2D texture, ref ModelUtil.MtlBlendMode mode)
		{
			if (texture != null && (texture.format == TextureFormat.ARGB32 || texture.format == TextureFormat.RGBA32 || texture.format == TextureFormat.DXT5 || texture.format == TextureFormat.ARGB4444 || texture.format == TextureFormat.BGRA32 || texture.format == TextureFormat.DXT5Crunched))
			{
				bool flag = false;
				int num = 1;
				int num2 = 0;
				while (num2 < texture.width && !flag)
				{
					int num3 = 0;
					while (num3 < texture.height && !flag)
					{
						ModelUtil.DetectMtlBlendFadeOrCutout(texture.GetPixel(num2, num3).a, ref mode, ref flag);
						if (flag)
						{
							return mode == ModelUtil.MtlBlendMode.FADE || mode == ModelUtil.MtlBlendMode.CUTOUT;
						}
						num3 += num;
					}
					num2 += num;
				}
			}
			return mode == ModelUtil.MtlBlendMode.FADE || mode == ModelUtil.MtlBlendMode.CUTOUT;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00071F08 File Offset: 0x00070108
		public static void DetectMtlBlendFadeOrCutout(float alpha, ref ModelUtil.MtlBlendMode mode, ref bool noDoubt)
		{
			if (noDoubt)
			{
				return;
			}
			if (alpha < 1f)
			{
				if (alpha == 0f)
				{
					mode = ModelUtil.MtlBlendMode.CUTOUT;
					return;
				}
				if (mode != ModelUtil.MtlBlendMode.FADE)
				{
					mode = ModelUtil.MtlBlendMode.FADE;
					noDoubt = true;
				}
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00071F30 File Offset: 0x00070130
		public static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
		{
			int height = bumpMap.height;
			int width = bumpMap.width;
			Texture2D texture2D = new Texture2D(width, height, TextureFormat.ARGB32, true);
			Color black = Color.black;
			for (int i = 0; i < bumpMap.height; i++)
			{
				for (int j = 0; j < bumpMap.width; j++)
				{
					Vector3 vector = Vector3.zero;
					float grayscale = bumpMap.GetPixel(ModelUtil.WrapInt(j - 1, width), i).grayscale;
					float grayscale2 = bumpMap.GetPixel(j, i).grayscale;
					float grayscale3 = bumpMap.GetPixel(ModelUtil.WrapInt(j + 1, width), i).grayscale;
					float num = grayscale2 - grayscale;
					float num2 = grayscale3 - grayscale2;
					vector.x = -(num2 + num) / 255f;
					grayscale = bumpMap.GetPixel(j, ModelUtil.WrapInt(i - 1, height)).grayscale;
					grayscale2 = bumpMap.GetPixel(j, i).grayscale;
					float grayscale4 = bumpMap.GetPixel(j, ModelUtil.WrapInt(i + 1, height)).grayscale;
					num = grayscale2 - grayscale;
					num2 = grayscale4 - grayscale2;
					vector.y = -(num2 + num);
					if (amount != 1f)
					{
						vector *= amount;
					}
					vector.z = Mathf.Sqrt(1f - (vector.x * vector.x + vector.y * vector.y));
					vector *= 0.5f;
					black.r = Mathf.Clamp01(vector.x + 0.5f);
					black.g = Mathf.Clamp01(vector.y + 0.5f);
					black.b = Mathf.Clamp01(vector.z + 0.5f);
					black.a = black.r;
					texture2D.SetPixel(j, i, black);
				}
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00072124 File Offset: 0x00070324
		private static int WrapInt(int pos, int boundary)
		{
			if (pos < 0)
			{
				pos = boundary + pos;
			}
			else if (pos >= boundary)
			{
				pos -= boundary;
			}
			return pos;
		}

		// Token: 0x02000C14 RID: 3092
		public enum MtlBlendMode
		{
			// Token: 0x04003D0B RID: 15627
			OPAQUE,
			// Token: 0x04003D0C RID: 15628
			CUTOUT,
			// Token: 0x04003D0D RID: 15629
			FADE,
			// Token: 0x04003D0E RID: 15630
			TRANSPARENT
		}
	}
}
