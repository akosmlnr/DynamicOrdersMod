using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Quests
{
	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x5A7900", Offset = "0x5A6B00", VA = "0x1805A7900")]
		public Quest_GettingStarted()
		{
		}

		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x138")]
		public float CashAmount;

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x140")]
		public DeadDrop CashDrop;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x148")]
		public UncleNelson Nelson;
	}
}
