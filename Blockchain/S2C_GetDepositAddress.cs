using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000686 RID: 1670
	public sealed class S2C_GetDepositAddress : IMessage<S2C_GetDepositAddress>, IMessage, IEquatable<S2C_GetDepositAddress>, IDeepCloneable<S2C_GetDepositAddress>, IBufferMessage
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x0016FBB9 File Offset: 0x0016DDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_GetDepositAddress> Parser
		{
			get
			{
				return S2C_GetDepositAddress._parser;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x0016FBC0 File Offset: 0x0016DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x0016FBD2 File Offset: 0x0016DDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_GetDepositAddress.Descriptor;
			}
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x0016FBD9 File Offset: 0x0016DDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDepositAddress()
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x0016FC02 File Offset: 0x0016DE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDepositAddress(S2C_GetDepositAddress other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this.depositAddress_ = other.depositAddress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x0016FC3F File Offset: 0x0016DE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDepositAddress Clone()
		{
			return new S2C_GetDepositAddress(this);
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x0016FC47 File Offset: 0x0016DE47
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x0016FC4F File Offset: 0x0016DE4F
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x0016FC62 File Offset: 0x0016DE62
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x0016FC6A File Offset: 0x0016DE6A
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x0016FC7D File Offset: 0x0016DE7D
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x0016FC85 File Offset: 0x0016DE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DepositAddress
		{
			get
			{
				return this.depositAddress_;
			}
			set
			{
				this.depositAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x0016FC98 File Offset: 0x0016DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_GetDepositAddress);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0016FCA8 File Offset: 0x0016DEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_GetDepositAddress other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && !(this.DepositAddress != other.DepositAddress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x0016FD10 File Offset: 0x0016DF10
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
			if (this.DepositAddress.Length != 0)
			{
				num ^= this.DepositAddress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x0016FD87 File Offset: 0x0016DF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0016FD8F File Offset: 0x0016DF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0016FD98 File Offset: 0x0016DF98
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
			if (this.DepositAddress.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DepositAddress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0016FE1C File Offset: 0x0016E01C
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
			if (this.DepositAddress.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DepositAddress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0016FE9C File Offset: 0x0016E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_GetDepositAddress other)
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
			if (other.DepositAddress.Length != 0)
			{
				this.DepositAddress = other.DepositAddress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0016FF0F File Offset: 0x0016E10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x0016FF18 File Offset: 0x0016E118
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DepositAddress = input.ReadString();
						}
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

		// Token: 0x0400227C RID: 8828
		private static readonly MessageParser<S2C_GetDepositAddress> _parser = new MessageParser<S2C_GetDepositAddress>(() => new S2C_GetDepositAddress());

		// Token: 0x0400227D RID: 8829
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400227E RID: 8830
		public const int TokenFieldNumber = 1;

		// Token: 0x0400227F RID: 8831
		private string token_ = "";

		// Token: 0x04002280 RID: 8832
		public const int NetworkFieldNumber = 2;

		// Token: 0x04002281 RID: 8833
		private string network_ = "";

		// Token: 0x04002282 RID: 8834
		public const int DepositAddressFieldNumber = 3;

		// Token: 0x04002283 RID: 8835
		private string depositAddress_ = "";
	}
}
