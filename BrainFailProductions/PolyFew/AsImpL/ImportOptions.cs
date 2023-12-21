﻿using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x02000364 RID: 868
	[Serializable]
	public class ImportOptions
	{
		// Token: 0x04001432 RID: 5170
		[Tooltip("load the OBJ file assuming its vertical axis is Z instead of Y")]
		public bool zUp = true;

		// Token: 0x04001433 RID: 5171
		[Tooltip("Consider diffuse map as already lit (disable lighting) if no other texture is present")]
		public bool litDiffuse;

		// Token: 0x04001434 RID: 5172
		[Tooltip("Consider to double-sided (duplicate and flip faces and normals")]
		public bool convertToDoubleSided;

		// Token: 0x04001435 RID: 5173
		[Tooltip("Rescaling for the model (1 = no rescaling)")]
		public float modelScaling = 1f;

		// Token: 0x04001436 RID: 5174
		[Tooltip("Reuse a model in memory if already loaded")]
		public bool reuseLoaded;

		// Token: 0x04001437 RID: 5175
		[Tooltip("Inherit parent layer")]
		public bool inheritLayer;

		// Token: 0x04001438 RID: 5176
		[Tooltip("Generate mesh colliders")]
		public bool buildColliders;

		// Token: 0x04001439 RID: 5177
		[Tooltip("Generate convex mesh colliders (only active if buildColliders = true)\nNote: it could not work for meshes with too many smooth surface regions.")]
		public bool colliderConvex;

		// Token: 0x0400143A RID: 5178
		[Tooltip("Mesh colliders as trigger (only active if colliderConvex = true)")]
		public bool colliderTrigger;

		// Token: 0x0400143B RID: 5179
		[Tooltip("Use 32 bit indices when needed, if available")]
		public bool use32bitIndices = true;

		// Token: 0x0400143C RID: 5180
		[Tooltip("Hide the loaded object during the loading process")]
		public bool hideWhileLoading;

		// Token: 0x0400143D RID: 5181
		[Header("Local Transform for the imported game object")]
		[Tooltip("Position of the object")]
		public Vector3 localPosition = Vector3.zero;

		// Token: 0x0400143E RID: 5182
		[Tooltip("Rotation of the object\n(Euler angles)")]
		public Vector3 localEulerAngles = Vector3.zero;

		// Token: 0x0400143F RID: 5183
		[Tooltip("Scaling of the object\n([1,1,1] = no rescaling)")]
		public Vector3 localScale = Vector3.one;
	}
}
