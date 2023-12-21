using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Arrow
{
	// Token: 0x020003AA RID: 938
	public class AnimatedArrowRenderer : ArrowRenderer
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0008B12F File Offset: 0x0008932F
		protected override float Offset
		{
			get
			{
				return Time.time * this.speed;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0008B13D File Offset: 0x0008933D
		protected override float FadeDistance
		{
			get
			{
				return this.fadeDistance;
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0008B145 File Offset: 0x00089345
		protected override void Update()
		{
			base.Update();
			this.UpdateSegments();
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0008B154 File Offset: 0x00089354
		private void UpdateSegments()
		{
			Debug.DrawLine(this.start, this.end, Color.yellow);
			this.CheckSegments(this.Positions.Count - 1);
			for (int i = 0; i < this.Positions.Count - 1; i++)
			{
				this.segments[i].localPosition = this.Positions[i];
				this.segments[i].localRotation = this.Rotations[i];
				MeshRenderer meshRenderer = this.renderers[i];
				if (meshRenderer)
				{
					Material material = meshRenderer.material;
					Color color = material.color;
					color.a = this.Alphas[i];
					material.color = color;
				}
			}
			if (!this.arrow)
			{
				this.arrow = Object.Instantiate<GameObject>(this.tipPrefab, base.transform).transform;
			}
			this.arrow.localPosition = this.Positions.Last<Vector3>();
			this.arrow.localRotation = this.Rotations.Last<Quaternion>();
			base.transform.position = this.start;
			base.transform.rotation = Quaternion.LookRotation(this.end - this.start, this.upwards);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0008B2A8 File Offset: 0x000894A8
		private void CheckSegments(int segmentsCount)
		{
			while (this.segments.Count < segmentsCount)
			{
				Transform transform = Object.Instantiate<GameObject>(this.segmentPrefab, base.transform).transform;
				this.segments.Add(transform);
				this.renderers.Add(transform.GetComponent<MeshRenderer>());
			}
			for (int i = 0; i < this.segments.Count; i++)
			{
				GameObject gameObject = this.segments[i].gameObject;
				if (gameObject.activeSelf != i < segmentsCount)
				{
					gameObject.SetActive(i < segmentsCount);
				}
			}
		}

		// Token: 0x040016C5 RID: 5829
		[Space]
		[SerializeField]
		private float fadeDistance = 0.35f;

		// Token: 0x040016C6 RID: 5830
		[SerializeField]
		private float speed = 1f;

		// Token: 0x040016C7 RID: 5831
		[SerializeField]
		private GameObject tipPrefab;

		// Token: 0x040016C8 RID: 5832
		[SerializeField]
		private GameObject segmentPrefab;

		// Token: 0x040016C9 RID: 5833
		private Transform arrow;

		// Token: 0x040016CA RID: 5834
		private readonly List<Transform> segments = new List<Transform>();

		// Token: 0x040016CB RID: 5835
		private readonly List<MeshRenderer> renderers = new List<MeshRenderer>();
	}
}
