using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public interface IPostSleepEvent
	{
		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06005E0B RID: 24075
		[Token(Token = "0x17000D9E")]
		bool IsRunning
		{
			[Token(Token = "0x6005E0B")]
			get;
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06005E0C RID: 24076
		[Token(Token = "0x17000D9F")]
		int Order
		{
			[Token(Token = "0x6005E0C")]
			get;
		}

		// Token: 0x06005E0D RID: 24077
		[Token(Token = "0x6005E0D")]
		void StartEvent();
	}
}
