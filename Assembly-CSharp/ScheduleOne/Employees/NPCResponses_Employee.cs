using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Employees
{
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	public class NPCResponses_Employee : NPCResponses
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x7020E0", Offset = "0x7012E0", VA = "0x1807020E0", Slot = "19")]
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0x702110", Offset = "0x701310", VA = "0x180702110", Slot = "21")]
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x7020E0", Offset = "0x7012E0", VA = "0x1807020E0", Slot = "20")]
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x701F70", Offset = "0x701170", VA = "0x180701F70")]
		private void Ow(Player perpetrator)
		{
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public NPCResponses_Employee()
		{
		}
	}
}
