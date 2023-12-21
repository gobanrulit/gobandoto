using System;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000682 RID: 1666
	public enum MSG
	{
		// Token: 0x0400225C RID: 8796
		[OriginalName("None")]
		None,
		// Token: 0x0400225D RID: 8797
		[OriginalName("_GetBalanceOf")]
		GetBalanceOf = 60000006,
		// Token: 0x0400225E RID: 8798
		[OriginalName("_GetDepositAddress")]
		GetDepositAddress,
		// Token: 0x0400225F RID: 8799
		[OriginalName("_NoticeRecharge")]
		NoticeRecharge = 60000009,
		// Token: 0x04002260 RID: 8800
		[OriginalName("_Withdraw")]
		Withdraw,
		// Token: 0x04002261 RID: 8801
		[OriginalName("_NoticeWithdraw")]
		NoticeWithdraw,
		// Token: 0x04002262 RID: 8802
		[OriginalName("_GetEmailCode")]
		GetEmailCode,
		// Token: 0x04002263 RID: 8803
		[OriginalName("_GetDailyWithdraw")]
		GetDailyWithdraw,
		// Token: 0x04002264 RID: 8804
		[OriginalName("_NoticeImportHero")]
		NoticeImportHero,
		// Token: 0x04002265 RID: 8805
		[OriginalName("_GetConfigInfo")]
		GetConfigInfo
	}
}
