using System;
using System.Collections.Generic;
using System.Linq;
using Game.UI;
using Item;
using Mission;
using Mission.Parallel;
using Newtonsoft.Json.Linq;
using Sirenix.OdinInspector;
using TOOLS;
using UnityEngine;
using ZFramework;
using _Scripts.MissionFlow.ParallelMission.Data;

namespace _Scripts.MissionFlow.ParallelMission
{
	// Token: 0x02000318 RID: 792
	public class ParallelMissionManager : BaseMgr<ParallelMissionManager>
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00069264 File Offset: 0x00067464
		public UIMissionFlowBarPanel MissionFlowBarPanel
		{
			get
			{
				if (this._uiMissionFlowBarPanel == null)
				{
					if (UIKit.GetPanel<UIMissionFlowBarPanel>() == null)
					{
						this._uiMissionFlowBarPanel = UIKit.OpenPanel<UIMissionFlowBarPanel>(UILevel.Static2, true, true, null, null, null);
					}
					else
					{
						this._uiMissionFlowBarPanel = UIKit.GetPanel<UIMissionFlowBarPanel>();
					}
				}
				return this._uiMissionFlowBarPanel;
			}
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000692B4 File Offset: 0x000674B4
		public override void _Start()
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000692B8 File Offset: 0x000674B8
		public override void _Update()
		{
			if (this.timer < 0.6f)
			{
				this.timer += Time.deltaTime;
				return;
			}
			this.timer = 0f;
			if (this._normalParallelMissions.Count <= 0)
			{
				return;
			}
			this.CheckShowMission();
			this.CheckCompleteMission();
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0006930C File Offset: 0x0006750C
		private ParallelMissionData GetParallelMissionDataById(int idx)
		{
			foreach (ParallelMissionData parallelMissionData in this._normalParallelMissions)
			{
				if (parallelMissionData._id == idx)
				{
					return parallelMissionData;
				}
			}
			return null;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00069368 File Offset: 0x00067568
		public void InitDatas(Action callback = null)
		{
			foreach (ParallelMissionProgress parallelMissionProgress in this.parallelMissionInfo.MissionProgress)
			{
				if (!parallelMissionProgress.Completed)
				{
					ParallelMissionTemplate parallelMissionTemplateById = SingletonScriptableObject<ParallelMissionTemplateManager>.Instance.GetParallelMissionTemplateById(parallelMissionProgress.Id);
					ParallelMissionData parallelMissionData = new ParallelMissionData();
					parallelMissionData._id = parallelMissionTemplateById.id;
					this._normalParallelMissions.Add(parallelMissionData);
					int num = -1;
					foreach (ParallelTaskProgress parallelTaskProgress in parallelMissionProgress.TaskProgress)
					{
						if (!parallelTaskProgress.Completed)
						{
							num = parallelTaskProgress.SubIdx;
							break;
						}
					}
					if (num != -1)
					{
						for (int i = num; i < parallelMissionTemplateById.subMissionChain.Count; i++)
						{
							SubParallelMission subParallelMission = parallelMissionTemplateById.subMissionChain[i];
							SubParallelMissionData subParallelMissionData = new SubParallelMissionData();
							subParallelMissionData._id = subParallelMission._id;
							subParallelMissionData.CurrentState = SubParallelMissionState.NotPrepared;
							parallelMissionData.subMissions.Add(subParallelMissionData);
						}
					}
				}
			}
			this.DatasInited = true;
			this.CheckShowMission();
			this.CheckAllCurrentSubMissionCanComplete(this.parallelMissionInfo);
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000694C8 File Offset: 0x000676C8
		private void CheckCompleteMission()
		{
			if (!this.DatasInited || this._normalParallelMissions.Count <= 0)
			{
				return;
			}
			for (int i = this._normalParallelMissions.Count - 1; i >= 0; i--)
			{
				ParallelMissionData parallelMissionData = this._normalParallelMissions[i];
				if (parallelMissionData.subMissions.Count <= 0)
				{
					this._normalParallelMissions.Remove(parallelMissionData);
				}
			}
			if (this._normalParallelMissions.Count <= 0)
			{
				return;
			}
			using (IEnumerator<ParallelMissionData> enumerator = (from m in this._normalParallelMissions
			where m.subMissions.Count > 0 && m.subMissions[0].CurrentState == SubParallelMissionState.CompletedAndShowingCompleteUI
			select m).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ParallelMissionData parallelMissionData2 = enumerator.Current;
					return;
				}
			}
			foreach (ParallelMissionData parallelMissionData3 in this._normalParallelMissions)
			{
				if (parallelMissionData3.subMissions.Count > 0)
				{
					SubParallelMissionState currentState = parallelMissionData3.subMissions[0].CurrentState;
				}
			}
			using (List<ParallelMissionData>.Enumerator enumerator2 = this._normalParallelMissions.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					ParallelMissionData mission = enumerator2.Current;
					if (mission.subMissions.Count > 0 && mission.subMissions[0].CurrentState == SubParallelMissionState.CompletedAndWaitToShowCompleteUI)
					{
						SubParallelMission template = SingletonScriptableObject<ParallelMissionTemplateManager>.Instance.GetSubParallelMissionByIds(mission._id, mission.subMissions[0]._id);
						List<AddAttributeClass> list = new List<AddAttributeClass>();
						foreach (ItemGroup award in template.Reward)
						{
							list.Add(new AddAttributeClass
							{
								award = award
							});
						}
						if (!this.isShowingCompleteUI)
						{
							this.isShowingCompleteUI = true;
							mission.subMissions[0].CurrentState = SubParallelMissionState.CompletedAndShowingCompleteUI;
							Action<bool> <>9__3;
							Action completeCallback = delegate()
							{
								ParallelMissionGateway instance = SingletonBase<ParallelMissionGateway>.GetInstance();
								Action<bool> callback;
								if ((callback = <>9__3) == null)
								{
									callback = (<>9__3 = delegate(bool r)
									{
										if (r)
										{
											global::Logger.Log(Channel.编辑模式, Priority.Error, "发送完成子任务的请求成功");
											this.isShowingCompleteUI = false;
											this._uiMissionFlowBarPanel.DeleteAParallelMissionItem(template);
											mission.subMissions.RemoveAt(0);
										}
									});
								}
								instance.GetParallelMission(callback);
							};
							Action<bool> <>9__5;
							Action<bool> <>9__4;
							Action action = delegate()
							{
								ParallelMissionGateway instance = SingletonBase<ParallelMissionGateway>.GetInstance();
								int id = mission._id;
								int id2 = mission.subMissions[0]._id;
								Action<bool> callback;
								if ((callback = <>9__4) == null)
								{
									callback = (<>9__4 = delegate(bool r)
									{
										if (r)
										{
											if (mission.subMissions.Count <= 0)
											{
												ParallelMissionGateway instance2 = SingletonBase<ParallelMissionGateway>.GetInstance();
												int id3 = mission._id;
												int subIdx = -1;
												Action<bool> callback2;
												if ((callback2 = <>9__5) == null)
												{
													callback2 = (<>9__5 = delegate(bool r)
													{
														if (r)
														{
															completeCallback();
														}
													});
												}
												instance2.CompleteParallelMission(id3, subIdx, callback2);
												return;
											}
											completeCallback();
										}
									});
								}
								instance.CompleteParallelMission(id, id2, callback);
							};
							GlobalEvent.Dispatch(GameEventEnum.ParallelMissionComplete, Array.Empty<object>());
							UIKit.OpenPanel<UIMIssionFlowCompletePop>(UILevel.GuidePop1, true, true, null, null, null).Show(template.CompleteContents, new object[]
							{
								list,
								template.CompleteTitle,
								action,
								false
							});
							break;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00069820 File Offset: 0x00067A20
		private void CheckShowMission()
		{
			if (!this.DatasInited || this._normalParallelMissions.Count <= 0)
			{
				return;
			}
			foreach (ParallelMissionData parallelMissionData in this._normalParallelMissions)
			{
				if (parallelMissionData.subMissions.Count > 0 && parallelMissionData.subMissions[0].CurrentState == SubParallelMissionState.NotPrepared)
				{
					parallelMissionData.subMissions[0].CurrentState = SubParallelMissionState.Prepared;
				}
			}
			bool flag = false;
			foreach (ParallelMissionData parallelMissionData2 in this._normalParallelMissions)
			{
				if (parallelMissionData2.subMissions.Count > 0 && parallelMissionData2.subMissions[0].CurrentState == SubParallelMissionState.Prepared)
				{
					SubParallelMission subParallelMissionByIds = SingletonScriptableObject<ParallelMissionTemplateManager>.Instance.GetSubParallelMissionByIds(parallelMissionData2._id, parallelMissionData2.subMissions[0]._id);
					parallelMissionData2.subMissions[0].CurrentState = SubParallelMissionState.Showing;
					this.MissionFlowBarPanel.CreateAParallelMissionItem(subParallelMissionByIds, parallelMissionData2, null);
					this.CheckAllCurrentSubMissionCanComplete(this.parallelMissionInfo);
					flag = true;
				}
			}
			if (flag)
			{
				SingletonBase<ParallelMissionGateway>.GetInstance().GetParallelMission(delegate(bool r)
				{
					if (r)
					{
						this.CheckAllCurrentSubMissionCanComplete(SingletonMono<ParallelMissionManager>.GetInstance().parallelMissionInfo);
					}
				});
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00069984 File Offset: 0x00067B84
		public void CheckAllCurrentSubMissionCanComplete(ParallelMissionInfo p)
		{
			if (p == null)
			{
				return;
			}
			foreach (ParallelMissionProgress parallelMissionProgress in p.MissionProgress)
			{
				foreach (ParallelTaskProgress parallelTaskProgress in parallelMissionProgress.TaskProgress)
				{
					int propertyValue = this.GetPropertyValue(parallelTaskProgress.Current);
					int propertyValue2 = this.GetPropertyValue(parallelTaskProgress.Target);
					if (propertyValue >= propertyValue2)
					{
						foreach (SubParallelMissionData subParallelMissionData in this.GetParallelMissionDataById(parallelMissionProgress.Id).subMissions)
						{
							if (subParallelMissionData._id - 1 == parallelTaskProgress.SubIdx)
							{
								SubParallelMissionData subParallelMissionData2 = subParallelMissionData;
								if (subParallelMissionData2.CurrentState == SubParallelMissionState.Showing)
								{
									subParallelMissionData2.CurrentState = SubParallelMissionState.CompletedAndWaitToShowCompleteUI;
									break;
								}
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00069AAC File Offset: 0x00067CAC
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

		// Token: 0x06001045 RID: 4165 RVA: 0x00069B2C File Offset: 0x00067D2C
		public ParallelMissionProgress CheckNeedCall(CheckType c)
		{
			if (this._normalParallelMissions.Count <= 0)
			{
				return null;
			}
			foreach (ParallelMissionProgress parallelMissionProgress in this.parallelMissionInfo.MissionProgress)
			{
				if (parallelMissionProgress.TaskProgress.Count > 0)
				{
					CheckType checkType = parallelMissionProgress.TaskProgress[parallelMissionProgress.TaskProgress.Count - 1].GetCheckType();
					if (c == checkType)
					{
						return parallelMissionProgress;
					}
				}
			}
			return null;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00069BC4 File Offset: 0x00067DC4
		public void RefreshProgressUIs(ParallelMissionProgress m)
		{
			foreach (ParallelMissionProgress parallelMissionProgress in this.parallelMissionInfo.MissionProgress)
			{
				ParallelTaskProgress parallelTaskProgress = parallelMissionProgress.TaskProgress.Last<ParallelTaskProgress>();
				foreach (KeyValuePair<SubParallelMission, ParallelMissionItem> keyValuePair in this._uiMissionFlowBarPanel.parallelMissionUIItemDic)
				{
					if (keyValuePair.Key.FatherMissionId == parallelMissionProgress.Id && keyValuePair.Key._id == parallelTaskProgress.SubIdx + 1)
					{
						keyValuePair.Value.SetProgressUIs(parallelTaskProgress.intCurrent, parallelTaskProgress.intTarget);
						break;
					}
				}
			}
		}

		// Token: 0x0400123D RID: 4669
		public ParallelMissionInfo parallelMissionInfo;

		// Token: 0x0400123E RID: 4670
		private UIMissionFlowBarPanel _uiMissionFlowBarPanel;

		// Token: 0x0400123F RID: 4671
		private float timer;

		// Token: 0x04001240 RID: 4672
		[ReadOnly]
		private List<ParallelMissionData> _normalParallelMissions = new List<ParallelMissionData>();

		// Token: 0x04001241 RID: 4673
		[ReadOnly]
		public bool DatasInited;

		// Token: 0x04001242 RID: 4674
		private bool isShowingCompleteUI;
	}
}
