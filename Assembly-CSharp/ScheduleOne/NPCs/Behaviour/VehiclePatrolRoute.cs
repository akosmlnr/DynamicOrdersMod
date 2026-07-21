using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x06005506 RID: 21766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x98C480", Offset = "0x98B680", VA = "0x18098C480")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x98C980", Offset = "0x98BB80", VA = "0x18098C980")]
		public VehiclePatrolRoute()
		{
		}

		// Token: 0x04003956 RID: 14678
		[Token(Token = "0x4003956")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string RouteName;

		// Token: 0x04003957 RID: 14679
		[Token(Token = "0x4003957")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] Waypoints;

		// Token: 0x04003958 RID: 14680
		[Token(Token = "0x4003958")]
		[FieldOffset(Offset = "0x30")]
		public int StartWaypointIndex;
	}
}
