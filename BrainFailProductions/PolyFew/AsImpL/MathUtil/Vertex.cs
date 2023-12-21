using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x02000371 RID: 881
	public class Vertex
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000766BE File Offset: 0x000748BE
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x000766C6 File Offset: 0x000748C6
		public Vector3 Position { get; private set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000766CF File Offset: 0x000748CF
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x000766D7 File Offset: 0x000748D7
		public int OriginalIndex { get; private set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000766E0 File Offset: 0x000748E0
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000766E8 File Offset: 0x000748E8
		public Vertex PreviousVertex
		{
			get
			{
				return this.prevVertex;
			}
			set
			{
				this.triangleHasChanged = (this.prevVertex != value);
				this.prevVertex = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00076703 File Offset: 0x00074903
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0007670B File Offset: 0x0007490B
		public Vertex NextVertex
		{
			get
			{
				return this.nextVertex;
			}
			set
			{
				this.triangleHasChanged = (this.nextVertex != value);
				this.nextVertex = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00076726 File Offset: 0x00074926
		public float TriangleArea
		{
			get
			{
				if (this.triangleHasChanged)
				{
					this.ComputeTriangleArea();
				}
				return this.triangleArea;
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0007673C File Offset: 0x0007493C
		public Vertex(int originalIndex, Vector3 position)
		{
			this.OriginalIndex = originalIndex;
			this.Position = position;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00076754 File Offset: 0x00074954
		public Vector2 GetPosOnPlane(Vector3 planeNormal)
		{
			Quaternion rotation = default(Quaternion);
			rotation.SetFromToRotation(planeNormal, Vector3.back);
			Vector3 vector = rotation * this.Position;
			return new Vector2(vector.x, vector.y);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00076794 File Offset: 0x00074994
		private void ComputeTriangleArea()
		{
			Vector3 lhs = this.PreviousVertex.Position - this.Position;
			Vector3 rhs = this.NextVertex.Position - this.Position;
			this.triangleArea = Vector3.Cross(lhs, rhs).magnitude / 2f;
		}

		// Token: 0x04001482 RID: 5250
		private Vertex prevVertex;

		// Token: 0x04001483 RID: 5251
		private Vertex nextVertex;

		// Token: 0x04001484 RID: 5252
		private float triangleArea;

		// Token: 0x04001485 RID: 5253
		private bool triangleHasChanged;
	}
}
