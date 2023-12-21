using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068A RID: 1674
	public sealed class S2C_NoticeWithdraw : IMessage<S2C_NoticeWithdraw>, IMessage, IEquatable<S2C_NoticeWithdraw>, IDeepCloneable<S2C_NoticeWithdraw>, IBufferMessage
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x00170DAE File Offset: 0x0016EFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_NoticeWithdraw> Parser
		{
			get
			{
				return S2C_NoticeWithdraw._parser;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x00170DB5 File Offset: 0x0016EFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060043DC RID: 17372 RVA: 0x00170DC7 File Offset: 0x0016EFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_NoticeWithdraw.Descriptor;
			}
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00170DCE File Offset: 0x0016EFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeWithdraw()
		{
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00170E10 File Offset: 0x0016F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeWithdraw(S2C_NoticeWithdraw other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this.address_ = other.address_;
			this.withdrawAmount_ = other.withdrawAmount_;
			this.receiveAmount_ = other.receiveAmount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00170E70 File Offset: 0x0016F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeWithdraw Clone()
		{
			return new S2C_NoticeWithdraw(this);
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00170E78 File Offset: 0x0016F078
		// (set) Token: 0x060043E1 RID: 17377 RVA: 0x00170E80 File Offset: 0x0016F080
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

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060043E2 RID: 17378 RVA: 0x00170E93 File Offset: 0x0016F093
		// (set) Token: 0x060043E3 RID: 17379 RVA: 0x00170E9B File Offset: 0x0016F09B
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

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x00170EAE File Offset: 0x0016F0AE
		// (set) Token: 0x060043E5 RID: 17381 RVA: 0x00170EB6 File Offset: 0x0016F0B6
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

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x00170EC9 File Offset: 0x0016F0C9
		// (set) Token: 0x060043E7 RID: 17383 RVA: 0x00170ED1 File Offset: 0x0016F0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string WithdrawAmount
		{
			get
			{
				return this.withdrawAmount_;
			}
			set
			{
				this.withdrawAmount_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x00170EE4 File Offset: 0x0016F0E4
		// (set) Token: 0x060043E9 RID: 17385 RVA: 0x00170EEC File Offset: 0x0016F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReceiveAmount
		{
			get
			{
				return this.receiveAmount_;
			}
			set
			{
				this.receiveAmount_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x00170EFF File Offset: 0x0016F0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_NoticeWithdraw);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00170F10 File Offset: 0x0016F110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_NoticeWithdraw other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && !(this.Address != other.Address) && !(this.WithdrawAmount != other.WithdrawAmount) && !(this.ReceiveAmount != other.ReceiveAmount) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00170FA4 File Offset: 0x0016F1A4
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
			if (this.WithdrawAmount.Length != 0)
			{
				num ^= this.WithdrawAmount.GetHashCode();
			}
			if (this.ReceiveAmount.Length != 0)
			{
				num ^= this.ReceiveAmount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00171051 File Offset: 0x0016F251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00171059 File Offset: 0x0016F259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00171064 File Offset: 0x0016F264
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
			if (this.WithdrawAmount.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.WithdrawAmount);
			}
			if (this.ReceiveAmount.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ReceiveAmount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x0017112C File Offset: 0x0016F32C
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
			if (this.WithdrawAmount.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.WithdrawAmount);
			}
			if (this.ReceiveAmount.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReceiveAmount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x001711E4 File Offset: 0x0016F3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_NoticeWithdraw other)
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
			if (other.WithdrawAmount.Length != 0)
			{
				this.WithdrawAmount = other.WithdrawAmount;
			}
			if (other.ReceiveAmount.Length != 0)
			{
				this.ReceiveAmount = other.ReceiveAmount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00171289 File Offset: 0x0016F489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00171294 File Offset: 0x0016F494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
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
				}
				else
				{
					if (num == 26U)
					{
						this.Address = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.WithdrawAmount = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.ReceiveAmount = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022A2 RID: 8866
		private static readonly MessageParser<S2C_NoticeWithdraw> _parser = new MessageParser<S2C_NoticeWithdraw>(() => new S2C_NoticeWithdraw());

		// Token: 0x040022A3 RID: 8867
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A4 RID: 8868
		public const int TokenFieldNumber = 1;

		// Token: 0x040022A5 RID: 8869
		private string token_ = "";

		// Token: 0x040022A6 RID: 8870
		public const int NetworkFieldNumber = 2;

		// Token: 0x040022A7 RID: 8871
		private string network_ = "";

		// Token: 0x040022A8 RID: 8872
		public const int AddressFieldNumber = 3;

		// Token: 0x040022A9 RID: 8873
		private string address_ = "";

		// Token: 0x040022AA RID: 8874
		public const int WithdrawAmountFieldNumber = 4;

		// Token: 0x040022AB RID: 8875
		private string withdrawAmount_ = "";

		// Token: 0x040022AC RID: 8876
		public const int ReceiveAmountFieldNumber = 5;

		// Token: 0x040022AD RID: 8877
		private string receiveAmount_ = "";
	}
}
