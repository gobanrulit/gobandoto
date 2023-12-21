using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068D RID: 1677
	public sealed class C2S_GetDailyWithdraw : IMessage<C2S_GetDailyWithdraw>, IMessage, IEquatable<C2S_GetDailyWithdraw>, IDeepCloneable<C2S_GetDailyWithdraw>, IBufferMessage
	{
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x001715DE File Offset: 0x0016F7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_GetDailyWithdraw> Parser
		{
			get
			{
				return C2S_GetDailyWithdraw._parser;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x001715E5 File Offset: 0x0016F7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x001715F8 File Offset: 0x0016F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_GetDailyWithdraw.Descriptor;
			}
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x001715FF File Offset: 0x0016F7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDailyWithdraw()
		{
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00171607 File Offset: 0x0016F807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDailyWithdraw(C2S_GetDailyWithdraw other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00171620 File Offset: 0x0016F820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetDailyWithdraw Clone()
		{
			return new C2S_GetDailyWithdraw(this);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00171628 File Offset: 0x0016F828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_GetDailyWithdraw);
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00171636 File Offset: 0x0016F836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_GetDailyWithdraw other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00171654 File Offset: 0x0016F854
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

		// Token: 0x06004420 RID: 17440 RVA: 0x0017167A File Offset: 0x0016F87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00171682 File Offset: 0x0016F882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x0017168B File Offset: 0x0016F88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x001716A4 File Offset: 0x0016F8A4
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

		// Token: 0x06004424 RID: 17444 RVA: 0x001716CA File Offset: 0x0016F8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_GetDailyWithdraw other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x001716E7 File Offset: 0x0016F8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x001716F0 File Offset: 0x0016F8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022B2 RID: 8882
		private static readonly MessageParser<C2S_GetDailyWithdraw> _parser = new MessageParser<C2S_GetDailyWithdraw>(() => new C2S_GetDailyWithdraw());

		// Token: 0x040022B3 RID: 8883
		private UnknownFieldSet _unknownFields;
	}
}
