using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A5 RID: 677
	[Token(Token = "0x20002A5")]
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleInitializer : NetworkBehaviour
	{
		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0xB13460", Offset = "0xB12660", VA = "0x180B13460", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public VehicleInitializer()
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0xB13440", Offset = "0xB12640", VA = "0x180B13440", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x63CEA0", Offset = "0x63C0A0", VA = "0x18063CEA0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x118")]
		public ParkingLot InitialParkingLot;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x120")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x121")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted;
	}
}
