using System;
using System.Collections.Generic;
using Logic;

namespace Adventure
{
	// Token: 0x02000333 RID: 819
	public class AllAdventureData
	{
		// Token: 0x060010C7 RID: 4295 RVA: 0x0006C484 File Offset: 0x0006A684
		public AllAdventureData(Adventure data)
		{
			this.Id = data.ID;
			this.Name = data.Name;
			this.AdventureDatas.Clear();
			for (int i = 0; i < data.AdventureDoing.Count; i++)
			{
				this.AdventureDatas.Add(new AdventureRearData(data.AdventureDoing[i]));
			}
			this.DailyTime = data.DailyTime;
			this.HeroDoneRecord.Clear();
			foreach (KeyValuePair<string, Int32List> keyValuePair in data.HeroDoneRecord)
			{
				List<int> list = new List<int>();
				for (int j = 0; j < keyValuePair.Value.List.Count; j++)
				{
					list.Add(keyValuePair.Value.List[j]);
				}
				this.HeroDoneRecord.Add(keyValuePair.Key, list);
			}
		}

		// Token: 0x040012F1 RID: 4849
		public string Id;

		// Token: 0x040012F2 RID: 4850
		public string Name;

		// Token: 0x040012F3 RID: 4851
		public List<AdventureRearData> AdventureDatas = new List<AdventureRearData>();

		// Token: 0x040012F4 RID: 4852
		public long DailyTime;

		// Token: 0x040012F5 RID: 4853
		public Dictionary<string, List<int>> HeroDoneRecord = new Dictionary<string, List<int>>();
	}
}
