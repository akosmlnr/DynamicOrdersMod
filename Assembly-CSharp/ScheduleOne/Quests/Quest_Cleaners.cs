using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	public class Quest_Cleaners : Quest_Employees
	{
		// Token: 0x06001466 RID: 5222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x5A57D0", Offset = "0x5A49D0", VA = "0x1805A57D0", Slot = "43")]
		protected override void OnMinPass()
		{
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x5A5750", Offset = "0x5A4950", VA = "0x1805A5750", Slot = "57")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x5A50D0", Offset = "0x5A42D0", VA = "0x1805A50D0")]
		public Quest_Cleaners()
		{
		}

		// Token: 0x04001275 RID: 4725
		[Token(Token = "0x4001275")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
