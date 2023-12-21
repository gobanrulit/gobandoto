using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000691 RID: 1681
	public sealed class S2C_GetConfigInfo : IMessage<S2C_GetConfigInfo>, IMessage, IEquatable<S2C_GetConfigInfo>, IDeepCloneable<S2C_GetConfigInfo>, IBufferMessage
	{
		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00171CC6 File Offset: 0x0016FEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_GetConfigInfo> Parser
		{
			get
			{
				return S2C_GetConfigInfo._parser;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x00171CCD File Offset: 0x0016FECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x00171CE0 File Offset: 0x0016FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_GetConfigInfo.Descriptor;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00171CE7 File Offset: 0x0016FEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetConfigInfo()
		{
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00171D10 File Offset: 0x0016FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetConfigInfo(S2C_GetConfigInfo other) : this()
		{
			this.heroBankAddress_ = other.heroBankAddress_;
			this.walletAddress_ = other.walletAddress_;
			this.polygonWalletAddress_ = other.polygonWalletAddress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00171D4D File Offset: 0x0016FF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetConfigInfo Clone()
		{
			return new S2C_GetConfigInfo(this);
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x00171D55 File Offset: 0x0016FF55
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x00171D5D File Offset: 0x0016FF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HeroBankAddress
		{
			get
			{
				return this.heroBankAddress_;
			}
			set
			{
				this.heroBankAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x00171D70 File Offset: 0x0016FF70
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x00171D78 File Offset: 0x0016FF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string WalletAddress
		{
			get
			{
				return this.walletAddress_;
			}
			set
			{
				this.walletAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x00171D8B File Offset: 0x0016FF8B
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x00171D93 File Offset: 0x0016FF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PolygonWalletAddress
		{
			get
			{
				return this.polygonWalletAddress_;
			}
			set
			{
				this.polygonWalletAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00171DA6 File Offset: 0x0016FFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_GetConfigInfo);
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00171DB4 File Offset: 0x0016FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_GetConfigInfo other)
		{
			return other != null && (other == this || (!(this.HeroBankAddress != other.HeroBankAddress) && !(this.WalletAddress != other.WalletAddress) && !(this.PolygonWalletAddress != other.PolygonWalletAddress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00171E1C File Offset: 0x0017001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeroBankAddress.Length != 0)
			{
				num ^= this.HeroBankAddress.GetHashCode();
			}
			if (this.WalletAddress.Length != 0)
			{
				num ^= this.WalletAddress.GetHashCode();
			}
			if (this.PolygonWalletAddress.Length != 0)
			{
				num ^= this.PolygonWalletAddress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00171E93 File Offset: 0x00170093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00171E9B File Offset: 0x0017009B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00171EA4 File Offset: 0x001700A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeroBankAddress.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroBankAddress);
			}
			if (this.WalletAddress.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.WalletAddress);
			}
			if (this.PolygonWalletAddress.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PolygonWalletAddress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00171F28 File Offset: 0x00170128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeroBankAddress.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroBankAddress);
			}
			if (this.WalletAddress.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.WalletAddress);
			}
			if (this.PolygonWalletAddress.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PolygonWalletAddress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00171FA8 File Offset: 0x001701A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_GetConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeroBankAddress.Length != 0)
			{
				this.HeroBankAddress = other.HeroBankAddress;
			}
			if (other.WalletAddress.Length != 0)
			{
				this.WalletAddress = other.WalletAddress;
			}
			if (other.PolygonWalletAddress.Length != 0)
			{
				this.PolygonWalletAddress = other.PolygonWalletAddress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x0017201B File Offset: 0x0017021B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00172024 File Offset: 0x00170224
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
							this.PolygonWalletAddress = input.ReadString();
						}
					}
					else
					{
						this.WalletAddress = input.ReadString();
					}
				}
				else
				{
					this.HeroBankAddress = input.ReadString();
				}
			}
		}

		// Token: 0x040022BE RID: 8894
		private static readonly MessageParser<S2C_GetConfigInfo> _parser = new MessageParser<S2C_GetConfigInfo>(() => new S2C_GetConfigInfo());

		// Token: 0x040022BF RID: 8895
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C0 RID: 8896
		public const int HeroBankAddressFieldNumber = 1;

		// Token: 0x040022C1 RID: 8897
		private string heroBankAddress_ = "";

		// Token: 0x040022C2 RID: 8898
		public const int WalletAddressFieldNumber = 2;

		// Token: 0x040022C3 RID: 8899
		private string walletAddress_ = "";

		// Token: 0x040022C4 RID: 8900
		public const int PolygonWalletAddressFieldNumber = 3;

		// Token: 0x040022C5 RID: 8901
		private string polygonWalletAddress_ = "";
	}
}
