using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace _Scripts.MissionFlow.ParallelMission.Data
{
	// Token: 0x0200031F RID: 799
	public class ParallelMissionProgress
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x0006A0C4 File Offset: 0x000682C4
		public ParallelMissionProgress()
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0006A0D8 File Offset: 0x000682D8
		public ParallelMissionProgress(string json)
		{
			ParallelMissionProgress parallelMissionProgress = JsonConvert.DeserializeObject<ParallelMissionProgress>(json);
			this.DurationType = parallelMissionProgress.DurationType;
			this.Id = parallelMissionProgress.Id;
			this.TaskProgress = parallelMissionProgress.TaskProgress;
			this.Completed = parallelMissionProgress.Completed;
			this.RewardCompleted = parallelMissionProgress.RewardCompleted;
		}

		// Token: 0x04001266 RID: 4710
		public int DurationType;

		// Token: 0x04001267 RID: 4711
		public int Id;

		// Token: 0x04001268 RID: 4712
		public List<ParallelTaskProgress> TaskProgress = new List<ParallelTaskProgress>();

		// Token: 0x04001269 RID: 4713
		public bool Completed;

		// Token: 0x0400126A RID: 4714
		public bool RewardCompleted;
	}
}
