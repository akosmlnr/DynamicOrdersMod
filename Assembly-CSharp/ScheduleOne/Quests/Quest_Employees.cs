using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	public abstract class Quest_Employees : Quest
	{
		// Token: 0x0600147E RID: 5246
		[Token(Token = "0x600147E")]
		public abstract List<Employee> GetEmployees();

		// Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x5A7190", Offset = "0x5A6390", VA = "0x1805A7190", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x5A6EC0", Offset = "0x5A60C0", VA = "0x1805A6EC0")]
		protected bool AreAnyEmployeesAssignedBeds()
		{
			return default(bool);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x5A7050", Offset = "0x5A6250", VA = "0x1805A7050")]
		protected bool AreAnyEmployeesPaid()
		{
			return default(bool);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x5A50D0", Offset = "0x5A42D0", VA = "0x1805A50D0")]
		protected Quest_Employees()
		{
		}

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x138")]
		public EEmployeeType EmployeeType;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry AssignBedEntry;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x148")]
		public QuestEntry PayEntry;
	}
}
