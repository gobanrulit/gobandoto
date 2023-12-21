using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000685 RID: 1669
	public sealed class C2S_GetDepositAddress : IMessage<C2S_GetDepositAddress>, IMessage, IEquatable<C2S_GetDepositAddress>, IDeepCloneable<C2S_GetDepositAddress>, IBufferMessage
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x0016F8A2 File Offset: 0x0016DAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_GetDepositAddress> Parser
		{
			get
			{
				return C2S_GetDepositAddress._parser;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x0016F8A9 File Offset: 0x0016DAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x0016F8BB File Offset: 0x0016DABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_GetDepositAddress.Descriptor;
			}
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0016F8C2 File Offset: 0x0016DAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDepositAddress()
		{
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x0016F8E0 File Offset: 0x0016DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDepositAddress(C2S_GetDepositAddress other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x0016F911 File Offset: 0x0016DB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDepositAddress Clone()
		{
			return new C2S_GetDepositAddress(this);
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0016F919 File Offset: 0x0016DB19
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x0016F921 File Offset: 0x0016DB21
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

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x0016F934 File Offset: 0x0016DB34
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x0016F93C File Offset: 0x0016DB3C
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

		// Token: 0x0600436D RID: 17261 RVA: 0x0016F94F File Offset: 0x0016DB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_GetDepositAddress);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0016F960 File Offset: 0x0016DB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_GetDepositAddress other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x0016F9B4 File Offset: 0x0016DBB4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x0016FA10 File Offset: 0x0016DC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x0016FA18 File Offset: 0x0016DC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x0016FA24 File Offset: 0x0016DC24
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x0016FA88 File Offset: 0x0016DC88
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x0016FAE8 File Offset: 0x0016DCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_GetDepositAddress other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x0016FB42 File Offset: 0x0016DD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x0016FB4C File Offset: 0x0016DD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Network = input.ReadString();
					}
				}
				else
				{
					this.Token = input.ReadString();
				}
			}
		}

		// Token: 0x04002276 RID: 8822
		private static readonly MessageParser<C2S_GetDepositAddress> _parser = new MessageParser<C2S_GetDepositAddress>(() => new C2S_GetDepositAddress());

		// Token: 0x04002277 RID: 8823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002278 RID: 8824
		public const int TokenFieldNumber = 1;

		// Token: 0x04002279 RID: 8825
		private string token_ = "";

		// Token: 0x0400227A RID: 8826
		public const int NetworkFieldNumber = 2;

		// Token: 0x0400227B RID: 8827
		private string network_ = "";
	}
}
