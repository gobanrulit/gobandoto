using System;
using System.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x02000357 RID: 855
	public class CombiningInformation
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x0006FAFC File Offset: 0x0006DCFC
		public bool ShouldGenerateMetallicArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.metallicMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0006FB5C File Offset: 0x0006DD5C
		public bool ShouldGenerateSpecularArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.specularMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0006FBBC File Offset: 0x0006DDBC
		public bool ShouldGenerateNormalArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.normalMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0006FC1C File Offset: 0x0006DE1C
		public bool ShouldGenerateHeightArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.heightMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0006FC7C File Offset: 0x0006DE7C
		public bool ShouldGenerateOcclusionArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.occlusionMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0006FCDC File Offset: 0x0006DEDC
		public bool ShouldGenerateEmissionArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.emissionMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0006FD3C File Offset: 0x0006DF3C
		public bool ShouldGenerateDetailMaskArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.detailMaskMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0006FD9C File Offset: 0x0006DF9C
		public bool ShouldGenerateDetailAlbedoArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.detailAlbedoMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0006FDFC File Offset: 0x0006DFFC
		public bool ShouldGenerateDetailNormalArray()
		{
			using (List<CombiningInformation.MaterialEntity>.Enumerator enumerator = this.materialEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.detailNormalMap != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040013F3 RID: 5107
		public List<CombiningInformation.MaterialEntity> materialEntities = new List<CombiningInformation.MaterialEntity>();

		// Token: 0x040013F4 RID: 5108
		public CombiningInformation.TextureArrayGroup textureArraysSettings = new CombiningInformation.TextureArrayGroup();

		// Token: 0x040013F5 RID: 5109
		public CombiningInformation.DiffuseColorSpace diffuseColorSpace;

		// Token: 0x040013F6 RID: 5110
		public Material[] combinedMaterials;

		// Token: 0x02000BF5 RID: 3061
		public enum DiffuseColorSpace
		{
			// Token: 0x04003C5A RID: 15450
			NON_LINEAR,
			// Token: 0x04003C5B RID: 15451
			LINEAR
		}

		// Token: 0x02000BF6 RID: 3062
		public enum CompressionType
		{
			// Token: 0x04003C5D RID: 15453
			UNCOMPRESSED,
			// Token: 0x04003C5E RID: 15454
			DXT1,
			// Token: 0x04003C5F RID: 15455
			ETC2_RGB,
			// Token: 0x04003C60 RID: 15456
			PVRTC_RGB4,
			// Token: 0x04003C61 RID: 15457
			ASTC_RGB
		}

		// Token: 0x02000BF7 RID: 3063
		public enum CompressionQuality
		{
			// Token: 0x04003C63 RID: 15459
			LOW,
			// Token: 0x04003C64 RID: 15460
			MEDIUM,
			// Token: 0x04003C65 RID: 15461
			HIGH
		}

		// Token: 0x02000BF8 RID: 3064
		[Serializable]
		public struct Resolution
		{
			// Token: 0x04003C66 RID: 15462
			public int width;

			// Token: 0x04003C67 RID: 15463
			public int height;
		}

		// Token: 0x02000BF9 RID: 3065
		[Serializable]
		public class TextureArrayUserSettings
		{
			// Token: 0x06005A74 RID: 23156 RVA: 0x001F1FDC File Offset: 0x001F01DC
			public TextureArrayUserSettings(CombiningInformation.Resolution resolution, FilterMode filteringMode, CombiningInformation.CompressionType compressionType, CombiningInformation.CompressionQuality compressionQuality = CombiningInformation.CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
				this.resolution = resolution;
				this.filteringMode = filteringMode;
				this.compressionType = compressionType;
				this.compressionQuality = compressionQuality;
				this.anisotropicFilteringLevel = anisotropicFilteringLevel;
			}

			// Token: 0x04003C68 RID: 15464
			public CombiningInformation.Resolution resolution;

			// Token: 0x04003C69 RID: 15465
			public FilterMode filteringMode;

			// Token: 0x04003C6A RID: 15466
			public CombiningInformation.CompressionType compressionType;

			// Token: 0x04003C6B RID: 15467
			public CombiningInformation.CompressionQuality compressionQuality;

			// Token: 0x04003C6C RID: 15468
			public int anisotropicFilteringLevel;

			// Token: 0x04003C6D RID: 15469
			public int choiceResolutionW = 4;

			// Token: 0x04003C6E RID: 15470
			public int choiceResolutionH = 4;

			// Token: 0x04003C6F RID: 15471
			public int choiceFilteringMode;

			// Token: 0x04003C70 RID: 15472
			public int choiceCompressionQuality = 1;

			// Token: 0x04003C71 RID: 15473
			public int choiceCompressionType;
		}

		// Token: 0x02000BFA RID: 3066
		[Serializable]
		public class TextureArrayGroup
		{
			// Token: 0x06005A75 RID: 23157 RVA: 0x001F202C File Offset: 0x001F022C
			public void InitializeDefaultArraySettings(CombiningInformation.Resolution resolution, FilterMode filteringMode, CombiningInformation.CompressionType compressionType, CombiningInformation.CompressionQuality compressionQuality = CombiningInformation.CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
				this.diffuseArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.metallicArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.specularArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.normalArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.heightArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.occlusionArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.emissiveArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.detailMaskArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.detailAlbedoArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
				this.detailNormalArraySettings = new CombiningInformation.TextureArrayUserSettings(resolution, filteringMode, compressionType, compressionQuality, anisotropicFilteringLevel);
			}

			// Token: 0x04003C72 RID: 15474
			public CombiningInformation.TextureArrayUserSettings diffuseArraySettings;

			// Token: 0x04003C73 RID: 15475
			public CombiningInformation.TextureArrayUserSettings metallicArraySettings;

			// Token: 0x04003C74 RID: 15476
			public CombiningInformation.TextureArrayUserSettings specularArraySettings;

			// Token: 0x04003C75 RID: 15477
			public CombiningInformation.TextureArrayUserSettings normalArraySettings;

			// Token: 0x04003C76 RID: 15478
			public CombiningInformation.TextureArrayUserSettings heightArraySettings;

			// Token: 0x04003C77 RID: 15479
			public CombiningInformation.TextureArrayUserSettings occlusionArraySettings;

			// Token: 0x04003C78 RID: 15480
			public CombiningInformation.TextureArrayUserSettings emissiveArraySettings;

			// Token: 0x04003C79 RID: 15481
			public CombiningInformation.TextureArrayUserSettings detailMaskArraySettings;

			// Token: 0x04003C7A RID: 15482
			public CombiningInformation.TextureArrayUserSettings detailAlbedoArraySettings;

			// Token: 0x04003C7B RID: 15483
			public CombiningInformation.TextureArrayUserSettings detailNormalArraySettings;
		}

		// Token: 0x02000BFB RID: 3067
		[Serializable]
		public class MaterialProperties
		{
			// Token: 0x06005A77 RID: 23159 RVA: 0x001F20F8 File Offset: 0x001F02F8
			public bool IsSameAs(CombiningInformation.MaterialProperties toCompare)
			{
				return this.originalMaterial == toCompare.originalMaterial || (!(toCompare.albedoTint != this.albedoTint) && toCompare.normalIntensity == this.normalIntensity && toCompare.occlusionIntensity == this.occlusionIntensity && toCompare.smoothnessIntensity == this.smoothnessIntensity && toCompare.glossMapScale == this.glossMapScale && !(toCompare.uvTileOffset != this.uvTileOffset) && toCompare.metalIntensity == this.metalIntensity && !(toCompare.emissionColor != this.emissionColor) && !(toCompare.detailUVTileOffset != this.detailUVTileOffset) && toCompare.alphaCutoff == this.alphaCutoff && !(toCompare.specularColor != this.specularColor) && toCompare.detailNormalScale == this.detailNormalScale && toCompare.heightIntensity == this.heightIntensity && toCompare.uvSec == this.uvSec && toCompare.alphaMode == this.alphaMode);
			}

			// Token: 0x06005A78 RID: 23160 RVA: 0x001F2224 File Offset: 0x001F0424
			public static Texture2D NewTexture()
			{
				Texture2D texture2D = new Texture2D(8, 4, TextureFormat.RGBAHalf, false, true);
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						texture2D.SetPixel(i, j, Color.black);
					}
				}
				texture2D.Apply();
				return texture2D;
			}

			// Token: 0x06005A79 RID: 23161 RVA: 0x001F226C File Offset: 0x001F046C
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
				if (index >= burnOn.height)
				{
					Texture2D texture2D = new Texture2D(burnOn.width, index + 1, TextureFormat.RGBAHalf, false, true);
					Color[] pixels = burnOn.GetPixels();
					texture2D.SetPixels(0, 0, burnOn.width, burnOn.height, pixels);
					burnOn = texture2D;
				}
				if (burnOn.width < 8)
				{
					Texture2D texture2D2 = new Texture2D(8, burnOn.height, TextureFormat.RGBAHalf, false, true);
					Color[] pixels2 = burnOn.GetPixels();
					texture2D2.SetPixels(0, 0, burnOn.width, burnOn.height, pixels2);
					burnOn = texture2D2;
				}
				burnOn.SetPixel(0, index, new Color(this.uvTileOffset.x - 1f, this.uvTileOffset.y - 1f, this.uvTileOffset.z, this.uvTileOffset.w));
				burnOn.SetPixel(1, index, new Color(this.normalIntensity, this.occlusionIntensity, this.smoothnessIntensity, this.metalIntensity));
				burnOn.SetPixel(2, index, this.albedoTint);
				burnOn.SetPixel(3, index, this.emissionColor);
				burnOn.SetPixel(4, index, new Color(this.specularColor.r, this.specularColor.g, this.specularColor.b, this.glossMapScale));
				burnOn.SetPixel(5, index, new Color(this.detailUVTileOffset.x, this.detailUVTileOffset.y, this.detailUVTileOffset.z, this.detailUVTileOffset.w));
				burnOn.SetPixel(6, index, new Color(this.alphaCutoff, this.detailNormalScale, this.heightIntensity, this.uvSec));
				burnOn.SetPixel(7, index, new Color((float)textureArrayIndex, (float)textureArrayIndex, (float)textureArrayIndex, (float)textureArrayIndex));
				burnOn.Apply();
			}

			// Token: 0x06005A7A RID: 23162 RVA: 0x001F2434 File Offset: 0x001F0634
			public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
			{
				this.materialName = material.name;
				this.originalMaterial = material;
				this.normalIntensity = 1f;
				this.occlusionIntensity = 1f;
				this.smoothnessIntensity = 1f;
				this.albedoTint = Color.white;
				this.metalIntensity = 1f;
				this.uvTileOffset = new Vector4(1f, 1f, 0f, 0f);
				this.detailUVTileOffset = new Vector4(1f, 1f, 0f, 0f);
				this.emissionColor = Color.black;
				this.alphaCutoff = 0.5f;
				this.specularColor = Color.black;
				this.detailNormalScale = 1f;
				this.heightIntensity = 0.05f;
				this.alphaMode = 0;
				this.glossMapScale = 0f;
				if (material.shader.name.ToLower() == "standard (specular setup)")
				{
					this.specularWorkflow = true;
				}
				if (material.HasProperty("_Color"))
				{
					this.albedoTint = material.GetColor("_Color");
				}
				if (material.HasProperty("_MainTex") && material.HasProperty("_MainTex_ST"))
				{
					this.uvTileOffset = material.GetVector("_MainTex_ST");
				}
				if (material.HasProperty("_GlossMapScale"))
				{
					this.glossMapScale = material.GetFloat("_GlossMapScale");
				}
				if (material.HasProperty("_Glossiness"))
				{
					this.smoothnessIntensity = material.GetFloat("_Glossiness");
				}
				if (material.HasProperty("_Smoothness"))
				{
					this.smoothnessIntensity = material.GetFloat("_Smoothness");
				}
				if (material.HasProperty("_MetallicGlossMap") && material.GetTexture("_MetallicGlossMap") != null)
				{
					this.smoothnessIntensity = this.glossMapScale;
				}
				if (material.HasProperty("_SpecColor"))
				{
					this.specularColor = material.GetColor("_SpecColor");
				}
				if (material.HasProperty("_Metallic"))
				{
					this.metalIntensity = material.GetFloat("_Metallic");
				}
				if (material.HasProperty("_OcclusionStrength"))
				{
					this.occlusionIntensity = material.GetFloat("_OcclusionStrength") + 1f;
				}
				if (material.HasProperty("_BumpScale"))
				{
					this.normalIntensity = material.GetFloat("_BumpScale");
				}
				if (material.HasProperty("_DetailNormalMapScale"))
				{
					this.detailNormalScale = material.GetFloat("_DetailNormalMapScale");
				}
				if (material.HasProperty("_EmissionColor") && material.HasProperty("_EmissionMap") && combineInfo.ShouldGenerateEmissionArray())
				{
					this.emissionColor = Color.black;
				}
				else if (material.HasProperty("_EmissionColor"))
				{
					this.emissionColor = material.GetColor("_EmissionColor");
				}
				if (material.HasProperty("_Parallax"))
				{
					this.heightIntensity = material.GetFloat("_Parallax");
				}
				if (material.HasProperty("_UVSec"))
				{
					this.uvSec = material.GetFloat("_UVSec");
				}
				if (material.HasProperty("_DetailAlbedoMap") && material.HasProperty("_DetailAlbedoMap_ST"))
				{
					this.detailUVTileOffset = material.GetVector("_DetailAlbedoMap_ST");
				}
				if (material.HasProperty("_Mode"))
				{
					this.alphaMode = (int)material.GetFloat("_Mode");
				}
			}

			// Token: 0x04003C7C RID: 15484
			public bool foldOut = true;

			// Token: 0x04003C7D RID: 15485
			public int texArrIndex;

			// Token: 0x04003C7E RID: 15486
			public int matIndex;

			// Token: 0x04003C7F RID: 15487
			public string materialName;

			// Token: 0x04003C80 RID: 15488
			public Material originalMaterial;

			// Token: 0x04003C81 RID: 15489
			public Color albedoTint;

			// Token: 0x04003C82 RID: 15490
			public Vector4 uvTileOffset = new Vector4(1f, 1f, 0f, 0f);

			// Token: 0x04003C83 RID: 15491
			public float normalIntensity = 1f;

			// Token: 0x04003C84 RID: 15492
			public float occlusionIntensity = 1f;

			// Token: 0x04003C85 RID: 15493
			public float smoothnessIntensity = 1f;

			// Token: 0x04003C86 RID: 15494
			public float glossMapScale = 1f;

			// Token: 0x04003C87 RID: 15495
			public float metalIntensity = 1f;

			// Token: 0x04003C88 RID: 15496
			public Color emissionColor = Color.black;

			// Token: 0x04003C89 RID: 15497
			public Vector4 detailUVTileOffset = new Vector4(1f, 1f, 0f, 0f);

			// Token: 0x04003C8A RID: 15498
			public float alphaCutoff = 0.5f;

			// Token: 0x04003C8B RID: 15499
			public Color specularColor = Color.black;

			// Token: 0x04003C8C RID: 15500
			public float detailNormalScale = 1f;

			// Token: 0x04003C8D RID: 15501
			public float heightIntensity = 0.05f;

			// Token: 0x04003C8E RID: 15502
			public float uvSec;

			// Token: 0x04003C8F RID: 15503
			public int alphaMode;

			// Token: 0x04003C90 RID: 15504
			public bool specularWorkflow;
		}

		// Token: 0x02000BFC RID: 3068
		[Serializable]
		public class MeshData
		{
			// Token: 0x04003C91 RID: 15505
			public List<MeshFilter> meshFilters;

			// Token: 0x04003C92 RID: 15506
			public List<MeshRenderer> meshRenderers;

			// Token: 0x04003C93 RID: 15507
			public List<SkinnedMeshRenderer> skinnedMeshRenderers;

			// Token: 0x04003C94 RID: 15508
			public Material[] originalMaterials;

			// Token: 0x04003C95 RID: 15509
			public Mesh[] outputMeshes;

			// Token: 0x04003C96 RID: 15510
			public Matrix4x4[] outputMatrices;
		}

		// Token: 0x02000BFD RID: 3069
		[Serializable]
		public class CombineMetaData
		{
			// Token: 0x04003C97 RID: 15511
			public Material material;

			// Token: 0x04003C98 RID: 15512
			public CombiningInformation.MaterialProperties materialProperties;

			// Token: 0x04003C99 RID: 15513
			public CombiningInformation.MaterialProperties tempMaterialProperties;

			// Token: 0x04003C9A RID: 15514
			public List<CombiningInformation.MeshData> meshesData = new List<CombiningInformation.MeshData>();
		}

		// Token: 0x02000BFE RID: 3070
		[Serializable]
		public class MaterialEntity
		{
			// Token: 0x06005A7E RID: 23166 RVA: 0x001F2858 File Offset: 0x001F0A58
			public bool HasAnyTextures()
			{
				return this.diffuseMap != null || this.heightMap != null || this.normalMap != null || this.metallicMap != null || this.detailAlbedoMap != null || this.detailNormalMap != null || this.detailMaskMap != null || this.emissionMap != null || this.specularMap != null || this.occlusionMap != null;
			}

			// Token: 0x04003C9B RID: 15515
			public List<CombiningInformation.CombineMetaData> combinedMats = new List<CombiningInformation.CombineMetaData>();

			// Token: 0x04003C9C RID: 15516
			public int textArrIndex;

			// Token: 0x04003C9D RID: 15517
			public Texture2D diffuseMap;

			// Token: 0x04003C9E RID: 15518
			public Texture2D metallicMap;

			// Token: 0x04003C9F RID: 15519
			public Texture2D specularMap;

			// Token: 0x04003CA0 RID: 15520
			public Texture2D normalMap;

			// Token: 0x04003CA1 RID: 15521
			public Texture2D heightMap;

			// Token: 0x04003CA2 RID: 15522
			public Texture2D occlusionMap;

			// Token: 0x04003CA3 RID: 15523
			public Texture2D emissionMap;

			// Token: 0x04003CA4 RID: 15524
			public Texture2D detailMaskMap;

			// Token: 0x04003CA5 RID: 15525
			public Texture2D detailAlbedoMap;

			// Token: 0x04003CA6 RID: 15526
			public Texture2D detailNormalMap;
		}
	}
}
