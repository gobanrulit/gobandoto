using System;
using Logic;

namespace Adventure
{
	// Token: 0x02000336 RID: 822
	public class AdventureHistory
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0006C9B8 File Offset: 0x0006ABB8
		public AdventureHistory(AdventureHistory history)
		{
			this.RegionId = history.RegionId;
			this.UnlockTime = history.UnlockTime;
			this.HeroId = history.HeroId;
			this.DoneTime = history.DoneTime;
			this.DoneStatus = history.DoneStatus;
		}

		// Token: 0x0400130A RID: 4874
		public int RegionId;

		// Token: 0x0400130B RID: 4875
		public long UnlockTime;

		// Token: 0x0400130C RID: 4876
		public string HeroId;

		// Token: 0x0400130D RID: 4877
		public long DoneTime;

		// Token: 0x0400130E RID: 4878
		public int DoneStatus;
	}
}
