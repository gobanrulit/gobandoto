using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x0200068E RID: 1678
	public sealed class S2C_GetDailyWithdraw : IMessage<S2C_GetDailyWithdraw>, IMessage, IEquatable<S2C_GetDailyWithdraw>, IDeepCloneable<S2C_GetDailyWithdraw>, IBufferMessage
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x0017172A File Offset: 0x0016F92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<S2C_GetDailyWithdraw> Parser
		{
			get
			{
				return S2C_GetDailyWithdraw._parser;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x00171731 File Offset: 0x0016F931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x00171744 File Offset: 0x0016F944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return S2C_GetDailyWithdraw.Descriptor;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x0017174B File Offset: 0x0016F94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDailyWithdraw()
		{
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x0017175E File Offset: 0x0016F95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDailyWithdraw(S2C_GetDailyWithdraw other) : this()
		{
			this.dailyWithdrawLORDS_ = other.dailyWithdrawLORDS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00171783 File Offset: 0x0016F983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public S2C_GetDailyWithdraw Clone()
		{
			return new S2C_GetDailyWithdraw(this);
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x0017178B File Offset: 0x0016F98B
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x00171793 File Offset: 0x0016F993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DailyWithdrawLORDS
		{
			get
			{
				return this.dailyWithdrawLORDS_;
			}
			set
			{
				this.dailyWithdrawLORDS_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x001717A6 File Offset: 0x0016F9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as S2C_GetDailyWithdraw);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x001717B4 File Offset: 0x0016F9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(S2C_GetDailyWithdraw other)
		{
			return other != null && (other == this || (!(this.DailyWithdrawLORDS != other.DailyWithdrawLORDS) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x001717E8 File Offset: 0x0016F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DailyWithdrawLORDS.Length != 0)
			{
				num ^= this.DailyWithdrawLORDS.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00171829 File Offset: 0x0016FA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00171831 File Offset: 0x0016FA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0017183A File Offset: 0x0016FA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DailyWithdrawLORDS.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.DailyWithdrawLORDS);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00171874 File Offset: 0x0016FA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DailyWithdrawLORDS.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DailyWithdrawLORDS);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x001718B7 File Offset: 0x0016FAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(S2C_GetDailyWithdraw other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DailyWithdrawLORDS.Length != 0)
			{
				this.DailyWithdrawLORDS = other.DailyWithdrawLORDS;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x001718ED File Offset: 0x0016FAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x001718F8 File Offset: 0x0016FAF8
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
					this.DailyWithdrawLORDS = input.ReadString();
				}
			}
		}

		// Token: 0x040022B4 RID: 8884
		private static readonly MessageParser<S2C_GetDailyWithdraw> _parser = new MessageParser<S2C_GetDailyWithdraw>(() => new S2C_GetDailyWithdraw());

		// Token: 0x040022B5 RID: 8885
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B6 RID: 8886
		public const int DailyWithdrawLORDSFieldNumber = 1;

		// Token: 0x040022B7 RID: 8887
		private string dailyWithdrawLORDS_ = "";
	}
}
