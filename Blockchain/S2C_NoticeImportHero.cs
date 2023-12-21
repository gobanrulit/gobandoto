using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068F RID: 1679
	public sealed class S2C_NoticeImportHero : IMessage<S2C_NoticeImportHero>, IMessage, IEquatable<S2C_NoticeImportHero>, IDeepCloneable<S2C_NoticeImportHero>, IBufferMessage
	{
		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x00171952 File Offset: 0x0016FB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_NoticeImportHero> Parser
		{
			get
			{
				return S2C_NoticeImportHero._parser;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00171959 File Offset: 0x0016FB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x0017196C File Offset: 0x0016FB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_NoticeImportHero.Descriptor;
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00171973 File Offset: 0x0016FB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeImportHero()
		{
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00171986 File Offset: 0x0016FB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeImportHero(S2C_NoticeImportHero other) : this()
		{
			this.tokenId_ = other.tokenId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001719AB File Offset: 0x0016FBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_NoticeImportHero Clone()
		{
			return new S2C_NoticeImportHero(this);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x001719B3 File Offset: 0x0016FBB3
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x001719BB File Offset: 0x0016FBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TokenId
		{
			get
			{
				return this.tokenId_;
			}
			set
			{
				this.tokenId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x001719CE File Offset: 0x0016FBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_NoticeImportHero);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001719DC File Offset: 0x0016FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_NoticeImportHero other)
		{
			return other != null && (other == this || (!(this.TokenId != other.TokenId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00171A10 File Offset: 0x0016FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TokenId.Length != 0)
			{
				num ^= this.TokenId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00171A51 File Offset: 0x0016FC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00171A59 File Offset: 0x0016FC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00171A62 File Offset: 0x0016FC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TokenId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TokenId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00171A9C File Offset: 0x0016FC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TokenId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TokenId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00171ADF File Offset: 0x0016FCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_NoticeImportHero other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TokenId.Length != 0)
			{
				this.TokenId = other.TokenId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00171B15 File Offset: 0x0016FD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00171B20 File Offset: 0x0016FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TokenId = input.ReadString();
				}
			}
		}

		// Token: 0x040022B8 RID: 8888
		private static readonly MessageParser<S2C_NoticeImportHero> _parser = new MessageParser<S2C_NoticeImportHero>(() => new S2C_NoticeImportHero());

		// Token: 0x040022B9 RID: 8889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022BA RID: 8890
		public const int TokenIdFieldNumber = 1;

		// Token: 0x040022BB RID: 8891
		private string tokenId_ = "";
	}
}
