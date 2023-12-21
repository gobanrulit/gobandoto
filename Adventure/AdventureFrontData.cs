using System;
using System.Collections.Generic;
using Game.Core;
using Game.UI;
using Network;
using Squads;
using TOOLS;
using UnityEngine;
using ZFramework;

namespace Adventure
{
	// Token: 0x02000337 RID: 823
	public class AdventureFrontData
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0006CA07 File Offset: 0x0006AC07
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0006CA0F File Offset: 0x0006AC0F
		public HeroData CurHero
		{
			get
			{
				return this.curHero;
			}
			set
			{
				this.curHero = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0006CA18 File Offset: 0x0006AC18
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0006CA20 File Offset: 0x0006AC20
		public AdventureTemplate CurAdventure
		{
			get
			{
				return this.curAdventure;
			}
			set
			{
				this.curAdventure = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0006CA29 File Offset: 0x0006AC29
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0006CA31 File Offset: 0x0006AC31
		public AdventureScene CurScene
		{
			get
			{
				return this.curScene;
			}
			set
			{
				this.curScene = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0006CA3A File Offset: 0x0006AC3A
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0006CA42 File Offset: 0x0006AC42
		public SceneChoice CurChoice
		{
			get
			{
				return this.curChoice;
			}
			set
			{
				this.curChoice = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0006CA4B File Offset: 0x0006AC4B
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0006CA53 File Offset: 0x0006AC53
		public AdventureInitial Stat
		{
			get
			{
				return this.stat;
			}
			set
			{
				this.stat = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0006CA5C File Offset: 0x0006AC5C
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0006CA64 File Offset: 0x0006AC64
		public SpecificResult CurResult
		{
			get
			{
				return this.curResult;
			}
			set
			{
				this.curResult = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0006CA6D File Offset: 0x0006AC6D
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0006CA75 File Offset: 0x0006AC75
		public HeroData TempHero
		{
			get
			{
				return this.tempHero;
			}
			set
			{
				this.tempHero = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0006CA7E File Offset: 0x0006AC7E
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0006CA86 File Offset: 0x0006AC86
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0006CA8F File Offset: 0x0006AC8F
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0006CA97 File Offset: 0x0006AC97
		public int Attempts
		{
			get
			{
				return this.attempts;
			}
			set
			{
				this.attempts = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0006CAA0 File Offset: 0x0006ACA0
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0006CAA8 File Offset: 0x0006ACA8
		public MiniAdventurePharse CurMiniPharse
		{
			get
			{
				return this.curMiniPharse;
			}
			set
			{
				this.curMiniPharse = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0006CAB1 File Offset: 0x0006ACB1
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0006CAB9 File Offset: 0x0006ACB9
		public Dictionary<int, int> ChoiceGroup
		{
			get
			{
				return this.choiceGroup;
			}
			set
			{
				this.choiceGroup = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0006CAC2 File Offset: 0x0006ACC2
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0006CACA File Offset: 0x0006ACCA
		public DoneStatus DoneStatus
		{
			get
			{
				return this.doneStatus;
			}
			set
			{
				this.doneStatus = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0006CAD3 File Offset: 0x0006ACD3
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0006CADB File Offset: 0x0006ACDB
		public int TodayDoneTimes
		{
			get
			{
				return this.todayDoneTimes;
			}
			set
			{
				this.todayDoneTimes = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0006CAE4 File Offset: 0x0006ACE4
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0006CAEC File Offset: 0x0006ACEC
		public List<string> HeroIdList
		{
			get
			{
				return this.heroIdList;
			}
			set
			{
				this.heroIdList = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0006CAF5 File Offset: 0x0006ACF5
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0006CAFD File Offset: 0x0006ACFD
		public int RegionId
		{
			get
			{
				return this.regionId;
			}
			set
			{
				this.regionId = value;
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0006CB06 File Offset: 0x0006AD06
		public AdventureFrontData()
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0006CB24 File Offset: 0x0006AD24
		public AdventureFrontData(int id, int regionid)
		{
			this.CurAdventure = SingletonScriptableObject<AdventureTemplateManager>.Instance.GetAdventureData(id);
			this.Id = this.curAdventure._id;
			this.RegionId = regionid;
			this.CurScene = this.CurAdventure.GetStartScene();
			this.Stat = this.CurAdventure.Init;
			this.CurMiniPharse = MiniAdventurePharse.New;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0006CBA0 File Offset: 0x0006ADA0
		public void UpdateData(AdventureRearData data)
		{
			this.Id = data.Id;
			this.RegionId = data.RegionId;
			if (data.HeroId != string.Empty && (data.DoneStatus != DoneStatus.Complete || data.DoneStatus != DoneStatus.GameOver))
			{
				this.CurHero = SingletonMono<HeroManager>.GetInstance().GetHeroByID(data.HeroId);
			}
			this.CurAdventure = SingletonScriptableObject<AdventureTemplateManager>.Instance.GetAdventureData(data.Id);
			this.stat = data.AdventureProperty;
			this.LastSceneId = data.PrevSceneId;
			switch (data.DoneStatus)
			{
			case DoneStatus.Progress:
				this.CurScene = this.CurAdventure.GetScene(data.CurrentSceneId);
				this.NextSceneTime = DateTime.UnixEpoch.AddSeconds((double)data.ChoiceTime).AddMinutes((double)this.CurAdventure.GetScene(data.CurrentSceneId).CoolDownTime);
				if (data.ChoiceGroup.TryGetValue(data.PrevSceneId, out this.LastChoice))
				{
					Debug.Log("GetChoiceDataSuccess!");
					this.CurChoice = this.curAdventure.GetScene(data.PrevSceneId).GetChoice(this.LastChoice.ChoiceId);
					this.CurResult = this.CurChoice.Result.GetResult(this.LastChoice.ResultIndex);
				}
				break;
			case DoneStatus.WaitResult:
				this.CurScene = this.CurAdventure.GetScene(data.CurrentSceneId);
				if (data.ChoiceGroup.TryGetValue(data.CurrentSceneId, out this.LastChoice))
				{
					Debug.Log("GetChoiceDataSuccess!");
					this.CurChoice = this.CurScene.GetChoice(this.LastChoice.ChoiceId);
					this.CurResult = this.CurChoice.Result.GetResult(this.LastChoice.ResultIndex);
				}
				this.CanShowResultTime = DateTime.UnixEpoch.AddSeconds((double)data.ChoiceTime).AddMinutes((double)this.CurChoice.CoolDownTime);
				break;
			case DoneStatus.Complete:
			case DoneStatus.GameOver:
				if (data.ChoiceGroup.TryGetValue(data.PrevSceneId, out this.LastChoice))
				{
					Debug.Log("GetChoiceDataSuccess!");
					this.CurChoice = this.curAdventure.GetScene(data.PrevSceneId).GetChoice(this.LastChoice.ChoiceId);
					this.CurResult = this.CurChoice.Result.GetResult(this.LastChoice.ResultIndex);
				}
				break;
			}
			switch (data.DoneStatus)
			{
			case DoneStatus.UnStart:
				this.CurMiniPharse = MiniAdventurePharse.New;
				break;
			case DoneStatus.Progress:
				if (this.NextSceneTime > SingletonMono<AdventureManager>.GetInstance().CurrentTime)
				{
					this.CurMiniPharse = MiniAdventurePharse.WaitNext;
				}
				else
				{
					this.CurMiniPharse = MiniAdventurePharse.WaitSelect;
				}
				break;
			case DoneStatus.Complete:
			case DoneStatus.GameOver:
				this.CurMiniPharse = MiniAdventurePharse.WaitStart;
				break;
			}
			this.Attempts = 0;
			foreach (KeyValuePair<long, bool> keyValuePair in data.BuyAttempsRecord)
			{
				this.Attempts++;
			}
			this.DoneStatus = data.DoneStatus;
			this.ChoiceGroup.Clear();
			foreach (KeyValuePair<int, AdventureChoiceData> keyValuePair2 in data.ChoiceGroup)
			{
				this.ChoiceGroup.Add(keyValuePair2.Key, keyValuePair2.Value.ChoiceId);
			}
			this.HeroIdList.Clear();
			this.TodayDoneTimes = 0;
			for (int i = 0; i < data.Historys.Count; i++)
			{
				this.TodayDoneTimes++;
				if (data.Historys[i].DoneStatus == 1)
				{
					ChoiceType type = this.CurAdventure.Type;
					if (type != ChoiceType.Normal)
					{
						if (type == ChoiceType.Special)
						{
							this.HeroIdList.Add(data.Historys[i].HeroId);
						}
					}
					else
					{
						this.HeroIdList.Add(data.Historys[i].HeroId);
					}
				}
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0006CFF0 File Offset: 0x0006B1F0
		public void ChangeAdventurePharse(AdventurePharse pharse)
		{
			UILevel canvasLevel = UILevel.PopUI;
			if (SingletonMono<ProcedureMgr>.GetInstance().CurrentProcedure == GameProcedure.SelectRegion || SingletonMono<ProcedureMgr>.GetInstance().CurrentProcedure == GameProcedure.ViewRegion)
			{
				canvasLevel = UILevel.UpperPopUI;
			}
			else if (SingletonMono<ProcedureMgr>.GetInstance().CurrentProcedure == GameProcedure.Game)
			{
				canvasLevel = UILevel.PopUI;
			}
			if (pharse != AdventurePharse.Complete)
			{
				UIKit.OpenPanel<UIAdventurePanel>(canvasLevel, true, true, null, null, null).Show(this, pharse);
				return;
			}
			UIKit.ClosePanel<UIAdventurePanel>();
			UIKit.OpenPanel<UIAdventureResultPanel>(canvasLevel, true, true, null, null, null).Show(this);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0006D066 File Offset: 0x0006B266
		public void ChangeMiniAdventurePharse(MiniAdventurePharse pharse)
		{
			this.CurMiniPharse = pharse;
			UIKit.OpenPanel<UIAdventureRightBarPanel>(UILevel.Static, true, true, null, null, null).AddMiniAdventure(this, pharse);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0006D085 File Offset: 0x0006B285
		public bool IsEndScene()
		{
			return this.CurScene.Type == SceneType.End && this.LastSceneId == this.CurScene.Id;
		}

		// Token: 0x0400130F RID: 4879
		private int id;

		// Token: 0x04001310 RID: 4880
		private int regionId;

		// Token: 0x04001311 RID: 4881
		private MiniAdventurePharse curMiniPharse;

		// Token: 0x04001312 RID: 4882
		private HeroData curHero;

		// Token: 0x04001313 RID: 4883
		private AdventureTemplate curAdventure;

		// Token: 0x04001314 RID: 4884
		private AdventureScene curScene;

		// Token: 0x04001315 RID: 4885
		private SceneChoice curChoice;

		// Token: 0x04001316 RID: 4886
		private SpecificResult curResult;

		// Token: 0x04001317 RID: 4887
		private AdventureInitial stat;

		// Token: 0x04001318 RID: 4888
		private int attempts;

		// Token: 0x04001319 RID: 4889
		private HeroData tempHero;

		// Token: 0x0400131A RID: 4890
		private DoneStatus doneStatus;

		// Token: 0x0400131B RID: 4891
		private int todayDoneTimes;

		// Token: 0x0400131C RID: 4892
		private Dictionary<int, int> choiceGroup = new Dictionary<int, int>();

		// Token: 0x0400131D RID: 4893
		private List<string> heroIdList = new List<string>();

		// Token: 0x0400131E RID: 4894
		public DateTime NextSceneTime;

		// Token: 0x0400131F RID: 4895
		public DateTime CanShowResultTime;

		// Token: 0x04001320 RID: 4896
		public int LastSceneId;

		// Token: 0x04001321 RID: 4897
		public AdventureChoiceData LastChoice;
	}
}
