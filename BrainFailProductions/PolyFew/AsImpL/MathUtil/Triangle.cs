using System;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x02000370 RID: 880
	public class Triangle
	{
		// Token: 0x0600128A RID: 4746 RVA: 0x000766A1 File Offset: 0x000748A1
		public Triangle(Vertex v1, Vertex v2, Vertex v3)
		{
			this.v1 = v1;
			this.v2 = v2;
			this.v3 = v3;
		}

		// Token: 0x0400147F RID: 5247
		public Vertex v1;

		// Token: 0x04001480 RID: 5248
		public Vertex v2;

		// Token: 0x04001481 RID: 5249
		public Vertex v3;
	}
}
