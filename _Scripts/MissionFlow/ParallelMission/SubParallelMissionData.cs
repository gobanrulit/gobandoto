using System;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x0200031B RID: 795
	public class SubParallelMissionData
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00069CE7 File Offset: 0x00067EE7
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00069CEF File Offset: 0x00067EEF
		public SubParallelMissionState CurrentState
		{
			get
			{
				return this._currentState;
			}
			set
			{
				this._currentState = value;
			}
		}

		// Token: 0x0400124B RID: 4683
		public int _id;

		// Token: 0x0400124C RID: 4684
		private SubParallelMissionState _currentState;
	}
}
