using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	public class VehicleModStation : MonoBehaviour
	{
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public LandVehicle currentVehicle
		{
			[Token(Token = "0x600105B")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x17000380")]
		public bool isOpen
		{
			[Token(Token = "0x600105D")]
			[Address(RVA = "0xB164F0", Offset = "0xB156F0", VA = "0x180B164F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105E")]
		[Address(RVA = "0xB15DC0", Offset = "0xB14FC0", VA = "0x180B15DC0")]
		public void Open(LandVehicle vehicle)
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105F")]
		[Address(RVA = "0xB16340", Offset = "0xB15540", VA = "0x180B16340", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001060")]
		[Address(RVA = "0xB15CA0", Offset = "0xB14EA0", VA = "0x180B15CA0")]
		public void Close()
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleModStation()
		{
		}

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected Transform vehiclePosition;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected OrbitCamera orbitCam;
	}
}
