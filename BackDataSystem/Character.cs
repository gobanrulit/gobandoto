using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace BackDataSystem
{
	// Token: 0x02000900 RID: 2304
	[LuaCallCSharp(GenFlag.No)]
	public class Character
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x001B1B6D File Offset: 0x001AFD6D
		// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x001B1B75 File Offset: 0x001AFD75
		public int AgeDays { get; private set; }

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x001B1B7E File Offset: 0x001AFD7E
		public int Age
		{
			get
			{
				return this.AgeDays / 365;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x001B1B8C File Offset: 0x001AFD8C
		public Character.eAgeBracket AgeBracket
		{
			get
			{
				if (this.Age <= 15)
				{
					return Character.eAgeBracket.Child;
				}
				if (this.Age <= 35)
				{
					return Character.eAgeBracket.Prime;
				}
				if (this.Age <= 50)
				{
					return Character.eAgeBracket.Mature;
				}
				return Character.eAgeBracket.Elder;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x001B1BB3 File Offset: 0x001AFDB3
		// (set) Token: 0x06004FCD RID: 20429 RVA: 0x001B1BBB File Offset: 0x001AFDBB
		public string CharacterId { get; private set; }

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x001B1BC4 File Offset: 0x001AFDC4
		// (set) Token: 0x06004FCF RID: 20431 RVA: 0x001B1BCC File Offset: 0x001AFDCC
		public string Name { get; private set; }

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x001B1BD5 File Offset: 0x001AFDD5
		// (set) Token: 0x06004FD1 RID: 20433 RVA: 0x001B1BDD File Offset: 0x001AFDDD
		public Character.eGender Gender { get; private set; }

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x001B1BE6 File Offset: 0x001AFDE6
		public bool IsMale
		{
			get
			{
				return this.Gender == Character.eGender.Male;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x001B1BF1 File Offset: 0x001AFDF1
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x001B1BF9 File Offset: 0x001AFDF9
		public Character Mother
		{
			get
			{
				return this.mother;
			}
			private set
			{
				if (this.Mother != null)
				{
					Debug.LogError("Mother already set");
				}
				this.mother = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x001B1C14 File Offset: 0x001AFE14
		public bool KnownParents
		{
			get
			{
				return this.Mother != null;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x001B1C1F File Offset: 0x001AFE1F
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x001B1C27 File Offset: 0x001AFE27
		public Character Father
		{
			get
			{
				return this.father;
			}
			private set
			{
				if (this.father != null)
				{
					Debug.LogError("Father already set");
				}
				this.father = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x001B1C42 File Offset: 0x001AFE42
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x001B1C4A File Offset: 0x001AFE4A
		public Character Spouse { get; private set; }

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x001B1C53 File Offset: 0x001AFE53
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x001B1C5B File Offset: 0x001AFE5B
		public bool IsAlive { get; private set; } = true;

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x001B1C64 File Offset: 0x001AFE64
		public bool IsMarried
		{
			get
			{
				return this.Spouse != null;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x001B1C6F File Offset: 0x001AFE6F
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x001B1C77 File Offset: 0x001AFE77
		public int Physical { get; private set; } = 1;

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x001B1C80 File Offset: 0x001AFE80
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x001B1C88 File Offset: 0x001AFE88
		public int Intelligence { get; private set; } = 1;

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x001B1C91 File Offset: 0x001AFE91
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x001B1C99 File Offset: 0x001AFE99
		public int Leadership { get; private set; } = 1;

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x001B1CA2 File Offset: 0x001AFEA2
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x001B1CAA File Offset: 0x001AFEAA
		public int Charisma { get; private set; } = 1;

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x001B1CB3 File Offset: 0x001AFEB3
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x001B1CBB File Offset: 0x001AFEBB
		public int Potential { get; private set; } = 1;

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x001B1CC4 File Offset: 0x001AFEC4
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x001B1CCC File Offset: 0x001AFECC
		public Character Heir { get; private set; }

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x001B1CD5 File Offset: 0x001AFED5
		public IReadOnlyList<Character> Children
		{
			get
			{
				return this.children;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x001B1CDD File Offset: 0x001AFEDD
		public bool HasChildren
		{
			get
			{
				return this.children.Count != 0;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x001B1CED File Offset: 0x001AFEED
		public IReadOnlyList<Trait> Traits
		{
			get
			{
				return this.traits;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x001B1CF5 File Offset: 0x001AFEF5
		public IEnumerable<Character> Cousins
		{
			get
			{
				foreach (Character character in this.Mother.Children)
				{
					if (character != this)
					{
						yield return character;
					}
				}
				IEnumerator<Character> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x001B1D05 File Offset: 0x001AFF05
		public void Init(Character father, Character mother)
		{
			this.Mother = mother;
			this.Father = father;
			this.Mother.AddChild(this);
			this.Father.AddChild(this);
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x001B1D30 File Offset: 0x001AFF30
		public void Init(Character[] parents)
		{
			foreach (Character character in parents)
			{
				if (character.IsMale)
				{
					this.Father = character;
				}
				else
				{
					this.Mother = character;
				}
				character.AddChild(this);
			}
			if (this.Mother != null && this.Father != null)
			{
				Character.Marriage(this.Mother, this.Father);
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x001B1D91 File Offset: 0x001AFF91
		public static void Marriage(Character male, Character female)
		{
			male.Spouse = female;
			female.Spouse = male;
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x001B1DA1 File Offset: 0x001AFFA1
		public void AddChild(Character child)
		{
			this.children.Add(child);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x001B1DAF File Offset: 0x001AFFAF
		public void Die()
		{
			this.IsAlive = false;
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x001B1DB8 File Offset: 0x001AFFB8
		public override string ToString()
		{
			return this.Name + "(" + this.CharacterId + ")";
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x001B1DD8 File Offset: 0x001AFFD8
		public void AssignHeir(Character heir)
		{
			if (!this.children.Contains(heir))
			{
				string str = (this != null) ? this.ToString() : null;
				string str2 = " assigned heir ";
				Character heir2 = this.Heir;
				Debug.LogError(str + str2 + ((heir2 != null) ? heir2.ToString() : null) + " is not my child");
				return;
			}
			this.Heir = heir;
			if (this.Spouse != null)
			{
				this.Spouse.Heir = heir;
			}
		}

		// Token: 0x04002FF6 RID: 12278
		private Character father;

		// Token: 0x04002FF7 RID: 12279
		private Character mother;

		// Token: 0x04003000 RID: 12288
		private List<Character> children = new List<Character>();

		// Token: 0x04003001 RID: 12289
		private List<Trait> traits = new List<Trait>();

		// Token: 0x02000F09 RID: 3849
		public enum eAgeBracket
		{
			// Token: 0x04004498 RID: 17560
			Child,
			// Token: 0x04004499 RID: 17561
			Prime,
			// Token: 0x0400449A RID: 17562
			Mature,
			// Token: 0x0400449B RID: 17563
			Elder
		}

		// Token: 0x02000F0A RID: 3850
		public enum eGender
		{
			// Token: 0x0400449D RID: 17565
			Male,
			// Token: 0x0400449E RID: 17566
			Female
		}
	}
}
