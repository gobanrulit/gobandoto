using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blockchain
{
	// Token: 0x02000683 RID: 1667
	public sealed class C2S_GetBalanceOf : IMessage<C2S_GetBalanceOf>, IMessage, IEquatable<C2S_GetBalanceOf>, IDeepCloneable<C2S_GetBalanceOf>, IBufferMessage
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x0016F0C2 File Offset: 0x0016D2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<C2S_GetBalanceOf> Parser
		{
			get
			{
				return C2S_GetBalanceOf._parser;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x0016F0C9 File Offset: 0x0016D2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockchainMsgReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x0016F0DB File Offset: 0x0016D2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return C2S_GetBalanceOf.Descriptor;
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x0016F0E2 File Offset: 0x0016D2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetBalanceOf()
		{
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x0016F100 File Offset: 0x0016D300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetBalanceOf(C2S_GetBalanceOf other) : this()
		{
			this.token_ = other.token_;
			this.network_ = other.network_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0016F131 File Offset: 0x0016D331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public C2S_GetBalanceOf Clone()
		{
			return new C2S_GetBalanceOf(this);
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x0016F139 File Offset: 0x0016D339
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x0016F141 File Offset: 0x0016D341
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x0016F154 File Offset: 0x0016D354
		// (set) Token: 0x0600433E RID: 17214 RVA: 0x0016F15C File Offset: 0x0016D35C
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

		// Token: 0x0600433F RID: 17215 RVA: 0x0016F16F File Offset: 0x0016D36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as C2S_GetBalanceOf);
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x0016F180 File Offset: 0x0016D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(C2S_GetBalanceOf other)
		{
			return other != null && (other == this || (!(this.Token != other.Token) && !(this.Network != other.Network) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x0016F1D4 File Offset: 0x0016D3D4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x0016F230 File Offset: 0x0016D430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x0016F238 File Offset: 0x0016D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0016F244 File Offset: 0x0016D444
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0016F2A8 File Offset: 0x0016D4A8
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0016F308 File Offset: 0x0016D508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(C2S_GetBalanceOf other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x0016F362 File Offset: 0x0016D562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0016F36C File Offset: 0x0016D56C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04002266 RID: 8806
		private static readonly MessageParser<C2S_GetBalanceOf> _parser = new MessageParser<C2S_GetBalanceOf>(() => new C2S_GetBalanceOf());

		// Token: 0x04002267 RID: 8807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002268 RID: 8808
		public const int TokenFieldNumber = 1;

		// Token: 0x04002269 RID: 8809
		private string token_ = "";

		// Token: 0x0400226A RID: 8810
		public const int NetworkFieldNumber = 2;

		// Token: 0x0400226B RID: 8811
		private string network_ = "";
	}
}
