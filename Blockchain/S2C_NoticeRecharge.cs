using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000687 RID: 1671
	public sealed class S2C_NoticeRecharge : IMessage<S2C_NoticeRecharge>, IMessage, IEquatable<S2C_NoticeRecharge>, IDeepCloneable<S2C_NoticeRecharge>, IBufferMessage
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x0016FF98 File Offset: 0x0016E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_NoticeRecharge> Parser
		{
			get
			{
				return S2C_NoticeRecharge._parser;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x0016FF9F File Offset: 0x0016E19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x0016FFB1 File Offset: 0x0016E1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_NoticeRecharge.Descriptor;
			}
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0016FFB8 File Offset: 0x0016E1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeRecharge()
		{
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x0016FFF8 File Offset: 0x0016E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeRecharge(S2C_NoticeRecharge other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this.address_ = other.address_;
			this.additional_ = other.additional_;
			this.lORD_ = other.lORD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00170058 File Offset: 0x0016E258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeRecharge Clone()
		{
			return new S2C_NoticeRecharge(this);
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x00170060 File Offset: 0x0016E260
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x00170068 File Offset: 0x0016E268
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

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0017007B File Offset: 0x0016E27B
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x00170083 File Offset: 0x0016E283
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x00170096 File Offset: 0x0016E296
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x0017009E File Offset: 0x0016E29E
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

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x001700B1 File Offset: 0x0016E2B1
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x001700B9 File Offset: 0x0016E2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Additional
		{
			get
			{
				return this.additional_;
			}
			set
			{
				this.additional_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x001700CC File Offset: 0x0016E2CC
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x001700D4 File Offset: 0x0016E2D4
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

		// Token: 0x0600439F RID: 17311 RVA: 0x001700E7 File Offset: 0x0016E2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_NoticeRecharge);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x001700F8 File Offset: 0x0016E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_NoticeRecharge other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && !(this.Address != other.Address) && !(this.Additional != other.Additional) && !(this.LORD != other.LORD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0017018C File Offset: 0x0016E38C
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
			if (this.Additional.Length != 0)
			{
				num ^= this.Additional.GetHashCode();
			}
			if (this.LORD.Length != 0)
			{
				num ^= this.LORD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00170239 File Offset: 0x0016E439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00170241 File Offset: 0x0016E441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x0017024C File Offset: 0x0016E44C
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
			if (this.Additional.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Additional);
			}
			if (this.LORD.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.LORD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00170314 File Offset: 0x0016E514
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
			if (this.Additional.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Additional);
			}
			if (this.LORD.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LORD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x001703CC File Offset: 0x0016E5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_NoticeRecharge other)
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
			if (other.Additional.Length != 0)
			{
				this.Additional = other.Additional;
			}
			if (other.LORD.Length != 0)
			{
				this.LORD = other.LORD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00170471 File Offset: 0x0016E671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x0017047C File Offset: 0x0016E67C
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
						this.Additional = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.LORD = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002284 RID: 8836
		private static readonly MessageParser<S2C_NoticeRecharge> _parser = new MessageParser<S2C_NoticeRecharge>(() => new S2C_NoticeRecharge());

		// Token: 0x04002285 RID: 8837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002286 RID: 8838
		public const int TokenFieldNumber = 1;

		// Token: 0x04002287 RID: 8839
		private string token_ = "";

		// Token: 0x04002288 RID: 8840
		public const int NetworkFieldNumber = 2;

		// Token: 0x04002289 RID: 8841
		private string network_ = "";

		// Token: 0x0400228A RID: 8842
		public const int AddressFieldNumber = 3;

		// Token: 0x0400228B RID: 8843
		private string address_ = "";

		// Token: 0x0400228C RID: 8844
		public const int AdditionalFieldNumber = 4;

		// Token: 0x0400228D RID: 8845
		private string additional_ = "";

		// Token: 0x0400228E RID: 8846
		public const int LORDFieldNumber = 5;

		// Token: 0x0400228F RID: 8847
		private string lORD_ = "";
	}
}
