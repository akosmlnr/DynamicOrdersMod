using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	public class Quest_MovingUp : Quest
	{
		// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x5A7B10", Offset = "0x5A6D10", VA = "0x1805A7B10", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x5A7C40", Offset = "0x5A6E40", VA = "0x1805A7C40")]
		public Quest_MovingUp()
		{
		}

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry ReachCustomersEntry;
	}
}
