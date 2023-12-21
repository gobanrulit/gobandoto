using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x02000319 RID: 793
	public class ParallelMissionData
	{
		// Token: 0x04001243 RID: 4675
		[GUIColor(0.1f, 0.8f, 0f, 1f)]
		public int _id;

		// Token: 0x04001244 RID: 4676
		public List<SubParallelMissionData> subMissions = new List<SubParallelMissionData>();
	}
}
