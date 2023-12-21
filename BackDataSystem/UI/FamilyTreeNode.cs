using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x0200090B RID: 2315
	public class FamilyTreeNode : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06005030 RID: 20528 RVA: 0x001B3494 File Offset: 0x001B1694
		public void Init(Character character)
		{
			this.character = character;
			this.textDisplay.text = character.Name + "\nAge " + character.Age.ToString();
			base.GetComponent<Image>().color = Color.grey;
			this.focalPoint = (character == FamilyTreeDisplay.FocalPoint);
			if (this.focalPoint)
			{
				base.GetComponent<Image>().color = Color.red;
			}
			else
			{
				base.GetComponent<Image>().color = Color.grey;
			}
			this.deadDisplay.SetActive(!character.IsAlive);
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x001B352D File Offset: 0x001B172D
		public void Clicked()
		{
			if (this.focalPoint)
			{
				CharacterPanel.RunStatic(this.character);
				return;
			}
			FamilyTreeDisplay.Display(this.character);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x001B354E File Offset: 0x001B174E
		public void SetFocalPoint(bool focalPoint)
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x001B3550 File Offset: 0x001B1750
		public void OnPointerEnter(PointerEventData eventData)
		{
			FamilyTreeDisplay.Tooltip.Enter(this.character, base.GetComponent<RectTransform>());
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x001B3568 File Offset: 0x001B1768
		public void OnPointerExit(PointerEventData eventData)
		{
			FamilyTreeDisplay.Tooltip.Exit(this.character);
		}

		// Token: 0x0400302F RID: 12335
		[SerializeField]
		private TMP_Text textDisplay;

		// Token: 0x04003030 RID: 12336
		[SerializeField]
		private GameObject deadDisplay;

		// Token: 0x04003031 RID: 12337
		private Character character;

		// Token: 0x04003032 RID: 12338
		private bool focalPoint;
	}
}
