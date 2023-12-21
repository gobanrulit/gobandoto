using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x0200035A RID: 858
	[ExecuteInEditMode]
	public class RefreshEnforcer : MonoBehaviour
	{
		// Token: 0x060011BE RID: 4542 RVA: 0x000700BB File Offset: 0x0006E2BB
		private void Start()
		{
			Object.DestroyImmediate(this);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000700C3 File Offset: 0x0006E2C3
		private void Update()
		{
		}
	}
}
