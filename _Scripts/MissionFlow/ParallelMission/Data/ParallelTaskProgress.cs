using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ToolJsonData;

namespace _Scripts.MissionFlow.ParallelMission.Data
{
	// Token: 0x02000321 RID: 801
	public class ParallelTaskProgress
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x0006A13C File Offset: 0x0006833C
		public void InitJson()
		{
			this.ConvertedCurrent = JsonConvert.DeserializeObject<ConditionJson>(this.Current);
			this.ConvertedTarget = JsonConvert.DeserializeObject<ConditionJson>(this.Target);
			this.intCurrent = this.GetPropertyValue(this.Current);
			this.intTarget = this.GetPropertyValue(this.Target);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0006A190 File Offset: 0x00068390
		private int GetPropertyValue(string json)
		{
			using (List<JProperty>.Enumerator enumerator = JObject.Parse(json).Properties().ToList<JProperty>().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					return int.Parse(enumerator.Current.Value["Num"].ToString());
				}
			}
			throw new Exception("Num not found in JSON.");
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0006A210 File Offset: 0x00068410
		public CheckType GetCheckType()
		{
			if (this.ConvertedTarget.SectorTotal.Num != 0)
			{
				return CheckType.UnlockSector;
			}
			if (this.ConvertedTarget.SectorWhich.Num != 0)
			{
				return CheckType.UnlockSector;
			}
			if (this.ConvertedTarget.BuildingBuildTotal.Num != 0)
			{
				return CheckType.Build;
			}
			if (this.ConvertedTarget.BuildingBuildWhich.Num != 0)
			{
				return CheckType.Build;
			}
			if (this.ConvertedTarget.BuildingUpgradeTotal.Num != 0)
			{
				return CheckType.UpgradeBuilding;
			}
			if (this.ConvertedTarget.BuildingRepairTotal.Num != 0)
			{
				return CheckType.Repair;
			}
			if (this.ConvertedTarget.SquadRecruitTotal.Num != 0)
			{
				return CheckType.Recruit;
			}
			if (this.ConvertedTarget.SquadRecruitWhich.Num != 0)
			{
				return CheckType.Recruit;
			}
			if (this.ConvertedTarget.SquadRecoverTotal.Num != 0)
			{
				return CheckType.Recover;
			}
			if (this.ConvertedTarget.SquadRecoverWhich.Num != 0)
			{
				return CheckType.Recover;
			}
			if (this.ConvertedTarget.HeroesAssigned.Num != 0)
			{
				return CheckType.AssignHero;
			}
			if (this.ConvertedTarget.ItemCollectWhich.Num != 0)
			{
				return CheckType.ClaimResource;
			}
			if (this.ConvertedTarget.ItemSpendWhich.Num != 0)
			{
				return CheckType.SpendResource;
			}
			return CheckType.None;
		}

		// Token: 0x04001276 RID: 4726
		public int SubIdx;

		// Token: 0x04001277 RID: 4727
		public string Current;

		// Token: 0x04001278 RID: 4728
		public string Target;

		// Token: 0x04001279 RID: 4729
		public bool Completed;

		// Token: 0x0400127A RID: 4730
		public bool RewardCompleted;

		// Token: 0x0400127B RID: 4731
		public ConditionJson ConvertedCurrent;

		// Token: 0x0400127C RID: 4732
		public ConditionJson ConvertedTarget;

		// Token: 0x0400127D RID: 4733
		public int intCurrent;

		// Token: 0x0400127E RID: 4734
		public int intTarget;
	}
}
