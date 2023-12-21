using System;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x0200031A RID: 794
	public enum SubParallelMissionState
	{
		// Token: 0x04001246 RID: 4678
		NotPrepared,
		// Token: 0x04001247 RID: 4679
		Prepared,
		// Token: 0x04001248 RID: 4680
		Showing,
		// Token: 0x04001249 RID: 4681
		CompletedAndWaitToShowCompleteUI,
		// Token: 0x0400124A RID: 4682
		CompletedAndShowingCompleteUI
	}
}
