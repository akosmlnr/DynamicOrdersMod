using System;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public interface IMessageEntity
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001BC4 RID: 7108
		// (set) Token: 0x06001BC5 RID: 7109
		[Token(Token = "0x1700051A")]
		MSGConversation MsgConversation
		{
			[Token(Token = "0x6001BC4")]
			get;
			[Token(Token = "0x6001BC5")]
			set;
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001BC6 RID: 7110
		// (remove) Token: 0x06001BC7 RID: 7111
		[Token(Token = "0x1400000D")]
		event ResponseCallback onResponseChosen;
	}
}
