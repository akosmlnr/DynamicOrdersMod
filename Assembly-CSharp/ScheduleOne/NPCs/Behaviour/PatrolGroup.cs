using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	public class PatrolGroup
	{
		// Token: 0x06005378 RID: 21368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x96E320", Offset = "0x96D520", VA = "0x18096E320")]
		public PatrolGroup(FootPatrolRoute route)
		{
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x96DBB0", Offset = "0x96CDB0", VA = "0x18096DBB0")]
		public Vector3 GetDestination(NPC member)
		{
			return default(Vector3);
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600537A")]
		[Address(RVA = "0x96D930", Offset = "0x96CB30", VA = "0x18096D930")]
		public void DisbandGroup()
		{
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600537B")]
		[Address(RVA = "0x96D8F0", Offset = "0x96CAF0", VA = "0x18096D8F0")]
		public void AdvanceGroup()
		{
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x600537C")]
		[Address(RVA = "0x96DE90", Offset = "0x96D090", VA = "0x18096DE90")]
		private Vector3 GetMemberOffset(NPC member)
		{
			return default(Vector3);
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x600537D")]
		[Address(RVA = "0x96E060", Offset = "0x96D260", VA = "0x18096E060")]
		public bool IsGroupReadyToAdvance()
		{
			return default(bool);
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x600537E")]
		[Address(RVA = "0x96E180", Offset = "0x96D380", VA = "0x18096E180")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x0400389A RID: 14490
		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x10")]
		public List<NPC> Members;

		// Token: 0x0400389B RID: 14491
		[Token(Token = "0x400389B")]
		[FieldOffset(Offset = "0x18")]
		public FootPatrolRoute Route;

		// Token: 0x0400389C RID: 14492
		[Token(Token = "0x400389C")]
		[FieldOffset(Offset = "0x20")]
		public int CurrentWaypoint;
	}
}
