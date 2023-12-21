using System;
using System.Collections.Generic;
using BrainFailProductions.PolyFewRuntime;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x02000358 RID: 856
	[ExecuteInEditMode]
	public class ObjectMaterialLinks : MonoBehaviour
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0006FE7A File Offset: 0x0006E07A
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0006FE84 File Offset: 0x0006E084
		public List<CombiningInformation.MaterialEntity> linkedMaterialEntities
		{
			get
			{
				return this.linkedEntities;
			}
			set
			{
				this.linkedEntities = value;
				if (value == null)
				{
					return;
				}
				this.materialsProperties = new List<PolyfewRuntime.MaterialProperties>();
				for (int i = 0; i < value.Count; i++)
				{
					CombiningInformation.MaterialEntity materialEntity = value[i];
					if (materialEntity != null)
					{
						for (int j = 0; j < materialEntity.combinedMats.Count; j++)
						{
							CombiningInformation.MaterialProperties materialProperties = materialEntity.combinedMats[j].materialProperties;
							PolyfewRuntime.MaterialProperties item = new PolyfewRuntime.MaterialProperties(materialProperties.texArrIndex, materialProperties.matIndex, materialProperties.materialName, materialProperties.originalMaterial, materialProperties.albedoTint, materialProperties.uvTileOffset, materialProperties.normalIntensity, materialProperties.occlusionIntensity, materialProperties.smoothnessIntensity, materialProperties.glossMapScale, materialProperties.metalIntensity, materialProperties.emissionColor, materialProperties.detailUVTileOffset, materialProperties.alphaCutoff, materialProperties.specularColor, materialProperties.detailNormalScale, materialProperties.heightIntensity, materialProperties.uvSec);
							this.materialsProperties.Add(item);
						}
					}
				}
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0006FF7C File Offset: 0x0006E17C
		private void Start()
		{
			MeshRenderer component = base.GetComponent<MeshRenderer>();
			SkinnedMeshRenderer component2 = base.GetComponent<SkinnedMeshRenderer>();
			if (component != null)
			{
				Material[] sharedMaterials = component.sharedMaterials;
				if (sharedMaterials == null || sharedMaterials.Length == 0)
				{
					Object.DestroyImmediate(this);
					return;
				}
				bool flag = false;
				foreach (Material material in sharedMaterials)
				{
					if (!(material == null))
					{
						string a = material.shader.name.ToLower();
						if (a == "batchfewstandard" || a == "batchfewstandardspecular")
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					Object.DestroyImmediate(this);
					return;
				}
			}
			else if (component2 != null)
			{
				Material[] sharedMaterials = component2.sharedMaterials;
				if (sharedMaterials == null || sharedMaterials.Length == 0)
				{
					Object.DestroyImmediate(this);
					return;
				}
				bool flag2 = false;
				foreach (Material material2 in sharedMaterials)
				{
					if (!(material2 == null))
					{
						string a2 = material2.shader.name.ToLower();
						if (a2 == "batchfewstandard" || a2 == "batchfewstandardspecular")
						{
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					Object.DestroyImmediate(this);
					return;
				}
			}
			else
			{
				Object.DestroyImmediate(this);
			}
		}

		// Token: 0x040013F7 RID: 5111
		[SerializeField]
		private List<CombiningInformation.MaterialEntity> linkedEntities;

		// Token: 0x040013F8 RID: 5112
		public List<PolyfewRuntime.MaterialProperties> materialsProperties;

		// Token: 0x040013F9 RID: 5113
		public Texture2D linkedAttrImg;
	}
}
