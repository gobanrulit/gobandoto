using System;
using UnityEngine;

namespace BackDataSystem.UI
{
	// Token: 0x02000913 RID: 2323
	public class Tween : MonoBehaviour
	{
		// Token: 0x0600505F RID: 20575 RVA: 0x001B3DF8 File Offset: 0x001B1FF8
		public void Init(Vector2 targetPosition)
		{
			this.targetPosition = targetPosition;
			this.startPosition = base.GetComponent<RectTransform>().anchoredPosition;
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x001B3E14 File Offset: 0x001B2014
		private void Update()
		{
			Vector2 anchoredPosition = base.GetComponent<RectTransform>().anchoredPosition;
			Vector2.Distance(this.targetPosition, anchoredPosition);
			this.timer += Time.deltaTime;
			if (this.timer >= 0.3f)
			{
				base.GetComponent<RectTransform>().anchoredPosition = this.targetPosition;
				Object.Destroy(this);
				return;
			}
			float d = Mathf.SmoothStep(0f, 1f, this.timer / 0.3f);
			base.GetComponent<RectTransform>().anchoredPosition = this.startPosition + (this.targetPosition - this.startPosition) * d;
		}

		// Token: 0x04003054 RID: 12372
		private const float time = 0.3f;

		// Token: 0x04003055 RID: 12373
		private Vector2 targetPosition;

		// Token: 0x04003056 RID: 12374
		private Vector2 startPosition;

		// Token: 0x04003057 RID: 12375
		private float timer;
	}
}
