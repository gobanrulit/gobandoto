using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x0200090A RID: 2314
	public class FamilyTreeDisplay : MonoBehaviourSingleton<FamilyTreeDisplay>
	{
		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x001B2C57 File Offset: 0x001B0E57
		public static CharacterTooltip Tooltip
		{
			get
			{
				return MonoBehaviourSingleton<FamilyTreeDisplay>.Instance.tooltip;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x001B2C63 File Offset: 0x001B0E63
		public static Character FocalPoint
		{
			get
			{
				return MonoBehaviourSingleton<FamilyTreeDisplay>.Instance.focalPoint;
			}
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x001B2C6F File Offset: 0x001B0E6F
		public static void Display(Character newFocalPoint)
		{
			MonoBehaviourSingleton<FamilyTreeDisplay>.Instance.Init(newFocalPoint);
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x001B2C7C File Offset: 0x001B0E7C
		public void Init(Character newFocalPoint)
		{
			this.root.SetActive(true);
			foreach (GameObject gameObject in this.lines)
			{
				gameObject.AddComponent<FadeOut>();
			}
			this.lines.Clear();
			this.oldCharacters = this.characters;
			this.characters = new Dictionary<string, GameObject>();
			this.root.SetActive(true);
			if (this.focalPoint != null && this.oldCharacters != null && this.oldCharacters.ContainsKey(this.focalPoint.CharacterId))
			{
				this.oldCharacters[this.focalPoint.CharacterId].GetComponent<FamilyTreeNode>().SetFocalPoint(false);
			}
			this.focalPoint = newFocalPoint;
			if (newFocalPoint.HasChildren)
			{
				this.CreateChildren(newFocalPoint, new Vector2(0f, this.generationGap), new Vector2(0f, this.generationGap));
			}
			if (newFocalPoint.KnownParents)
			{
				this.CreateChildren(newFocalPoint.Mother, Vector2.zero, new Vector2(0f, -this.generationGap));
				Vector2 position = new Vector2(0f, -this.generationGap);
				this.Create(newFocalPoint.Mother, position);
			}
			else
			{
				this.Create(newFocalPoint, Vector2.zero);
			}
			if (this.oldCharacters != null)
			{
				foreach (KeyValuePair<string, GameObject> keyValuePair in this.oldCharacters)
				{
					keyValuePair.Value.AddComponent<FadeOut>();
				}
				this.oldCharacters = null;
			}
			this.tooltip.transform.SetAsLastSibling();
			foreach (GameObject gameObject2 in this.lines)
			{
				gameObject2.transform.SetSiblingIndex(0);
			}
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x001B2E8C File Offset: 0x001B108C
		private void CreateChildren(Character character, Vector2 childPosition, Vector2 linePosition)
		{
			Vector2 vector = linePosition / 2f;
			this.CreateLine(vector, vector - new Vector2(0f, this.generationGap / 2f), ((character != null) ? character.ToString() : null) + " child line down", this.childLineColour);
			this.Create(character.Children, childPosition, ((character != null) ? character.ToString() : null) + " child ");
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x001B2F0C File Offset: 0x001B110C
		private void Create(IReadOnlyList<Character> characters, Vector2 position, string namePrefix)
		{
			Vector2 a = position;
			Vector2 a2 = position;
			foreach (Character character in characters)
			{
				if (character == this.focalPoint)
				{
					this.CreateChild(character, ref position);
					break;
				}
			}
			foreach (Character character2 in characters)
			{
				if (character2 != this.focalPoint)
				{
					a2 = position;
					this.CreateChild(character2, ref position);
				}
			}
			this.CreateLine(a - new Vector2(0f, this.generationGap / 2f), a2 - new Vector2(0f, this.generationGap / 2f), namePrefix + "line across", this.childLineColour);
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x001B2FFC File Offset: 0x001B11FC
		private void CreateChild(Character child, ref Vector2 position)
		{
			this.CreateLine(position, position - new Vector2(0f, this.generationGap / 2f), ((child != null) ? child.ToString() : null) + " line up", this.childLineColour);
			if (child.IsMarried)
			{
				position.x += this.size.x / 2f + this.marriedGap;
			}
			this.Create(child, position);
			position.x += this.siblingGap + this.size.x;
			if (child.IsMarried)
			{
				position.x += this.marriedGap + this.size.x / 2f;
			}
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x001B30D4 File Offset: 0x001B12D4
		private FamilyTreeNode Create(Character character, Vector2 position)
		{
			FamilyTreeNode familyTreeNode;
			if (character.IsMarried)
			{
				Vector2 b = new Vector2(this.marriedGap + this.size.x / 2f, 0f);
				Vector2 vector = position - b;
				Vector2 vector2 = position + b;
				if (character.IsMale || character == this.focalPoint)
				{
					familyTreeNode = this.Draw(character, vector);
					if (character == this.focalPoint)
					{
						familyTreeNode.SetFocalPoint(true);
					}
					this.Draw(character.Spouse, vector2).name = character.Spouse.Name;
				}
				else
				{
					familyTreeNode = this.Draw(character, position + b);
					this.Draw(character.Spouse, vector).name = character.Spouse.Name;
				}
				this.CreateLine(vector, vector2, character.Name + "+" + character.Spouse.Name + " marriage", this.marriedLineColour);
			}
			else
			{
				familyTreeNode = this.Draw(character, position);
			}
			familyTreeNode.name = character.Name;
			return familyTreeNode;
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001B31DC File Offset: 0x001B13DC
		private void CreateLine(Vector2 start, Vector2 end, string name, Color colour)
		{
			GameObject gameObject = Object.Instantiate<GameObject>(this.linePrefab);
			gameObject.name = name;
			this.lines.Add(gameObject);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.SetParent(base.GetComponent<RectTransform>());
			if (start.x > end.x)
			{
				float x = start.x;
				start.x = end.x;
				end.x = x;
			}
			if (start.y > end.y)
			{
				float y = start.y;
				start.y = end.y;
				end.y = y;
			}
			component.anchoredPosition = start;
			Vector2 vector = end - start;
			if (vector.x == 0f)
			{
				vector.x = 1f;
			}
			if (vector.y == 0f)
			{
				vector.y = 1f;
			}
			component.sizeDelta = vector;
			gameObject.GetComponent<Graphic>().color = colour;
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x001B32C4 File Offset: 0x001B14C4
		private FamilyTreeNode Draw(Character character, Vector2 position)
		{
			GameObject gameObject;
			if (this.oldCharacters != null && this.oldCharacters.TryGetValue(character.CharacterId, out gameObject))
			{
				this.oldCharacters.Remove(character.CharacterId);
				gameObject.AddComponent<Tween>().Init(position);
				this.characters[character.CharacterId] = gameObject;
				FamilyTreeNode component = gameObject.GetComponent<FamilyTreeNode>();
				component.Init(character);
				return component;
			}
			gameObject = Object.Instantiate<GameObject>(this.nodePrefab);
			if (this.oldCharacters != null)
			{
				gameObject.AddComponent<FadeIn>();
			}
			if (this.characters.ContainsKey(character.CharacterId))
			{
				Debug.LogError("This shouldn't happen: " + ((character != null) ? character.ToString() : null));
			}
			this.characters[character.CharacterId] = gameObject;
			FamilyTreeNode component2 = gameObject.GetComponent<FamilyTreeNode>();
			component2.Init(character);
			RectTransform component3 = gameObject.GetComponent<RectTransform>();
			component3.SetParent(base.GetComponent<RectTransform>());
			component3.anchoredPosition = position;
			return component2;
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x001B33AD File Offset: 0x001B15AD
		public static void MakeHeir(Character heir)
		{
			MonoBehaviourSingleton<FamilyTreeDisplay>.Instance.MakeHeirPrivate(heir);
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x001B33BA File Offset: 0x001B15BA
		private void MakeHeirPrivate(Character heir)
		{
			External.PlayerCharacter.AssignHeir(heir);
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x001B33C8 File Offset: 0x001B15C8
		public void Hide()
		{
			base.gameObject.SetActive(false);
			foreach (KeyValuePair<string, GameObject> keyValuePair in this.characters)
			{
				Object.Destroy(keyValuePair.Value);
			}
			this.characters.Clear();
			this.focalPoint = null;
		}

		// Token: 0x04003022 RID: 12322
		[SerializeField]
		private GameObject nodePrefab;

		// Token: 0x04003023 RID: 12323
		[SerializeField]
		private GameObject linePrefab;

		// Token: 0x04003024 RID: 12324
		[SerializeField]
		private Color marriedLineColour;

		// Token: 0x04003025 RID: 12325
		[SerializeField]
		private Color childLineColour;

		// Token: 0x04003026 RID: 12326
		[SerializeField]
		private CharacterTooltip tooltip;

		// Token: 0x04003027 RID: 12327
		private Dictionary<string, GameObject> characters;

		// Token: 0x04003028 RID: 12328
		private List<GameObject> lines = new List<GameObject>();

		// Token: 0x04003029 RID: 12329
		private Dictionary<string, GameObject> oldCharacters;

		// Token: 0x0400302A RID: 12330
		private Character focalPoint;

		// Token: 0x0400302B RID: 12331
		[SerializeField]
		private Vector2 size = new Vector2(160f, 163f);

		// Token: 0x0400302C RID: 12332
		[SerializeField]
		private float marriedGap = 10f;

		// Token: 0x0400302D RID: 12333
		[SerializeField]
		private float generationGap = 100f;

		// Token: 0x0400302E RID: 12334
		[SerializeField]
		private float siblingGap = 30f;
	}
}
