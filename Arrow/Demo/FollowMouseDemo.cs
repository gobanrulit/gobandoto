using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Arrow.Demo
{
	// Token: 0x020003AD RID: 941
	public class FollowMouseDemo : MonoBehaviour
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x0008BA98 File Offset: 0x00089C98
		private void Awake()
		{
			this.mainCamera = Camera.main;
			this.SetCurrentArrow(this.arrows[0]);
			int num = 0;
			while (num < this.toggles.Length && num < this.arrows.Length)
			{
				FollowMouseDemo.<>c__DisplayClass5_0 CS$<>8__locals1 = new FollowMouseDemo.<>c__DisplayClass5_0();
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.arrow = this.arrows[num];
				this.toggles[num].onValueChanged.AddListener(new UnityAction<bool>(CS$<>8__locals1.<Awake>g__OnToggleValueChanged|0));
				num++;
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0008BB18 File Offset: 0x00089D18
		private void Update()
		{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = this.distanceFromScreen;
			Vector3 endPosition = this.mainCamera.ScreenToWorldPoint(mousePosition);
			this.currentArrow.SetPositions(base.transform.position, endPosition);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0008BB5C File Offset: 0x00089D5C
		private void SetCurrentArrow(ArrowRenderer arrow)
		{
			this.currentArrow = arrow;
			foreach (ArrowRenderer arrowRenderer in this.arrows)
			{
				arrowRenderer.gameObject.SetActive(arrowRenderer == this.currentArrow);
			}
		}

		// Token: 0x040016DE RID: 5854
		[SerializeField]
		private float distanceFromScreen = 5f;

		// Token: 0x040016DF RID: 5855
		[SerializeField]
		private Toggle[] toggles;

		// Token: 0x040016E0 RID: 5856
		[SerializeField]
		private ArrowRenderer[] arrows;

		// Token: 0x040016E1 RID: 5857
		private Camera mainCamera;

		// Token: 0x040016E2 RID: 5858
		private ArrowRenderer currentArrow;
	}
}
