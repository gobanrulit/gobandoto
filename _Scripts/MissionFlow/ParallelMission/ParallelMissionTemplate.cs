using System;
using System.Collections.Generic;
using Item;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x0200031C RID: 796
	public class ParallelMissionTemplate : ScriptableObject, iTemplateType
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00069D25 File Offset: 0x00067F25
		string iTemplateType.get_name()
		{
			return base.name;
		}

		// Token: 0x0400124D RID: 4685
		[GUIColor(0.8f, 0.7f, 0.6f, 1f)]
		public int id;

		// Token: 0x0400124E RID: 4686
		public ParallelMissionTemplate.DurationType durationType = ParallelMissionTemplate.DurationType.FromNowOn;

		// Token: 0x0400124F RID: 4687
		public List<ItemGroup> Reward = new List<ItemGroup>();

		// Token: 0x04001250 RID: 4688
		[ListDrawerSettings(NumberOfItemsPerPage = 200)]
		public List<SubParallelMission> subMissionChain = new List<SubParallelMission>();

		// Token: 0x02000BCE RID: 3022
		public enum DurationType
		{
			// Token: 0x04003BC3 RID: 15299
			FromNowOn = 1,
			// Token: 0x04003BC4 RID: 15300
			Daily
		}

		// Token: 0x02000BCF RID: 3023
		public enum CompleteConditionType
		{
			// Token: 0x04003BC6 RID: 15302
			None = -1,
			// Token: 0x04003BC7 RID: 15303
			Unlock_X_Sectors,
			// Token: 0x04003BC8 RID: 15304
			UnlockSector_x,
			// Token: 0x04003BC9 RID: 15305
			Build_X_Buildings = 100,
			// Token: 0x04003BCA RID: 15306
			Build_X_Buildings_Params,
			// Token: 0x04003BCB RID: 15307
			Upgrade_X_Buildings,
			// Token: 0x04003BCC RID: 15308
			Repair_X_Buildings,
			// Token: 0x04003BCD RID: 15309
			Recruit_X_Squads = 200,
			// Token: 0x04003BCE RID: 15310
			Recruit_X_Squads_Y,
			// Token: 0x04003BCF RID: 15311
			Recover_X_Squads,
			// Token: 0x04003BD0 RID: 15312
			Recover_X_Squads_Y,
			// Token: 0x04003BD1 RID: 15313
			RecoverSquads_X_Times,
			// Token: 0x04003BD2 RID: 15314
			Recover_x_Squads_Y_Times,
			// Token: 0x04003BD3 RID: 15315
			Collect_X_Resources = 300,
			// Token: 0x04003BD4 RID: 15316
			Collect_X_Resources_Y,
			// Token: 0x04003BD5 RID: 15317
			Collect_X_ResourcesThroughCommands,
			// Token: 0x04003BD6 RID: 15318
			Collect_X_Resources_Y_ThroughCommands,
			// Token: 0x04003BD7 RID: 15319
			Collect_X_ResourcesThroughMarketplace,
			// Token: 0x04003BD8 RID: 15320
			Collect_X_Resources_Y_ThroughMarketplace,
			// Token: 0x04003BD9 RID: 15321
			Spend_X_Resources,
			// Token: 0x04003BDA RID: 15322
			Spend_X_Resources_Y,
			// Token: 0x04003BDB RID: 15323
			Spend_X_ResourcesThroughCommands,
			// Token: 0x04003BDC RID: 15324
			Spend_X_Resources_Y_ThroughCommands,
			// Token: 0x04003BDD RID: 15325
			Spend_X_ResourcesThroughMarketplace,
			// Token: 0x04003BDE RID: 15326
			Spend_X_Resources_Y_ThroughMarketplace,
			// Token: 0x04003BDF RID: 15327
			Defeat_X_Enemies = 400,
			// Token: 0x04003BE0 RID: 15328
			Defeat_X_Enemies_Y,
			// Token: 0x04003BE1 RID: 15329
			Fightingwith_X_Enemies,
			// Token: 0x04003BE2 RID: 15330
			Fightingwith_X_Enemies_Y,
			// Token: 0x04003BE3 RID: 15331
			Dealwith_X_Events = 500,
			// Token: 0x04003BE4 RID: 15332
			Dealwith_X_Events_Y,
			// Token: 0x04003BE5 RID: 15333
			Export_X_Heros = 700,
			// Token: 0x04003BE6 RID: 15334
			Export_X_Heros_Y,
			// Token: 0x04003BE7 RID: 15335
			Import_X_Heros,
			// Token: 0x04003BE8 RID: 15336
			Import_X_Heros_Y,
			// Token: 0x04003BE9 RID: 15337
			Assigned_X_Heros,
			// Token: 0x04003BEA RID: 15338
			Assigned_X_Heros_Y,
			// Token: 0x04003BEB RID: 15339
			Assigned_X_HerosOnSquads,
			// Token: 0x04003BEC RID: 15340
			Assigned_X_Heros_Y_OnSquads,
			// Token: 0x04003BED RID: 15341
			Assigned_X_HerosOnBuildings,
			// Token: 0x04003BEE RID: 15342
			Assigned_X_Heros_Y_OnBuildings
		}
	}
}
