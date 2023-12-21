using System;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000681 RID: 1665
	public static class BlockchainMsgReflection
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x0016EC8E File Offset: 0x0016CE8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.descriptor;
			}
		}

		// Token: 0x0400225A RID: 8794
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNCbG9ja2NoYWluTXNnLnByb3RvEgpibG9ja2NoYWluIjIKEEMyU19HZXRC",
			"YWxhbmNlT2YSDQoFdG9rZW4YASABKAkSDwoHbmV0d29yaxgCIAEoCSJTChBT",
			"MkNfR2V0QmFsYW5jZU9mEg0KBXRva2VuGAEgASgJEg8KB25ldHdvcmsYAiAB",
			"KAkSDAoETE9SRBgDIAEoCRIRCgliYWxhbmNlT2YYBCABKAkiNwoVQzJTX0dl",
			"dERlcG9zaXRBZGRyZXNzEg0KBXRva2VuGAEgASgJEg8KB25ldHdvcmsYAiAB",
			"KAkiTwoVUzJDX0dldERlcG9zaXRBZGRyZXNzEg0KBXRva2VuGAEgASgJEg8K",
			"B25ldHdvcmsYAiABKAkSFgoOZGVwb3NpdEFkZHJlc3MYAyABKAkiZwoSUzJD",
			"X05vdGljZVJlY2hhcmdlEg0KBXRva2VuGAEgASgJEg8KB25ldHdvcmsYAiAB",
			"KAkSDwoHYWRkcmVzcxgDIAEoCRISCgphZGRpdGlvbmFsGAQgASgJEgwKBExP",
			"UkQYBSABKAkikQEKDEMyU19XaXRoZHJhdxINCgV0b2tlbhgBIAEoCRIPCgdu",
			"ZXR3b3JrGAIgASgJEg8KB2FkZHJlc3MYAyABKAkSFgoOd2l0aGRyYXdBbW91",
			"bnQYBCABKAESHQoVZW1haWxWZXJpZmljYXRpb25Db2RlGAUgASgJEhkKEWF1",
			"dGhlbnRpY2F0b3JDb2RlGAYgASgJIhoKDFMyQ19XaXRoZHJhdxIKCgJJRBgB",
			"IAEoCSJ0ChJTMkNfTm90aWNlV2l0aGRyYXcSDQoFdG9rZW4YASABKAkSDwoH",
			"bmV0d29yaxgCIAEoCRIPCgdhZGRyZXNzGAMgASgJEhYKDndpdGhkcmF3QW1v",
			"dW50GAQgASgJEhUKDXJlY2VpdmVBbW91bnQYBSABKAkiEgoQQzJTX0dldEVt",
			"YWlsQ29kZSISChBTMkNfR2V0RW1haWxDb2RlIhYKFEMyU19HZXREYWlseVdp",
			"dGhkcmF3IjIKFFMyQ19HZXREYWlseVdpdGhkcmF3EhoKEmRhaWx5V2l0aGRy",
			"YXdMT1JEUxgBIAEoCSInChRTMkNfTm90aWNlSW1wb3J0SGVybxIPCgdUb2tl",
			"bklkGAEgASgJIhMKEUMyU19HZXRDb25maWdJbmZvImEKEVMyQ19HZXRDb25m",
			"aWdJbmZvEhcKD0hlcm9CYW5rQWRkcmVzcxgBIAEoCRIVCg1XYWxsZXRBZGRy",
			"ZXNzGAIgASgJEhwKFFBvbHlnb25XYWxsZXRBZGRyZXNzGAMgASgJKuMBCgNN",
			"U0cSCAoETm9uZRAAEhQKDV9HZXRCYWxhbmNlT2YQho7OHBIZChJfR2V0RGVw",
			"b3NpdEFkZHJlc3MQh47OHBIWCg9fTm90aWNlUmVjaGFyZ2UQiY7OHBIQCglf",
			"V2l0aGRyYXcQio7OHBIWCg9fTm90aWNlV2l0aGRyYXcQi47OHBIUCg1fR2V0",
			"RW1haWxDb2RlEIyOzhwSGAoRX0dldERhaWx5V2l0aGRyYXcQjY7OHBIYChFf",
			"Tm90aWNlSW1wb3J0SGVybxCOjs4cEhUKDl9HZXRDb25maWdJbmZvEI+OzhxC",
			"DloMLi9ibG9ja2NoYWluYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(MSG)
		}, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(C2S_GetBalanceOf), C2S_GetBalanceOf.Parser, new string[]
			{
				"Token",
				"Network"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_GetBalanceOf), S2C_GetBalanceOf.Parser, new string[]
			{
				"Token",
				"Network",
				"LORD",
				"BalanceOf"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(C2S_GetDepositAddress), C2S_GetDepositAddress.Parser, new string[]
			{
				"Token",
				"Network"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_GetDepositAddress), S2C_GetDepositAddress.Parser, new string[]
			{
				"Token",
				"Network",
				"DepositAddress"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_NoticeRecharge), S2C_NoticeRecharge.Parser, new string[]
			{
				"Token",
				"Network",
				"Address",
				"Additional",
				"LORD"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(C2S_Withdraw), C2S_Withdraw.Parser, new string[]
			{
				"Token",
				"Network",
				"Address",
				"WithdrawAmount",
				"EmailVerificationCode",
				"AuthenticatorCode"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_Withdraw), S2C_Withdraw.Parser, new string[]
			{
				"ID"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_NoticeWithdraw), S2C_NoticeWithdraw.Parser, new string[]
			{
				"Token",
				"Network",
				"Address",
				"WithdrawAmount",
				"ReceiveAmount"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(C2S_GetEmailCode), C2S_GetEmailCode.Parser, null, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_GetEmailCode), S2C_GetEmailCode.Parser, null, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(C2S_GetDailyWithdraw), C2S_GetDailyWithdraw.Parser, null, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_GetDailyWithdraw), S2C_GetDailyWithdraw.Parser, new string[]
			{
				"DailyWithdrawLORDS"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_NoticeImportHero), S2C_NoticeImportHero.Parser, new string[]
			{
				"TokenId"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(C2S_GetConfigInfo), C2S_GetConfigInfo.Parser, null, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(S2C_GetConfigInfo), S2C_GetConfigInfo.Parser, new string[]
			{
				"HeroBankAddress",
				"WalletAddress",
				"PolygonWalletAddress"
			}, null, null, null, null)
		}));
	}
}
