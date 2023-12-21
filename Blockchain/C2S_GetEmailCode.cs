using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068B RID: 1675
	public sealed class C2S_GetEmailCode : IMessage<C2S_GetEmailCode>, IMessage, IEquatable<C2S_GetEmailCode>, IDeepCloneable<C2S_GetEmailCode>, IBufferMessage
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x00171344 File Offset: 0x0016F544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_GetEmailCode> Parser
		{
			get
			{
				return C2S_GetEmailCode._parser;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x0017134B File Offset: 0x0016F54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x0017135D File Offset: 0x0016F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_GetEmailCode.Descriptor;
			}
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00171364 File Offset: 0x0016F564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetEmailCode()
		{
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x0017136C File Offset: 0x0016F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetEmailCode(C2S_GetEmailCode other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x00171385 File Offset: 0x0016F585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetEmailCode Clone()
		{
			return new C2S_GetEmailCode(this);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x0017138D File Offset: 0x0016F58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_GetEmailCode);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x0017139B File Offset: 0x0016F59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_GetEmailCode other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x001713BC File Offset: 0x0016F5BC
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

		// Token: 0x060043FE RID: 17406 RVA: 0x001713E2 File Offset: 0x0016F5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x001713EA File Offset: 0x0016F5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x001713F3 File Offset: 0x0016F5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x0017140C File Offset: 0x0016F60C
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

		// Token: 0x06004402 RID: 17410 RVA: 0x00171432 File Offset: 0x0016F632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_GetEmailCode other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x0017144F File Offset: 0x0016F64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x00171458 File Offset: 0x0016F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022AE RID: 8878
		private static readonly MessageParser<C2S_GetEmailCode> _parser = new MessageParser<C2S_GetEmailCode>(() => new C2S_GetEmailCode());

		// Token: 0x040022AF RID: 8879
		private UnknownFieldSet _unknownFields;
	}
}
