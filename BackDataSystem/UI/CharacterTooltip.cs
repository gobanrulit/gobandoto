using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BackDataSystem.UI
{
	// Token: 0x02000908 RID: 2312
	public class CharacterTooltip : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06005017 RID: 20503 RVA: 0x001B299E File Offset: 0x001B0B9E
		private void Start()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x001B29AC File Offset: 0x001B0BAC
		private void Update()
		{
			if (this.hide)
			{
				base.gameObject.SetActive(false);
				this.hide = false;
			}
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x001B29CC File Offset: 0x001B0BCC
		public void Enter(Character character, RectTransform node)
		{
			this.hide = false;
			if (this.character != character)
			{
				this.character = character;
				this.displayText.text = character.Name + "\n";
				TMP_Text tmp_Text = this.displayText;
				tmp_Text.text = string.Concat(new string[]
				{
					tmp_Text.text,
					character.IsMale ? "Male" : "Female",
					" ",
					character.AgeBracket.ToString(),
					"\n"
				});
				if (!character.IsAlive)
				{
					TMP_Text tmp_Text2 = this.displayText;
					tmp_Text2.text += "Dead\n";
				}
				if (character.KnownParents && (character.Father == External.PlayerCharacter || character.Mother == External.PlayerCharacter))
				{
					this.heirSelectionButton.SetActive(true);
				}
				else
				{
					this.heirSelectionButton.SetActive(false);
				}
				TMP_Text tmp_Text3 = this.displayText;
				tmp_Text3.text = tmp_Text3.text + "Physical: " + character.Physical.ToString() + "\n";
				TMP_Text tmp_Text4 = this.displayText;
				tmp_Text4.text = tmp_Text4.text + "Intelligence: " + character.Physical.ToString() + "\n";
				TMP_Text tmp_Text5 = this.displayText;
				tmp_Text5.text = tmp_Text5.text + "Leadership: " + character.Physical.ToString() + "\n";
				TMP_Text tmp_Text6 = this.displayText;
				tmp_Text6.text = tmp_Text6.text + "Charisma: " + character.Physical.ToString() + "\n";
				TMP_Text tmp_Text7 = this.displayText;
				tmp_Text7.text = tmp_Text7.text + "Potential: " + character.Physical.ToString() + "\n";
			}
			base.gameObject.SetActive(true);
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchoredPosition = node.anchoredPosition + new Vector2(component.sizeDelta.x + node.sizeDelta.x, -component.sizeDelta.y + node.sizeDelta.y) / 2f;
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x001B2C14 File Offset: 0x001B0E14
		public void Exit(Character character)
		{
			this.character = character;
			this.hide = true;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x001B2C24 File Offset: 0x001B0E24
		public void OnPointerEnter(PointerEventData eventData)
		{
			this.hide = false;
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x001B2C2D File Offset: 0x001B0E2D
		public void OnPointerExit(PointerEventData eventData)
		{
			this.hide = true;
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x001B2C36 File Offset: 0x001B0E36
		public void MakeHeirButton()
		{
			FamilyTreeDisplay.MakeHeir(this.character);
		}

		// Token: 0x0400301E RID: 12318
		[SerializeField]
		private TMP_Text displayText;

		// Token: 0x0400301F RID: 12319
		[SerializeField]
		private GameObject heirSelectionButton;

		// Token: 0x04003020 RID: 12320
		private Character character;

		// Token: 0x04003021 RID: 12321
		private bool hide;
	}
}
