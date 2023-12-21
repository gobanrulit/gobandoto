using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Arrow
{
	// Token: 0x020003AB RID: 939
	public abstract class ArrowRenderer : MonoBehaviour
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0008B36B File Offset: 0x0008956B
		protected virtual float Offset
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0008B372 File Offset: 0x00089572
		protected virtual float FadeDistance
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0008B379 File Offset: 0x00089579
		public virtual void SetPositions(Vector3 startPosition, Vector3 endPosition)
		{
			this.start = startPosition;
			this.end = endPosition;
			this.Update();
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0008B38F File Offset: 0x0008958F
		protected virtual void Update()
		{
			this.UpdateArrowData();
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0008B398 File Offset: 0x00089598
		private void UpdateArrowData()
		{
			float num = Vector3.Distance(this.start, this.end);
			ArrowRenderer.<>c__DisplayClass14_0 CS$<>8__locals1;
			CS$<>8__locals1.radius = this.height / 2f + num * num / (8f * this.height);
			float num2 = CS$<>8__locals1.radius - this.height;
			float num3 = 2f * Mathf.Acos(num2 / CS$<>8__locals1.radius);
			float num4 = num3 * CS$<>8__locals1.radius;
			float num5 = num3 * 57.29578f;
			float num6 = this.segmentLength / CS$<>8__locals1.radius * 57.29578f;
			Vector3 b = new Vector3(0f, -num2, num / 2f);
			Vector3 zero = Vector3.zero;
			Vector3 vector = new Vector3(0f, 0f, num);
			int num7 = (int)(num4 / this.segmentLength) + 1;
			float num8 = num6 * Mathf.Repeat(this.Offset, 1f);
			Vector3 a = Quaternion.Euler(num8, 0f, 0f) * (zero - b) + b;
			float distanceMax = ArrowRenderer.<UpdateArrowData>g__AngleToDistance|14_0(num6 / 2f, ref CS$<>8__locals1);
			this.Positions.Clear();
			this.Rotations.Clear();
			this.Alphas.Clear();
			for (int i = 0; i < num7; i++)
			{
				float num9 = num6 * (float)i;
				Vector3 vector2 = Quaternion.Euler(num9, 0f, 0f) * (a - b) + b;
				float distance = ArrowRenderer.<UpdateArrowData>g__AngleToDistance|14_0(num9 + num8, ref CS$<>8__locals1);
				float distance2 = ArrowRenderer.<UpdateArrowData>g__AngleToDistance|14_0(num5 - num9 - num8, ref CS$<>8__locals1) - this.FadeDistance;
				this.Positions.Add(vector2);
				this.Rotations.Add(Quaternion.FromToRotation(Vector3.up, vector2 - b));
				this.Alphas.Add(ArrowRenderer.<UpdateArrowData>g__GetAlpha|14_1(distance, distance2, distanceMax));
			}
			this.Positions.Add(vector);
			this.Rotations.Add(Quaternion.FromToRotation(Vector3.up, vector - b));
			this.Alphas.Add(ArrowRenderer.<UpdateArrowData>g__GetAlpha|14_1(num4, 0f, distanceMax));
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0008B615 File Offset: 0x00089815
		[CompilerGenerated]
		internal static float <UpdateArrowData>g__AngleToDistance|14_0(float angle0, ref ArrowRenderer.<>c__DisplayClass14_0 A_1)
		{
			return angle0 * A_1.radius / 57.29578f;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0008B625 File Offset: 0x00089825
		[CompilerGenerated]
		internal static float <UpdateArrowData>g__GetAlpha|14_1(float distance0, float distance1, float distanceMax)
		{
			return Mathf.Clamp01(Mathf.Clamp01(distance0 / distanceMax) + Mathf.Clamp01(distance1 / distanceMax) - 1f);
		}

		// Token: 0x040016CC RID: 5836
		[SerializeField]
		private float height = 0.5f;

		// Token: 0x040016CD RID: 5837
		[SerializeField]
		private float segmentLength = 0.5f;

		// Token: 0x040016CE RID: 5838
		[Space]
		[SerializeField]
		protected Vector3 start;

		// Token: 0x040016CF RID: 5839
		[SerializeField]
		protected Vector3 end;

		// Token: 0x040016D0 RID: 5840
		[SerializeField]
		protected Vector3 upwards = Vector3.up;

		// Token: 0x040016D1 RID: 5841
		protected readonly List<Vector3> Positions = new List<Vector3>();

		// Token: 0x040016D2 RID: 5842
		protected readonly List<Quaternion> Rotations = new List<Quaternion>();

		// Token: 0x040016D3 RID: 5843
		protected readonly List<float> Alphas = new List<float>();
	}
}
