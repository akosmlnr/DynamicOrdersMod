using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x06005374 RID: 21364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005374")]
		[Address(RVA = "0x963970", Offset = "0x962B70", VA = "0x180963970")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005375")]
		[Address(RVA = "0x963E70", Offset = "0x963070", VA = "0x180963E70")]
		private void OnValidate()
		{
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005376")]
		[Address(RVA = "0x963E70", Offset = "0x963070", VA = "0x180963E70")]
		private void UpdateWaypoints()
		{
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005377")]
		[Address(RVA = "0x963F20", Offset = "0x963120", VA = "0x180963F20")]
		public FootPatrolRoute()
		{
		}

		// Token: 0x04003896 RID: 14486
		[Token(Token = "0x4003896")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string RouteName;

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x28")]
		public Color PathColor;

		// Token: 0x04003898 RID: 14488
		[Token(Token = "0x4003898")]
		[FieldOffset(Offset = "0x38")]
		public Transform[] Waypoints;

		// Token: 0x04003899 RID: 14489
		[Token(Token = "0x4003899")]
		[FieldOffset(Offset = "0x40")]
		public int StartWaypointIndex;
	}
}
