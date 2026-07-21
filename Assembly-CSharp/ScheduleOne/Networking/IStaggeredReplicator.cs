using System;
using Il2CppDummyDll;

namespace ScheduleOne.Networking
{
	// Token: 0x020004F7 RID: 1271
	[Token(Token = "0x20004F7")]
	public interface IStaggeredReplicator
	{
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001B74 RID: 7028
		[Token(Token = "0x1700050E")]
		bool IsDoneReplicating
		{
			[Token(Token = "0x6001B74")]
			get;
		}

		// Token: 0x06001B75 RID: 7029
		[Token(Token = "0x6001B75")]
		void SetIsDoneReplicating();
	}
}
