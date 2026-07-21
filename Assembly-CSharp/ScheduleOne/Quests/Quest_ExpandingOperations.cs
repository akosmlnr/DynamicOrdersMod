using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x5A7230", Offset = "0x5A6430", VA = "0x1805A7230", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x5A7470", Offset = "0x5A6670", VA = "0x1805A7470")]
		public Quest_ExpandingOperations()
		{
		}

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry SetUpGrowTentsEntry;

		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry ReachCustomersEntry;
	}
}
