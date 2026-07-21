using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public interface IBaseSaveable : ISaveable
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001866 RID: 6246
		[Token(Token = "0x170004AA")]
		int LoadOrder
		{
			[Token(Token = "0x6001866")]
			get;
		}
	}
}
