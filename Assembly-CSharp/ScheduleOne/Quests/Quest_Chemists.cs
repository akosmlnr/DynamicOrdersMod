using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	public class Quest_Chemists : Quest_Employees
	{
		// Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x5A51A0", Offset = "0x5A43A0", VA = "0x1805A51A0", Slot = "43")]
		protected override void OnMinPass()
		{
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x5A5120", Offset = "0x5A4320", VA = "0x1805A5120", Slot = "57")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x5A50D0", Offset = "0x5A42D0", VA = "0x1805A50D0")]
		public Quest_Chemists()
		{
		}

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
