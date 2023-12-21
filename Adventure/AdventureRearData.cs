using System;
using System.Collections.Generic;
using Logic;
using Squads;

namespace Adventure
{
	// Token: 0x02000334 RID: 820
	public class AdventureRearData
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x0006C5A4 File Offset: 0x0006A7A4
		public AdventureRearData(AdventureDoing data)
		{
			this.Id = data.Id;
			this.RegionId = data.RegionId;
			this.AdventureProperty = new AdventureInitial
			{
				Hp = data.AdventureProperty.HP,
				Coin = data.AdventureProperty.Coin,
				Danger = data.AdventureProperty.Danger
			};
			this.UnlockTime = data.UnlockTime;
			this.HeroId = data.HeroId;
			this.DoneStatus = (DoneStatus)data.DoneStatus;
			this.CurrentSceneId = data.CurrentSceneId;
			this.ChoiceTime = data.ChoiceTime;
			this.PrevSceneId = data.PrevSceneId;
			this.ChoiceGroup.Clear();
			this.SceneIdList.Clear();
			this.Historys.Clear();
			foreach (KeyValuePair<int, AdventureDoingChoice> keyValuePair in data.ChoiceGroup)
			{
				this.SceneIdList.Add(keyValuePair.Key);
				this.ChoiceGroup.Add(keyValuePair.Key, new AdventureChoiceData(keyValuePair.Value));
			}
			this.BuyAttempsRecord.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair2 in data.BuyAttemptsRecord)
			{
				this.BuyAttempsRecord.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
			for (int i = 0; i < data.DoneHistory.Count; i++)
			{
				this.Historys.Add(new AdventureHistory(data.DoneHistory[i]));
			}
		}

		// Token: 0x040012F6 RID: 4854
		public int Id;

		// Token: 0x040012F7 RID: 4855
		public int RegionId;

		// Token: 0x040012F8 RID: 4856
		public AdventureInitial AdventureProperty;

		// Token: 0x040012F9 RID: 4857
		public long UnlockTime;

		// Token: 0x040012FA RID: 4858
		public long ChoiceTime;

		// Token: 0x040012FB RID: 4859
		public string HeroId;

		// Token: 0x040012FC RID: 4860
		public DoneStatus DoneStatus;

		// Token: 0x040012FD RID: 4861
		public int CurrentSceneId;

		// Token: 0x040012FE RID: 4862
		public Dictionary<int, AdventureChoiceData> ChoiceGroup = new Dictionary<int, AdventureChoiceData>();

		// Token: 0x040012FF RID: 4863
		public Dictionary<long, bool> BuyAttempsRecord = new Dictionary<long, bool>();

		// Token: 0x04001300 RID: 4864
		public int PrevSceneId;

		// Token: 0x04001301 RID: 4865
		public List<AdventureHistory> Historys = new List<AdventureHistory>();

		// Token: 0x04001302 RID: 4866
		public List<int> SceneIdList = new List<int>();
	}
}
