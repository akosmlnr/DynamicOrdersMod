using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000550 RID: 1360
	[Token(Token = "0x2000550")]
	public class WaterCollider : MonoBehaviour
	{
		// Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x635800", Offset = "0x634A00", VA = "0x180635800")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x635D70", Offset = "0x634F70", VA = "0x180635D70")]
		private IEnumerator WarpPlayer()
		{
			return null;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x635DE0", Offset = "0x634FE0", VA = "0x180635DE0")]
		private IEnumerator WarpVehicle(LandVehicle veh)
		{
			return null;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x635E70", Offset = "0x635070", VA = "0x180635E70")]
		public WaterCollider()
		{
		}

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x20")]
		private bool localPlayerBeingWarped;

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x28")]
		private List<LandVehicle> warpedVehicles;

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController SplashSound;

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x38")]
		public Transform OverrideWarpPoint;
	}
}
