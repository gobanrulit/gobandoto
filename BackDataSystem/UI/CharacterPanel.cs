using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x02000907 RID: 2311
	public class CharacterPanel : MonoBehaviourSingleton<CharacterPanel>
	{
		// Token: 0x06005013 RID: 20499 RVA: 0x001B26DC File Offset: 0x001B08DC
		public static void RunStatic(Character character)
		{
			MonoBehaviourSingleton<CharacterPanel>.Instance.Run(character);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x001B26EC File Offset: 0x001B08EC
		public void Run(Character character)
		{
			if (this.root.activeSelf || character == null)
			{
				this.root.SetActive(false);
				return;
			}
			try
			{
				this.root.SetActive(true);
				this.name.text = character.Name + "Age: " + character.Age.ToString();
				this.physical.text = character.Physical.ToString() + "/20";
				this.intelligence.text = character.Intelligence.ToString() + "/20";
				this.leadership.text = character.Leadership.ToString() + "/20";
				this.charisma.text = character.Charisma.ToString() + "/20";
				this.potential.text = character.Potential.ToString() + "/20";
				int num = 0;
				int num2 = (int)(this.traitRoot.sizeDelta.x / this.traitPrefab.GetComponent<RectTransform>().sizeDelta.x);
				foreach (Trait trait in character.Traits)
				{
					RectTransform component = Object.Instantiate<GameObject>(this.traitPrefab).GetComponent<RectTransform>();
					component.SetParent(this.traitRoot);
					component.anchorMin = new Vector2(0f, 1f);
					component.anchorMax = new Vector2(0f, 1f);
					component.pivot = new Vector2(0f, 1f);
					component.anchoredPosition = new Vector2(component.sizeDelta.x * (float)(num % num2), -component.sizeDelta.y * (float)(num / num2));
					component.localScale = Vector3.one;
					int index = trait.index;
					if (index < 0 || index >= this.traitSprites.Length)
					{
						component.GetComponent<Image>().sprite = null;
					}
					else
					{
						component.GetComponent<Image>().sprite = this.traitSprites[index];
					}
					num++;
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("Failed to display character: " + ex.Message, base.gameObject);
			}
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x001B2988 File Offset: 0x001B0B88
		public void Hide()
		{
			this.root.SetActive(false);
		}

		// Token: 0x04003014 RID: 12308
		[SerializeField]
		private GameObject traitPrefab;

		// Token: 0x04003015 RID: 12309
		[SerializeField]
		private RectTransform traitRoot;

		// Token: 0x04003016 RID: 12310
		[SerializeField]
		private new Text name;

		// Token: 0x04003017 RID: 12311
		[SerializeField]
		private TMP_Text sex;

		// Token: 0x04003018 RID: 12312
		[SerializeField]
		private Text physical;

		// Token: 0x04003019 RID: 12313
		[SerializeField]
		private Text intelligence;

		// Token: 0x0400301A RID: 12314
		[SerializeField]
		private Text leadership;

		// Token: 0x0400301B RID: 12315
		[SerializeField]
		private Text charisma;

		// Token: 0x0400301C RID: 12316
		[SerializeField]
		private Text potential;

		// Token: 0x0400301D RID: 12317
		[SerializeField]
		private Sprite[] traitSprites;
	}
}
