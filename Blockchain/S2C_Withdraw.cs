using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000689 RID: 1673
	public sealed class S2C_Withdraw : IMessage<S2C_Withdraw>, IMessage, IEquatable<S2C_Withdraw>, IDeepCloneable<S2C_Withdraw>, IBufferMessage
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x00170B86 File Offset: 0x0016ED86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_Withdraw> Parser
		{
			get
			{
				return S2C_Withdraw._parser;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x00170B8D File Offset: 0x0016ED8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x00170B9F File Offset: 0x0016ED9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_Withdraw.Descriptor;
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00170BA6 File Offset: 0x0016EDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_Withdraw()
		{
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00170BB9 File Offset: 0x0016EDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_Withdraw(S2C_Withdraw other) : this()
		{
			this.iD_ = other.iD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00170BDE File Offset: 0x0016EDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_Withdraw Clone()
		{
			return new S2C_Withdraw(this);
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x00170BE6 File Offset: 0x0016EDE6
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x00170BEE File Offset: 0x0016EDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ID
		{
			get
			{
				return this.iD_;
			}
			set
			{
				this.iD_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00170C01 File Offset: 0x0016EE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_Withdraw);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00170C0F File Offset: 0x0016EE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_Withdraw other)
		{
			return other != null && (other == this || (!(this.ID != other.ID) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00170C44 File Offset: 0x0016EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ID.Length != 0)
			{
				num ^= this.ID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00170C85 File Offset: 0x0016EE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00170C8D File Offset: 0x0016EE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00170C96 File Offset: 0x0016EE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ID.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00170CD0 File Offset: 0x0016EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ID.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00170D13 File Offset: 0x0016EF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_Withdraw other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ID.Length != 0)
			{
				this.ID = other.ID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00170D49 File Offset: 0x0016EF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00170D54 File Offset: 0x0016EF54
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
					this.ID = input.ReadString();
				}
			}
		}

		// Token: 0x0400229E RID: 8862
		private static readonly MessageParser<S2C_Withdraw> _parser = new MessageParser<S2C_Withdraw>(() => new S2C_Withdraw());

		// Token: 0x0400229F RID: 8863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A0 RID: 8864
		public const int IDFieldNumber = 1;

		// Token: 0x040022A1 RID: 8865
		private string iD_ = "";
	}
}
