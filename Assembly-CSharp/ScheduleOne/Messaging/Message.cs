using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	[Serializable]
	public class Message
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x60EAE0", Offset = "0x60DCE0", VA = "0x18060EAE0")]
		public Message()
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x60EA60", Offset = "0x60DC60", VA = "0x18060EA60")]
		public Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1)
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x60EAF0", Offset = "0x60DCF0", VA = "0x18060EAF0")]
		public Message(TextMessageData data)
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x60E9C0", Offset = "0x60DBC0", VA = "0x18060E9C0")]
		public TextMessageData GetSaveData()
		{
			return null;
		}

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0x10")]
		public int messageId;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x20")]
		public Message.ESenderType sender;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x24")]
		public bool endOfGroup;

		// Token: 0x02000506 RID: 1286
		[Token(Token = "0x2000506")]
		public enum ESenderType
		{
			// Token: 0x040017DB RID: 6107
			[Token(Token = "0x40017DB")]
			Player,
			// Token: 0x040017DC RID: 6108
			[Token(Token = "0x40017DC")]
			Other
		}
	}
}
