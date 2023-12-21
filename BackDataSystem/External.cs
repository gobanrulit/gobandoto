using System;
using UnityEngine;
using XLua;

namespace BackDataSystem
{
	// Token: 0x02000901 RID: 2305
	[LuaCallCSharp(GenFlag.No)]
	public class External
	{
		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x001B1E97 File Offset: 0x001B0097
		public static Character PlayerCharacter
		{
			get
			{
				return External.Player.MainCharacter;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x001B1EA3 File Offset: 0x001B00A3
		// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x001B1EBC File Offset: 0x001B00BC
		public static Player Player
		{
			get
			{
				if (External.player == null)
				{
					External.player = new Player(null);
				}
				return External.player;
			}
			set
			{
				if (External.player != null)
				{
					Debug.LogError("Player has already been creating");
				}
				External.player = value;
			}
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x001B1ED5 File Offset: 0x001B00D5
		public static DateTime CurrentTime()
		{
			return DateTime.UtcNow + TimeSpan.FromDays((double)External.extraDays);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x001B1EEC File Offset: 0x001B00EC
		public static void AdvanceTime()
		{
			External.extraDays++;
		}

		// Token: 0x04003002 RID: 12290
		private static int extraDays;

		// Token: 0x04003003 RID: 12291
		private static Player player;
	}
}
