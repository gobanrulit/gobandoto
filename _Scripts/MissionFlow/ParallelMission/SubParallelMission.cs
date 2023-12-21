using System;
using System.Collections.Generic;
using Buildings;
using Game.PVE;
using Item;
using Sector;
using Sirenix.OdinInspector;
using Squads;
using UnityEngine;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x0200031D RID: 797
	[Serializable]
	public class SubParallelMission
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00069D2D File Offset: 0x00067F2D
		public string Title
		{
			get
			{
				return LocalizationText.GetText(this.TitleLangID);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00069D3A File Offset: 0x00067F3A
		public string TaskContents
		{
			get
			{
				return LocalizationText.GetText(this.TaskContentsLangID);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00069D47 File Offset: 0x00067F47
		public string CompleteTitle
		{
			get
			{
				return LocalizationText.GetText(this.CompleteTitleLangID);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00069D54 File Offset: 0x00067F54
		public string CompleteContents
		{
			get
			{
				return LocalizationText.GetText(this.CompleteContentsLangID);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00069D61 File Offset: 0x00067F61
		private bool showIsGlobal
		{
			get
			{
				return this.completeConditionType == ParallelMissionTemplate.CompleteConditionType.Recruit_X_Squads || this.completeConditionType == ParallelMissionTemplate.CompleteConditionType.Recruit_X_Squads_Y;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00069D80 File Offset: 0x00067F80
		private bool showValue1
		{
			get
			{
				return this.completeConditionType.ToString().Contains("_X");
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00069DA2 File Offset: 0x00067FA2
		private bool showBuilding
		{
			get
			{
				return this.completeConditionType.ToString().Contains("Buildings_Y") || this.completeConditionType.ToString().Contains("Buildings_Params");
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00069DE4 File Offset: 0x00067FE4
		private bool showSector
		{
			get
			{
				return (this.completeConditionType.ToString().Contains("Sector") && !this.completeConditionType.ToString().Contains("Sectors")) || this.completeConditionType.ToString().Contains("Buildings_Params");
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00069E4B File Offset: 0x0006804B
		private bool showSquad
		{
			get
			{
				return this.completeConditionType != ParallelMissionTemplate.CompleteConditionType.Recover_x_Squads_Y_Times && this.completeConditionType.ToString().Contains("Squads_Y");
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00069E7A File Offset: 0x0006807A
		private bool showItem
		{
			get
			{
				return this.completeConditionType.ToString().Contains("Resources_Y");
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00069E9C File Offset: 0x0006809C
		private bool showEnemy
		{
			get
			{
				return this.completeConditionType.ToString().Contains("Enemies_Y");
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00069EBE File Offset: 0x000680BE
		private bool showEvent
		{
			get
			{
				return this.completeConditionType.ToString().Contains("Events_Y");
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00069EE0 File Offset: 0x000680E0
		private bool showHero
		{
			get
			{
				return this.completeConditionType.ToString().Contains("Heros_Y");
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00069F02 File Offset: 0x00068102
		private Color GetButtonColor()
		{
			if (this.completeConditionType == ParallelMissionTemplate.CompleteConditionType.None)
			{
				return Color.red;
			}
			return new Color(0.3f, 0.6f, 0.3f);
		}

		// Token: 0x04001251 RID: 4689
		[ReadOnly]
		public int FatherMissionId = -1;

		// Token: 0x04001252 RID: 4690
		[Space(50f)]
		[GUIColor(0.8f, 0.1f, 0.6f, 1f)]
		public int _id;

		// Token: 0x04001253 RID: 4691
		[LocalizationOdin]
		public int TitleLangID;

		// Token: 0x04001254 RID: 4692
		[LocalizationOdin]
		public int TaskContentsLangID;

		// Token: 0x04001255 RID: 4693
		[LocalizationOdin]
		public int CompleteTitleLangID;

		// Token: 0x04001256 RID: 4694
		[LocalizationOdin]
		public int CompleteContentsLangID;

		// Token: 0x04001257 RID: 4695
		public List<ItemGroup> Reward = new List<ItemGroup>();

		// Token: 0x04001258 RID: 4696
		[Space(10f)]
		[GUIColor("GetButtonColor")]
		public ParallelMissionTemplate.CompleteConditionType completeConditionType = ParallelMissionTemplate.CompleteConditionType.None;

		// Token: 0x04001259 RID: 4697
		[ShowIf("showIsGlobal", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public bool isGlobal = true;

		// Token: 0x0400125A RID: 4698
		[ShowIf("showValue1", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public int value1;

		// Token: 0x0400125B RID: 4699
		[ShowIf("showBuilding", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public BuildingType buildingType;

		// Token: 0x0400125C RID: 4700
		[ShowIf("showBuilding", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public int buildingLevel = -1;

		// Token: 0x0400125D RID: 4701
		[ShowIf("showSector", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public SectorTemplate sector;

		// Token: 0x0400125E RID: 4702
		[ShowIf("showSquad", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public SquadTemplate squad;

		// Token: 0x0400125F RID: 4703
		[ShowIf("showItem", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public ItemTemplate item;

		// Token: 0x04001260 RID: 4704
		[ShowIf("showEnemy", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public PVEEnemyTemplate enemy;

		// Token: 0x04001261 RID: 4705
		[ShowIf("showEvent", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public EventTemplate _event;

		// Token: 0x04001262 RID: 4706
		[ShowIf("showHero", true)]
		[GUIColor(0.3f, 0.6f, 0.3f, 1f)]
		public HeroTemplate hero;
	}
}
