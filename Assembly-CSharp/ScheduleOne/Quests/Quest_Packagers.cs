using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public class Quest_Packagers : Quest_Employees
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x5A8160", Offset = "0x5A7360", VA = "0x1805A8160", Slot = "43")]
		protected override void OnMinPass()
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x5A80E0", Offset = "0x5A72E0", VA = "0x1805A80E0", Slot = "57")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x5A50D0", Offset = "0x5A42D0", VA = "0x1805A50D0")]
		public Quest_Packagers()
		{
		}

		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
