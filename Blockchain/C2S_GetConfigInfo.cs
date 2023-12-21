using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000690 RID: 1680
	public sealed class C2S_GetConfigInfo : IMessage<C2S_GetConfigInfo>, IMessage, IEquatable<C2S_GetConfigInfo>, IDeepCloneable<C2S_GetConfigInfo>, IBufferMessage
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x00171B7A File Offset: 0x0016FD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_GetConfigInfo> Parser
		{
			get
			{
				return C2S_GetConfigInfo._parser;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x00171B81 File Offset: 0x0016FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x00171B94 File Offset: 0x0016FD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_GetConfigInfo.Descriptor;
			}
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00171B9B File Offset: 0x0016FD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetConfigInfo()
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00171BA3 File Offset: 0x0016FDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetConfigInfo(C2S_GetConfigInfo other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00171BBC File Offset: 0x0016FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetConfigInfo Clone()
		{
			return new C2S_GetConfigInfo(this);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00171BC4 File Offset: 0x0016FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_GetConfigInfo);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00171BD2 File Offset: 0x0016FDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_GetConfigInfo other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00171BF0 File Offset: 0x0016FDF0
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

		// Token: 0x06004457 RID: 17495 RVA: 0x00171C16 File Offset: 0x0016FE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00171C1E File Offset: 0x0016FE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00171C27 File Offset: 0x0016FE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00171C40 File Offset: 0x0016FE40
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

		// Token: 0x0600445B RID: 17499 RVA: 0x00171C66 File Offset: 0x0016FE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_GetConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00171C83 File Offset: 0x0016FE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00171C8C File Offset: 0x0016FE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022BC RID: 8892
		private static readonly MessageParser<C2S_GetConfigInfo> _parser = new MessageParser<C2S_GetConfigInfo>(() => new C2S_GetConfigInfo());

		// Token: 0x040022BD RID: 8893
		private UnknownFieldSet _unknownFields;
	}
}
