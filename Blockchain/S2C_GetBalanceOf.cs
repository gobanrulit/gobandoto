using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000684 RID: 1668
	public sealed class S2C_GetBalanceOf : IMessage<S2C_GetBalanceOf>, IMessage, IEquatable<S2C_GetBalanceOf>, IDeepCloneable<S2C_GetBalanceOf>, IBufferMessage
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x0016F3D9 File Offset: 0x0016D5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_GetBalanceOf> Parser
		{
			get
			{
				return S2C_GetBalanceOf._parser;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x0016F3E0 File Offset: 0x0016D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x0016F3F2 File Offset: 0x0016D5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_GetBalanceOf.Descriptor;
			}
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x0016F3F9 File Offset: 0x0016D5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetBalanceOf()
		{
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0016F430 File Offset: 0x0016D630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetBalanceOf(S2C_GetBalanceOf other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this.lORD_ = other.lORD_;
			this.balanceOf_ = other.balanceOf_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x0016F484 File Offset: 0x0016D684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetBalanceOf Clone()
		{
			return new S2C_GetBalanceOf(this);
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0016F48C File Offset: 0x0016D68C
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x0016F494 File Offset: 0x0016D694
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

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x0016F4A7 File Offset: 0x0016D6A7
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x0016F4AF File Offset: 0x0016D6AF
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0016F4C2 File Offset: 0x0016D6C2
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x0016F4CA File Offset: 0x0016D6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LORD
		{
			get
			{
				return this.lORD_;
			}
			set
			{
				this.lORD_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x0016F4DD File Offset: 0x0016D6DD
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x0016F4E5 File Offset: 0x0016D6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BalanceOf
		{
			get
			{
				return this.balanceOf_;
			}
			set
			{
				this.balanceOf_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0016F4F8 File Offset: 0x0016D6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_GetBalanceOf);
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0016F508 File Offset: 0x0016D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_GetBalanceOf other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && !(this.LORD != other.LORD) && !(this.BalanceOf != other.BalanceOf) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0016F588 File Offset: 0x0016D788
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
			if (this.LORD.Length != 0)
			{
				num ^= this.LORD.GetHashCode();
			}
			if (this.BalanceOf.Length != 0)
			{
				num ^= this.BalanceOf.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0016F61A File Offset: 0x0016D81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0016F622 File Offset: 0x0016D822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0016F62C File Offset: 0x0016D82C
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
			if (this.LORD.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.LORD);
			}
			if (this.BalanceOf.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.BalanceOf);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x0016F6D4 File Offset: 0x0016D8D4
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
			if (this.LORD.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LORD);
			}
			if (this.BalanceOf.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BalanceOf);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x0016F770 File Offset: 0x0016D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_GetBalanceOf other)
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
			if (other.LORD.Length != 0)
			{
				this.LORD = other.LORD;
			}
			if (other.BalanceOf.Length != 0)
			{
				this.BalanceOf = other.BalanceOf;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0016F7FC File Offset: 0x0016D9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x0016F808 File Offset: 0x0016DA08
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
						this.LORD = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.BalanceOf = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400226C RID: 8812
		private static readonly MessageParser<S2C_GetBalanceOf> _parser = new MessageParser<S2C_GetBalanceOf>(() => new S2C_GetBalanceOf());

		// Token: 0x0400226D RID: 8813
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400226E RID: 8814
		public const int TokenFieldNumber = 1;

		// Token: 0x0400226F RID: 8815
		private string token_ = "";

		// Token: 0x04002270 RID: 8816
		public const int NetworkFieldNumber = 2;

		// Token: 0x04002271 RID: 8817
		private string network_ = "";

		// Token: 0x04002272 RID: 8818
		public const int LORDFieldNumber = 3;

		// Token: 0x04002273 RID: 8819
		private string lORD_ = "";

		// Token: 0x04002274 RID: 8820
		public const int BalanceOfFieldNumber = 4;

		// Token: 0x04002275 RID: 8821
		private string balanceOf_ = "";
	}
}
