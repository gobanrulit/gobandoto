using System;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x02000372 RID: 882
	public static class MathUtility
	{
		// Token: 0x06001297 RID: 4759 RVA: 0x000767E8 File Offset: 0x000749E8
		public static int ClampListIndex(int index, int listSize)
		{
			index = (index % listSize + listSize) % listSize;
			return index;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000767F4 File Offset: 0x000749F4
		public static bool IsPointInTriangle(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p)
		{
			bool result = false;
			float num = (p2.y - p3.y) * (p1.x - p3.x) + (p3.x - p2.x) * (p1.y - p3.y);
			float num2 = ((p2.y - p3.y) * (p.x - p3.x) + (p3.x - p2.x) * (p.y - p3.y)) / num;
			float num3 = ((p3.y - p1.y) * (p.x - p3.x) + (p1.x - p3.x) * (p.y - p3.y)) / num;
			float num4 = 1f - num2 - num3;
			if (num2 > 0f && num2 < 1f && num3 > 0f && num3 < 1f && num4 > 0f && num4 < 1f)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000768F0 File Offset: 0x00074AF0
		public static bool IsTriangleOrientedClockwise(Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return v1.x * v2.y + v3.x * v1.y + v2.x * v3.y - v1.x * v3.y - v3.x * v2.y - v2.x * v1.y > 0f;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00076958 File Offset: 0x00074B58
		public static Vector3 ComputeNormal(Vector3 vert, Vector3 vNext, Vector3 vPrev)
		{
			Vector3 result = Vector3.Cross(vPrev - vert, vNext - vert);
			result.Normalize();
			return result;
		}
	}
}
