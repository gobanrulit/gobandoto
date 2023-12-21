using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068C RID: 1676
	public sealed class S2C_GetEmailCode : IMessage<S2C_GetEmailCode>, IMessage, IEquatable<S2C_GetEmailCode>, IDeepCloneable<S2C_GetEmailCode>, IBufferMessage
	{
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00171492 File Offset: 0x0016F692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_GetEmailCode> Parser
		{
			get
			{
				return S2C_GetEmailCode._parser;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x00171499 File Offset: 0x0016F699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x001714AC File Offset: 0x0016F6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_GetEmailCode.Descriptor;
			}
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x001714B3 File Offset: 0x0016F6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetEmailCode()
		{
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x001714BB File Offset: 0x0016F6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetEmailCode(S2C_GetEmailCode other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x001714D4 File Offset: 0x0016F6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetEmailCode Clone()
		{
			return new S2C_GetEmailCode(this);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x001714DC File Offset: 0x0016F6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_GetEmailCode);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001714EA File Offset: 0x0016F6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_GetEmailCode other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00171508 File Offset: 0x0016F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x0017152E File Offset: 0x0016F72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00171536 File Offset: 0x0016F736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0017153F File Offset: 0x0016F73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00171558 File Offset: 0x0016F758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x0017157E File Offset: 0x0016F77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_GetEmailCode other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x0017159B File Offset: 0x0016F79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x001715A4 File Offset: 0x0016F7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022B0 RID: 8880
		private static readonly MessageParser<S2C_GetEmailCode> _parser = new MessageParser<S2C_GetEmailCode>(() => new S2C_GetEmailCode());

		// Token: 0x040022B1 RID: 8881
		private UnknownFieldSet _unknownFields;
	}
}
