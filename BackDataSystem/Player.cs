using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Game.UI;
using Item;
using Logic;
using Network;
using Newtonsoft.Json;
using TOOLS;
using UnityEngine;
using XLua;
using ZFramework;

namespace BackDataSystem
{
	// Token: 0x02000903 RID: 2307
	[LuaCallCSharp(GenFlag.No)]
	public class Player
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06004FFF RID: 20479 RVA: 0x001B1F04 File Offset: 0x001B0104
		// (remove) Token: 0x06005000 RID: 20480 RVA: 0x001B1F3C File Offset: 0x001B013C
		public event AttributeChange AttributeChangeEvent;

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x001B1F71 File Offset: 0x001B0171
		public Player BackendPlayer
		{
			get
			{
				return this.backendPlayer;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x001B1F79 File Offset: 0x001B0179
		public PlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo;
			}
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x001B1F84 File Offset: 0x001B0184
		public Player(Player _play)
		{
			this.backendPlayer = _play;
			this.playerInfo = new PlayerInfo(_play.Stat);
			this.attributeChangedListeners = new Dictionary<ItemID, List<Action<string>>>();
			this.ID = _play.ID;
			global::Logger.Log(Channel.真机模式, Priority.Error, "player id  " + this.ID);
			this.RegionId = _play.RegionID;
			this.MainHeroId = _play.MainHeroId;
			this.PlayerLifeTime = JsonConvert.DeserializeObject<PlayerLifeTimeClass>(_play.LifeTime.ToString());
			foreach (object obj in Enum.GetValues(typeof(ItemID)))
			{
				ItemID itemID = (ItemID)obj;
				if (itemID != ItemID.None)
				{
					this.attributeChangedListeners.Add(itemID, new List<Action<string>>());
				}
			}
			this.RefreshPlayerInfoToItems(false);
			GlobalEvent.Dispatch(GameEventEnum.RefreshHistoryItem, new object[]
			{
				this.playerInfo
			});
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x001B20A8 File Offset: 0x001B02A8
		public int GetItemNum(ItemID id, bool getCapacity = false)
		{
			if (getCapacity)
			{
				if (this.playerInfo.Item.ContainsKey((int)id))
				{
					return this.playerInfo.Item[(int)id].Capacity;
				}
				return -1;
			}
			else
			{
				if (this.playerInfo.Item.ContainsKey((int)id))
				{
					return int.Parse(this.playerInfo.Item[(int)id].Num.ToString());
				}
				return 0;
			}
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x001B211C File Offset: 0x001B031C
		public void AddTestResource(ItemID id, int num)
		{
			Player.<AddTestResource>d__19 <AddTestResource>d__;
			<AddTestResource>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddTestResource>d__.<>4__this = this;
			<AddTestResource>d__.id = id;
			<AddTestResource>d__.num = num;
			<AddTestResource>d__.<>1__state = -1;
			<AddTestResource>d__.<>t__builder.Start<Player.<AddTestResource>d__19>(ref <AddTestResource>d__);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x001B2164 File Offset: 0x001B0364
		public void RefreshPlayerBackEndData(string playerStat, Transform trans = null)
		{
			if (playerStat != "")
			{
				this.showAddAttributeTrans = trans;
				this.playerInfo.RefreshPlayerInfo(playerStat);
				this.RefreshPlayerInfoToItems(true);
				GlobalEvent.Dispatch(GameEventEnum.RefreshHistoryItem, new object[]
				{
					this.playerInfo
				});
				return;
			}
			Debug.Log("Refresh Player Stat is null");
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x001B21C4 File Offset: 0x001B03C4
		public void RefreshPlayerInfoToItems(bool needShowAddTip = false)
		{
			foreach (object obj in Enum.GetValues(typeof(ItemID)))
			{
				ItemID itemID = (ItemID)obj;
				if (itemID != ItemID.None)
				{
					if (needShowAddTip && itemID != ItemID.LORD && itemID != ItemID.Stamina && itemID != ItemID.Sector)
					{
						int num = int.Parse(this.playerInfo.GetItemNumById(itemID).ToString()) - this.GetAttribute(itemID);
						int itemNum = this.GetItemNum(itemID, true);
						if (num > 0 && this.showAddAttributeTrans != null)
						{
							SingletonMono<ResourceManager>.GetInstance().ShowResTip(this.showAddAttributeTrans, itemID, num, null);
						}
						if (num != 0)
						{
							UIKit.GetPanel<UIStaticPanel>().ShowResourceTip((int)itemID, this.GetAttribute(itemID), num, itemNum);
						}
						if (num > 0 && itemNum != -1 && int.Parse(this.playerInfo.GetItemNumById(itemID).ToString()) > itemNum)
						{
							SingletonMono<MsgMgr>.GetInstance().Show(MsgType.UIMsg_ErrorTip, UILevel.Top, LocalizationText.GetText(472), string.Format(LocalizationText.GetText(473), SingletonScriptableObject<ItemManager>.Instance.GetTemplateByItemID(itemID).Name), null, null, null);
						}
						if (num > 0)
						{
							GlobalEvent.Dispatch(GlobalEventEnum.MissionSeason, new object[]
							{
								MissionCondition.ClaimResource,
								itemID,
								num
							});
						}
						if (num < 0)
						{
							GlobalEvent.Dispatch(GlobalEventEnum.MissionSeason, new object[]
							{
								MissionCondition.CostResource,
								itemID,
								Mathf.Abs(num)
							});
						}
					}
					this.SetAttribute(itemID, Attributes<ItemID>.SetOrAdd.Set, this.playerInfo.GetItemNumById(itemID));
				}
			}
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x001B239C File Offset: 0x001B059C
		public void AddAttributeChangedListener(ItemID id, Action<string> listener)
		{
			this.attributeChangedListeners[id].Add(listener);
			if (id == ItemID.LORD)
			{
				listener(Mathf.FloorToInt((float)this.GetAttributeDouble(id)).ToString());
				return;
			}
			listener(this.GetAttribute(id).ToString());
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x001B23F4 File Offset: 0x001B05F4
		public void SetAttribute(ItemID id, Attributes<ItemID>.SetOrAdd setOrAdd, object value)
		{
			if (setOrAdd == Attributes<ItemID>.SetOrAdd.Add)
			{
				int num = this.JudgeCapacity(id, value);
				if (num > 0)
				{
					this.attributes.SetAttribute(id, Attributes<ItemID>.SetOrAdd.Set, num);
				}
				else
				{
					this.attributes.SetAttribute(id, setOrAdd, value);
				}
			}
			else
			{
				this.attributes.SetAttribute(id, setOrAdd, value);
			}
			this.Invoke(id);
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x001B244C File Offset: 0x001B064C
		public Task SetItemNumSendToBackend(ItemID id, int itemNum)
		{
			Player.<SetItemNumSendToBackend>d__24 <SetItemNumSendToBackend>d__;
			<SetItemNumSendToBackend>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetItemNumSendToBackend>d__.id = id;
			<SetItemNumSendToBackend>d__.itemNum = itemNum;
			<SetItemNumSendToBackend>d__.<>1__state = -1;
			<SetItemNumSendToBackend>d__.<>t__builder.Start<Player.<SetItemNumSendToBackend>d__24>(ref <SetItemNumSendToBackend>d__);
			return <SetItemNumSendToBackend>d__.<>t__builder.Task;
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x001B2497 File Offset: 0x001B0697
		public int GetAttribute(ItemID id)
		{
			return this.attributes.GetAttribute(id);
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x001B24A5 File Offset: 0x001B06A5
		public double GetAttributeDouble(ItemID id)
		{
			return this.attributes.GetAttributeDouble(id);
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x001B24B4 File Offset: 0x001B06B4
		private void Invoke(ItemID id)
		{
			List<Action<string>> list = this.attributeChangedListeners[id];
			if (list.Count > 0)
			{
				string obj;
				if (id == ItemID.LORD)
				{
					obj = Mathf.FloorToInt((float)this.GetAttributeDouble(id)).ToString();
				}
				else
				{
					obj = this.GetAttribute(id).ToString();
				}
				foreach (Action<string> action in list)
				{
					action(obj);
				}
			}
			AttributeChange attributeChangeEvent = this.AttributeChangeEvent;
			if (attributeChangeEvent == null)
			{
				return;
			}
			attributeChangeEvent();
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x001B255C File Offset: 0x001B075C
		public void InvokeAllUIAttribute()
		{
			foreach (object obj in Enum.GetValues(typeof(ItemID)))
			{
				ItemID itemID = (ItemID)obj;
				if (itemID != ItemID.None)
				{
					List<Action<string>> list = this.attributeChangedListeners[itemID];
					if (list.Count > 0)
					{
						string obj2;
						if (itemID == ItemID.LORD)
						{
							obj2 = Mathf.FloorToInt((float)this.GetAttributeDouble(itemID)).ToString();
						}
						else
						{
							obj2 = this.GetAttribute(itemID).ToString();
						}
						foreach (Action<string> action in list)
						{
							action(obj2);
						}
					}
				}
			}
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x001B2650 File Offset: 0x001B0850
		private int JudgeCapacity(ItemID id, object value)
		{
			if (id == ItemID.LORD)
			{
				return -1;
			}
			int num = this.GetAttribute(id);
			int num2 = -1;
			if (this.playerInfo.Item.ContainsKey((int)id))
			{
				num2 = this.playerInfo.Item[(int)id].Capacity;
			}
			if (num2 == -1)
			{
				return -1;
			}
			num += int.Parse(value.ToString());
			if (num > num2)
			{
				return num2;
			}
			return -1;
		}

		// Token: 0x04003004 RID: 12292
		public string ID;

		// Token: 0x04003005 RID: 12293
		public Character MainCharacter;

		// Token: 0x04003006 RID: 12294
		private Dictionary<ItemID, List<Action<string>>> attributeChangedListeners;

		// Token: 0x04003007 RID: 12295
		private Attributes<ItemID> attributes = new Attributes<ItemID>();

		// Token: 0x04003008 RID: 12296
		private Transform showAddAttributeTrans;

		// Token: 0x0400300A RID: 12298
		private Player backendPlayer;

		// Token: 0x0400300B RID: 12299
		private PlayerInfo playerInfo;

		// Token: 0x0400300C RID: 12300
		public int RegionId;

		// Token: 0x0400300D RID: 12301
		public string MainHeroId;

		// Token: 0x0400300E RID: 12302
		public PlayerLifeTimeClass PlayerLifeTime = new PlayerLifeTimeClass();
	}
}
