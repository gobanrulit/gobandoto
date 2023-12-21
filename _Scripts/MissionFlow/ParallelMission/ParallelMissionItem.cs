using System;
using System.Collections.Generic;
using Game.Core;
using Item;
using Sirenix.OdinInspector;
using TMPro;
using TOOLS;
using UnityEngine;
using ZFramework;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x02000317 RID: 791
	public class ParallelMissionItem : MonoBehaviour
	{
		// Token: 0x06001038 RID: 4152 RVA: 0x0006912D File Offset: 0x0006732D
		private void Awake()
		{
			this.rewardItemPrefab.SetActive(false);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0006913C File Offset: 0x0006733C
		public void InitUIs(SubParallelMission subParallelMission)
		{
			this.Data = subParallelMission;
			this.titleText.text = subParallelMission.Title;
			this.contentText.text = subParallelMission.TaskContents;
			foreach (ItemGroup itemGroup in subParallelMission.Reward)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.rewardItemPrefab, this.rewardItemParent, false);
				gameObject.SetActive(true);
				UIItem uiitem = gameObject.GetComponent<UIItem>();
				uiitem.valueTxt.text = itemGroup.Num.ToString();
				SingletonMono<Game.Core.ResMgr>.GetInstance().GetItemIconSprite(this._loader, itemGroup.item._id, delegate(Sprite r)
				{
					uiitem.itemImg.sprite = r;
				}, false);
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00069220 File Offset: 0x00067420
		public void SetProgressUIs(int current, int target)
		{
			this.progressText.text = string.Format("{0}/{1}", current, target);
		}

		// Token: 0x04001235 RID: 4661
		private ResLoader _loader = ResLoader.Allocate();

		// Token: 0x04001236 RID: 4662
		[ReadOnly]
		public SubParallelMission Data;

		// Token: 0x04001237 RID: 4663
		public Transform rewardItemParent;

		// Token: 0x04001238 RID: 4664
		public GameObject rewardItemPrefab;

		// Token: 0x04001239 RID: 4665
		public TMP_Text titleText;

		// Token: 0x0400123A RID: 4666
		public TMP_Text contentText;

		// Token: 0x0400123B RID: 4667
		public TMP_Text progressText;

		// Token: 0x0400123C RID: 4668
		[ReadOnly]
		public List<UIItem> rewardsItemUIs = new List<UIItem>();
	}
}
