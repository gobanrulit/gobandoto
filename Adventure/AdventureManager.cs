using System;
using System.Collections.Generic;
using System.Text;
using Game.Core;
using Game.UI;
using Item;
using Network;
using Sirenix.OdinInspector;
using TOOLS;
using UnityEngine;
using UnityEngine.Events;
using ZFramework;

namespace Adventure
{
	// Token: 0x02000338 RID: 824
	public class AdventureManager : BaseMgr<AdventureManager>
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0006D0AA File Offset: 0x0006B2AA
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0006D0B2 File Offset: 0x0006B2B2
		public DateTime CurrentTime
		{
			get
			{
				return this.currentTime;
			}
			set
			{
				this.currentTime = value;
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0006D0BB File Offset: 0x0006B2BB
		public override void _Start()
		{
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
		public override void _Update()
		{
			if (this.startCount)
			{
				this._timer += Time.deltaTime;
				if (this._timer >= 1f)
				{
					this._timer = 0f;
					this.CurrentTime = this.CurrentTime.AddSeconds(1.0);
				}
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0006D11C File Offset: 0x0006B31C
		public void InitAdventures(UnityAction action = null)
		{
			AdventureGateway.Instance.GetAllAdventure(delegate(bool result, AllAdventureData data, long time)
			{
				if (!result)
				{
					Debug.LogError("Error :获取Adventure数据失败！");
					return;
				}
				this.RearDatas.Clear();
				this.FrontDatas.Clear();
				this.allData = data;
				this.RearDatas = this.allData.AdventureDatas;
				this.CurrentTime = DateTime.UnixEpoch.AddSeconds((double)time);
				List<int> list = new List<int>();
				for (int i = 0; i < this.RearDatas.Count; i++)
				{
					if (SingletonMono<RegionManager>.GetInstance().GetRegionAdventureId(this.RearDatas[i].RegionId) != 0 || (this.RearDatas[i].DoneStatus != DoneStatus.Complete && this.RearDatas[i].DoneStatus != DoneStatus.GameOver && this.RearDatas[i].DoneStatus != DoneStatus.UnStart))
					{
						AdventureFrontData adventureFrontData = new AdventureFrontData();
						adventureFrontData.UpdateData(this.RearDatas[i]);
						this.FrontDatas.Add(adventureFrontData);
						list.Add(this.RearDatas[i].Id);
					}
				}
				if (SingletonMono<RegionTool>.GetInstance() != null)
				{
					SingletonMono<RegionTool>.GetInstance().RemoveAllHero();
				}
				UIKit.ClosePanel<UIAdventureRightBarPanel>();
				UIAdventureRightBarPanel uiadventureRightBarPanel = UIKit.OpenPanel<UIAdventureRightBarPanel>(UILevel.Static, true, true, null, null, null);
				List<int> list2 = new List<int>();
				for (int j = 0; j < this.FrontDatas.Count; j++)
				{
					uiadventureRightBarPanel.AddMiniAdventure(this.FrontDatas[j], this.FrontDatas[j].CurMiniPharse);
					if (SingletonMono<RegionTool>.GetInstance() != null)
					{
						SingletonMono<RegionTool>.GetInstance().ShowAdventure(this.FrontDatas[j]);
					}
					list2.Add(this.FrontDatas[j].RegionId);
				}
				this.startCount = true;
				for (int k = 0; k < SingletonMono<RegionManager>.GetInstance().RegionDatas.Count; k++)
				{
					if (SingletonMono<RegionManager>.GetInstance().RegionDatas[k].AdventureId != 0 && !list2.Contains(SingletonMono<RegionManager>.GetInstance().RegionDatas[k].RegionID))
					{
						AdventureFrontData adventureFrontData2 = new AdventureFrontData(SingletonMono<RegionManager>.GetInstance().RegionDatas[k].AdventureId, SingletonMono<RegionManager>.GetInstance().RegionDatas[k].RegionID);
						this.FrontDatas.Add(adventureFrontData2);
						if (SingletonMono<RegionTool>.GetInstance() != null)
						{
							SingletonMono<RegionTool>.GetInstance().ShowAdventure(adventureFrontData2);
						}
					}
				}
				UnityAction action2 = action;
				if (action2 == null)
				{
					return;
				}
				action2();
			});
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0006D153 File Offset: 0x0006B353
		public void UpdateAdventures()
		{
			Debug.Log("UpdateAdventureData");
			AdventureGateway.Instance.GetAllAdventure(delegate(bool result, AllAdventureData data, long time)
			{
				if (result)
				{
					this.CurrentTime = DateTime.UnixEpoch.AddSeconds((double)time);
					this.allData = data;
					this.RearDatas.Clear();
					this.RearDatas = this.allData.AdventureDatas;
					for (int i = 0; i < this.RearDatas.Count; i++)
					{
						AdventureFrontData frontDataById = this.GetFrontDataById(this.RearDatas[i].Id, this.RearDatas[i].RegionId);
						if (frontDataById != null)
						{
							frontDataById.UpdateData(this.RearDatas[i]);
						}
					}
					return;
				}
				Debug.LogError("Error :获取Adventure数据失败！");
			});
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0006D175 File Offset: 0x0006B375
		public void StartAdventure(int id, int regionid, string heroId)
		{
			ZGameCenter.CircleLoading(true, null, false);
			AdventureGateway.Instance.StartAdventure(id, regionid, heroId, delegate(bool result, AdventureRearData data, long time)
			{
				if (result)
				{
					this.CurrentTime = DateTime.UnixEpoch.AddSeconds((double)time);
					this.RearDatas.Add(data);
					AdventureFrontData frontDataById = this.GetFrontDataById(data.Id, data.RegionId);
					if (frontDataById != null)
					{
						frontDataById.UpdateData(data);
						frontDataById.ChangeAdventurePharse(AdventurePharse.Selection);
					}
					else
					{
						Debug.LogError("Error:GetFrontData Failed!");
					}
					SingletonMono<HeroManager>.GetInstance().RefreshData(delegate(bool r1)
					{
						UILeftListPanel panel = UIKit.GetPanel<UILeftListPanel>();
						if (panel == null)
						{
							return;
						}
						panel.RefreshLeftListHero();
					});
				}
				else
				{
					Debug.LogError("Error:开始冒险失败");
				}
				ZGameCenter.CircleLoading(false, null, false);
			});
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0006D198 File Offset: 0x0006B398
		public void SelectChoice(int adventureId, int choiceId, int regionId, Action callback = null)
		{
			ZGameCenter.CircleLoading(true, null, false);
			Action<bool, AdventureRearData, long> <>9__1;
			AdventureGateway.Instance.SelectChoice(adventureId, choiceId, regionId, delegate(bool result, AdventureRearData data, long time)
			{
				if (result)
				{
					AdventureGateway instance = AdventureGateway.Instance;
					int adventureId2 = adventureId;
					int regionId2 = regionId;
					Action<bool, AdventureRearData, long> callback2;
					if ((callback2 = <>9__1) == null)
					{
						callback2 = (<>9__1 = delegate(bool result, AdventureRearData data, long time)
						{
							if (result)
							{
								AdventureRearData rearDataById = this.GetRearDataById(adventureId, data.RegionId);
								AdventureFrontData frontDataById = this.GetFrontDataById(data.Id, data.RegionId);
								frontDataById.UpdateData(data);
								if (frontDataById.DoneStatus == DoneStatus.Complete)
								{
									frontDataById.ChangeAdventurePharse(AdventurePharse.Complete);
								}
								else
								{
									frontDataById.ChangeAdventurePharse(AdventurePharse.ShowResult);
								}
								if (frontDataById.DoneStatus == DoneStatus.Complete || frontDataById.DoneStatus == DoneStatus.GameOver)
								{
									SingletonMono<HeroManager>.GetInstance().RefreshData(delegate(bool r1)
									{
										if (r1)
										{
											UILeftListPanel panel = UIKit.GetPanel<UILeftListPanel>();
											if (panel == null)
											{
												return;
											}
											panel.RefreshLeftListHero();
										}
									});
								}
								Action callback3 = callback;
								if (callback3 != null)
								{
									callback3();
								}
							}
							else
							{
								Debug.LogError("Error:继续失败");
							}
							ZGameCenter.CircleLoading(false, null, false);
						});
					}
					instance.ContinueAdventure(adventureId2, regionId2, callback2);
					return;
				}
				Debug.LogError("Error:选择失败");
				ZGameCenter.CircleLoading(false, null, false);
			});
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0006D1F4 File Offset: 0x0006B3F4
		private AdventureRearData GetRearDataById(int id, int regionId)
		{
			for (int i = 0; i < this.RearDatas.Count; i++)
			{
				if (this.RearDatas[i].Id == id && this.RearDatas[i].RegionId == regionId)
				{
					return this.RearDatas[i];
				}
			}
			Debug.LogError("Error:GetRearData Failed!");
			return null;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0006D258 File Offset: 0x0006B458
		private AdventureFrontData GetFrontDataById(int id, int regionId)
		{
			for (int i = 0; i < this.FrontDatas.Count; i++)
			{
				if (this.FrontDatas[i].Id == id && this.FrontDatas[i].RegionId == regionId)
				{
					return this.FrontDatas[i];
				}
			}
			Debug.LogError("Error:GetFrontData Failed!");
			return null;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0006D2BC File Offset: 0x0006B4BC
		public string GetCostString(List<ItemGroup> Cost)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < Cost.Count; i++)
			{
				stringBuilder.Append(Cost[i].Num);
				stringBuilder.Append(" ");
				stringBuilder.Append(Cost[i].item.Name);
				if (i != Cost.Count - 1)
				{
					stringBuilder.Append(",");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0006D334 File Offset: 0x0006B534
		public bool HaveSameDoingAdventure(int adventureId, int regionId)
		{
			for (int i = 0; i < this.FrontDatas.Count; i++)
			{
				if (this.FrontDatas[i].Id == adventureId && this.FrontDatas[i].RegionId != regionId && (this.FrontDatas[i].DoneStatus == DoneStatus.Progress || this.FrontDatas[i].DoneStatus == DoneStatus.WaitResult))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04001322 RID: 4898
		private AllAdventureData allData;

		// Token: 0x04001323 RID: 4899
		private List<AdventureRearData> RearDatas = new List<AdventureRearData>();

		// Token: 0x04001324 RID: 4900
		private List<AdventureFrontData> FrontDatas = new List<AdventureFrontData>();

		// Token: 0x04001325 RID: 4901
		[ShowInInspector]
		private DateTime currentTime;

		// Token: 0x04001326 RID: 4902
		private float _timer;

		// Token: 0x04001327 RID: 4903
		private bool startCount;
	}
}
