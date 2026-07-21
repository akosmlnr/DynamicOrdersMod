using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	[Serializable]
	public class TextMessageData
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x619D40", Offset = "0x618F40", VA = "0x180619D40")]
		public TextMessageData(int sender, int messageID, string text, bool endOfChain)
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x619CE0", Offset = "0x618EE0", VA = "0x180619CE0")]
		public TextMessageData()
		{
		}

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0x10")]
		public int Sender;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[FieldOffset(Offset = "0x14")]
		public int MessageID;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[FieldOffset(Offset = "0x18")]
		public string Text;

		// Token: 0x04001773 RID: 6003
		[Token(Token = "0x4001773")]
		[FieldOffset(Offset = "0x20")]
		public bool EndOfChain;
	}
}
