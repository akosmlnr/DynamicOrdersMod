using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	public class Quest_CleanCash : Quest
	{
		// Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x5A5420", Offset = "0x5A4620", VA = "0x1805A5420", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x5A5700", Offset = "0x5A4900", VA = "0x1805A5700")]
		public Quest_CleanCash()
		{
		}

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry BuyBusinessEntry;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry GoToBusinessEntry;
	}
}
