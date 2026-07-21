using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0xB12EE0", Offset = "0xB120E0", VA = "0x180B12EE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0xB130F0", Offset = "0xB122F0", VA = "0x180B130F0", Slot = "5")]
		public virtual void OnVehicleStart()
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0xB13150", Offset = "0xB12350", VA = "0x180B13150", Slot = "6")]
		public virtual void OnVehicleStop()
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleFX()
		{
		}

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem[] exhaustFX;
	}
}
