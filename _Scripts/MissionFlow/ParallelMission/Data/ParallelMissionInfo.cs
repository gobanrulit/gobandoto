using System;
using System.Collections.Generic;
using Logic;
using Newtonsoft.Json;

namespace _Scripts.MissionFlow.ParallelMission.Data
{
	// Token: 0x0200031E RID: 798
	public class ParallelMissionInfo
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00069F58 File Offset: 0x00068158
		public ParallelMissionInfo(ParallelMission p)
		{
			this.ID = p.ID;
			this.PlayerId = p.PlayerId;
			this.MissionProgress = JsonConvert.DeserializeObject<List<ParallelMissionProgress>>(p.MissionProgress.ToString());
			foreach (ParallelMissionProgress parallelMissionProgress in this.MissionProgress)
			{
				foreach (ParallelTaskProgress parallelTaskProgress in parallelMissionProgress.TaskProgress)
				{
					parallelTaskProgress.InitJson();
				}
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0006A020 File Offset: 0x00068220
		public ParallelTaskProgress GetATaskProgress(int id, int subId)
		{
			foreach (ParallelMissionProgress parallelMissionProgress in this.MissionProgress)
			{
				if (parallelMissionProgress.Id == id)
				{
					foreach (ParallelTaskProgress parallelTaskProgress in parallelMissionProgress.TaskProgress)
					{
						if (parallelTaskProgress.SubIdx == subId - 1)
						{
							return parallelTaskProgress;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x04001263 RID: 4707
		public string ID;

		// Token: 0x04001264 RID: 4708
		public string PlayerId;

		// Token: 0x04001265 RID: 4709
		public List<ParallelMissionProgress> MissionProgress = new List<ParallelMissionProgress>();
	}
}
