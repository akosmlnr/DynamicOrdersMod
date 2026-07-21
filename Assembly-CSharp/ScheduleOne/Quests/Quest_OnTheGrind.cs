using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x5A7F70", Offset = "0x5A7170", VA = "0x1805A7F70", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x5A8090", Offset = "0x5A7290", VA = "0x1805A8090")]
		public Quest_OnTheGrind()
		{
		}

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry CompleteDealsEntry;
	}
}
