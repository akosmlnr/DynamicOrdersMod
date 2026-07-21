using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001026")]
		[Address(RVA = "0xB16540", Offset = "0xB15740", VA = "0x180B16540", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001027")]
		[Address(RVA = "0xB16610", Offset = "0xB15810", VA = "0x180B16610")]
		public static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleRecoveryPoint()
		{
		}

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x0")]
		public static List<VehicleRecoveryPoint> recoveryPoints;
	}
}
