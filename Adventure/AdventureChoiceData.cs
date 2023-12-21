using System;
using System.Collections.Generic;
using Logic;
using Squads;
using ToolJsonData;

namespace Adventure
{
	// Token: 0x02000335 RID: 821
	public class AdventureChoiceData
	{
		// Token: 0x060010C9 RID: 4297 RVA: 0x0006C79C File Offset: 0x0006A99C
		public AdventureChoiceData(AdventureDoingChoice data)
		{
			this.ChoiceId = data.ChoiceId;
			this.ResultIndex = data.ResultsIndex;
			this.StatsCost = new AdventureInitial
			{
				Hp = data.StatsCost.HP,
				Coin = data.StatsCost.Coin,
				Danger = data.StatsCost.Danger
			};
			this.StatsReward = new AdventureInitial
			{
				Hp = data.StatsReward.HP,
				Coin = data.StatsReward.Coin,
				Danger = data.StatsReward.Danger
			};
			this.Items.Clear();
			this.Badges.Clear();
			this.Traits.Clear();
			for (int i = 0; i < data.RewardRange.Items.Count; i++)
			{
				this.Items.Add(new CostType(data.RewardRange.Items[i].Name, data.RewardRange.Items[i].Num, data.RewardRange.Items[i].Id));
			}
			for (int j = 0; j < data.RewardRange.Badges.Count; j++)
			{
				this.Badges.Add(new CostType(data.RewardRange.Badges[j].Name, data.RewardRange.Badges[j].Num, data.RewardRange.Badges[j].Id));
			}
			for (int k = 0; k < data.RewardRange.Traits.Count; k++)
			{
				this.Traits.Add(new CostType(data.RewardRange.Traits[k].Name, 0, data.RewardRange.Traits[k].Id));
			}
		}

		// Token: 0x04001303 RID: 4867
		public int ChoiceId;

		// Token: 0x04001304 RID: 4868
		public int ResultIndex;

		// Token: 0x04001305 RID: 4869
		public AdventureInitial StatsCost;

		// Token: 0x04001306 RID: 4870
		public AdventureInitial StatsReward;

		// Token: 0x04001307 RID: 4871
		public List<CostType> Items = new List<CostType>();

		// Token: 0x04001308 RID: 4872
		public List<CostType> Badges = new List<CostType>();

		// Token: 0x04001309 RID: 4873
		public List<CostType> Traits = new List<CostType>();
	}
}
