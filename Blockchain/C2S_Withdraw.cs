using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000688 RID: 1672
	public sealed class C2S_Withdraw : IMessage<C2S_Withdraw>, IMessage, IEquatable<C2S_Withdraw>, IDeepCloneable<C2S_Withdraw>, IBufferMessage
	{
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x0017052C File Offset: 0x0016E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_Withdraw> Parser
		{
			get
			{
				return C2S_Withdraw._parser;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x00170533 File Offset: 0x0016E733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x00170545 File Offset: 0x0016E745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_Withdraw.Descriptor;
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0017054C File Offset: 0x0016E74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_Withdraw()
		{
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0017058C File Offset: 0x0016E78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_Withdraw(C2S_Withdraw other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this.address_ = other.address_;
			this.withdrawAmount_ = other.withdrawAmount_;
			this.emailVerificationCode_ = other.emailVerificationCode_;
			this.authenticatorCode_ = other.authenticatorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x001705F8 File Offset: 0x0016E7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_Withdraw Clone()
		{
			return new C2S_Withdraw(this);
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x00170600 File Offset: 0x0016E800
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x00170608 File Offset: 0x0016E808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
		{
			get
			{
				return this.token_;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x0017061B File Offset: 0x0016E81B
		// (set) Token: 0x060043B3 RID: 17331 RVA: 0x00170623 File Offset: 0x0016E823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Network
		{
			get
			{
				return this.network_;
			}
			set
			{
				this.network_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x00170636 File Offset: 0x0016E836
		// (set) Token: 0x060043B5 RID: 17333 RVA: 0x0017063E File Offset: 0x0016E83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Address
		{
			get
			{
				return this.address_;
			}
			set
			{
				this.address_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x00170651 File Offset: 0x0016E851
		// (set) Token: 0x060043B7 RID: 17335 RVA: 0x00170659 File Offset: 0x0016E859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double WithdrawAmount
		{
			get
			{
				return this.withdrawAmount_;
			}
			set
			{
				this.withdrawAmount_ = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x00170662 File Offset: 0x0016E862
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x0017066A File Offset: 0x0016E86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EmailVerificationCode
		{
			get
			{
				return this.emailVerificationCode_;
			}
			set
			{
				this.emailVerificationCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x0017067D File Offset: 0x0016E87D
		// (set) Token: 0x060043BB RID: 17339 RVA: 0x00170685 File Offset: 0x0016E885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AuthenticatorCode
		{
			get
			{
				return this.authenticatorCode_;
			}
			set
			{
				this.authenticatorCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00170698 File Offset: 0x0016E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_Withdraw);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x001706A8 File Offset: 0x0016E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_Withdraw other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && !(this.Address != other.Address) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.WithdrawAmount, other.WithdrawAmount) && !(this.EmailVerificationCode != other.EmailVerificationCode) && !(this.AuthenticatorCode != other.AuthenticatorCode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00170754 File Offset: 0x0016E954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Token.Length != 0)
			{
				num ^= this.Token.GetHashCode();
			}
			if (this.Network.Length != 0)
			{
				num ^= this.Network.GetHashCode();
			}
			if (this.Address.Length != 0)
			{
				num ^= this.Address.GetHashCode();
			}
			if (this.WithdrawAmount != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.WithdrawAmount);
			}
			if (this.EmailVerificationCode.Length != 0)
			{
				num ^= this.EmailVerificationCode.GetHashCode();
			}
			if (this.AuthenticatorCode.Length != 0)
			{
				num ^= this.AuthenticatorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00170825 File Offset: 0x0016EA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x0017082D File Offset: 0x0016EA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00170838 File Offset: 0x0016EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Token.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Token);
			}
			if (this.Network.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Network);
			}
			if (this.Address.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Address);
			}
			if (this.WithdrawAmount != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.WithdrawAmount);
			}
			if (this.EmailVerificationCode.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.EmailVerificationCode);
			}
			if (this.AuthenticatorCode.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.AuthenticatorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00170924 File Offset: 0x0016EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Token.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			if (this.Network.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Network);
			}
			if (this.Address.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Address);
			}
			if (this.WithdrawAmount != 0.0)
			{
				num += 9;
			}
			if (this.EmailVerificationCode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EmailVerificationCode);
			}
			if (this.AuthenticatorCode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AuthenticatorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x001709F4 File Offset: 0x0016EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_Withdraw other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Token.Length != 0)
			{
				this.Token = other.Token;
			}
			if (other.Network.Length != 0)
			{
				this.Network = other.Network;
			}
			if (other.Address.Length != 0)
			{
				this.Address = other.Address;
			}
			if (other.WithdrawAmount != 0.0)
			{
				this.WithdrawAmount = other.WithdrawAmount;
			}
			if (other.EmailVerificationCode.Length != 0)
			{
				this.EmailVerificationCode = other.EmailVerificationCode;
			}
			if (other.AuthenticatorCode.Length != 0)
			{
				this.AuthenticatorCode = other.AuthenticatorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00170AB6 File Offset: 0x0016ECB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00170AC0 File Offset: 0x0016ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.Token = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.Network = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.Address = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 33U)
					{
						this.WithdrawAmount = input.ReadDouble();
						continue;
					}
					if (num == 42U)
					{
						this.EmailVerificationCode = input.ReadString();
						continue;
					}
					if (num == 50U)
					{
						this.AuthenticatorCode = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002290 RID: 8848
		private static readonly MessageParser<C2S_Withdraw> _parser = new MessageParser<C2S_Withdraw>(() => new C2S_Withdraw());

		// Token: 0x04002291 RID: 8849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002292 RID: 8850
		public const int TokenFieldNumber = 1;

		// Token: 0x04002293 RID: 8851
		private string token_ = "";

		// Token: 0x04002294 RID: 8852
		public const int NetworkFieldNumber = 2;

		// Token: 0x04002295 RID: 8853
		private string network_ = "";

		// Token: 0x04002296 RID: 8854
		public const int AddressFieldNumber = 3;

		// Token: 0x04002297 RID: 8855
		private string address_ = "";

		// Token: 0x04002298 RID: 8856
		public const int WithdrawAmountFieldNumber = 4;

		// Token: 0x04002299 RID: 8857
		private double withdrawAmount_;

		// Token: 0x0400229A RID: 8858
		public const int EmailVerificationCodeFieldNumber = 5;

		// Token: 0x0400229B RID: 8859
		private string emailVerificationCode_ = "";

		// Token: 0x0400229C RID: 8860
		public const int AuthenticatorCodeFieldNumber = 6;

		// Token: 0x0400229D RID: 8861
		private string authenticatorCode_ = "";
	}
}
