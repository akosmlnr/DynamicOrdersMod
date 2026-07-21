using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	public class Quest_Botanists : Quest_Employees
	{
		// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x5A4810", Offset = "0x5A3A10", VA = "0x1805A4810", Slot = "43")]
		protected override void OnMinPass()
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x5A4790", Offset = "0x5A3990", VA = "0x1805A4790", Slot = "57")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x5A50D0", Offset = "0x5A42D0", VA = "0x1805A50D0")]
		public Quest_Botanists()
		{
		}

		// Token: 0x0400126F RID: 4719
		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignSuppliesEntry;

		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry AssignWorkEntry;

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry AssignDestinationEntry;
	}
}
