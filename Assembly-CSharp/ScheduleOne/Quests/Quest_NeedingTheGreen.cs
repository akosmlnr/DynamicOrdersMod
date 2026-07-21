using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	public class Quest_NeedingTheGreen : Quest
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x5A7C90", Offset = "0x5A6E90", VA = "0x1805A7C90", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x5A7F10", Offset = "0x5A7110", VA = "0x1805A7F10")]
		public Quest_NeedingTheGreen()
		{
		}

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x138")]
		public Quest[] PrerequisiteQuests;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry EarnEntry;

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x148")]
		public float LifetimeEarningsRequirement;
	}
}
