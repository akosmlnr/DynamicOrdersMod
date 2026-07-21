using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B41 RID: 2881
	[Token(Token = "0x2000B41")]
	public class NPCSignal_DriveToCarPark : NPCSignal
	{
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CA4")]
		public new string ActionName
		{
			[Token(Token = "0x6005637")]
			[Address(RVA = "0x983410", Offset = "0x982610", VA = "0x180983410")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005638")]
		[Address(RVA = "0x982550", Offset = "0x981750", VA = "0x180982550", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005639")]
		[Address(RVA = "0x983000", Offset = "0x982200", VA = "0x180983000", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563A")]
		[Address(RVA = "0x9832F0", Offset = "0x9824F0", VA = "0x1809832F0", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563B")]
		[Address(RVA = "0x9824A0", Offset = "0x9816A0", VA = "0x1809824A0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563C")]
		[Address(RVA = "0x9828E0", Offset = "0x981AE0", VA = "0x1809828E0", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563D")]
		[Address(RVA = "0x982340", Offset = "0x981540", VA = "0x180982340")]
		private void CheckValidForStart()
		{
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563E")]
		[Address(RVA = "0x982800", Offset = "0x981A00", VA = "0x180982800", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563F")]
		[Address(RVA = "0x9832A0", Offset = "0x9824A0", VA = "0x1809832A0", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005640")]
		[Address(RVA = "0x9832D0", Offset = "0x9824D0", VA = "0x1809832D0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005641")]
		[Address(RVA = "0x983170", Offset = "0x982370", VA = "0x180983170", Slot = "28")]
		public override void ResumeFailed()
		{
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005642")]
		[Address(RVA = "0x9828C0", Offset = "0x981AC0", VA = "0x1809828C0", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005643")]
		[Address(RVA = "0x982990", Offset = "0x981B90", VA = "0x180982990", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005644")]
		[Address(RVA = "0x983390", Offset = "0x982590", VA = "0x180983390", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x6005645")]
		[Address(RVA = "0x9826C0", Offset = "0x9818C0", VA = "0x1809826C0")]
		private Vector3 GetWalkDestination()
		{
			return default(Vector3);
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005646")]
		[Address(RVA = "0x9823F0", Offset = "0x9815F0", VA = "0x1809823F0")]
		private void DriveCallback(VehicleAgent.ENavigationResult result)
		{
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005647")]
		[Address(RVA = "0x983030", Offset = "0x982230", VA = "0x180983030")]
		private void Park()
		{
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x6005648")]
		[Address(RVA = "0x982680", Offset = "0x981880", VA = "0x180982680")]
		private EParkingAlignment GetParkingType()
		{
			return EParkingAlignment.FrontToKerb;
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005649")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCSignal_DriveToCarPark()
		{
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600564A")]
		[Address(RVA = "0x983320", Offset = "0x982520", VA = "0x180983320")]
		[CompilerGenerated]
		private IEnumerator <DriveCallback>g__Wait|23_0()
		{
			return null;
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x982950", Offset = "0x981B50", VA = "0x180982950", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564C")]
		[Address(RVA = "0x982910", Offset = "0x981B10", VA = "0x180982910", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564D")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564E")]
		[Address(RVA = "0x97A7C0", Offset = "0x9799C0", VA = "0x18097A7C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039C9 RID: 14793
		[Token(Token = "0x40039C9")]
		[FieldOffset(Offset = "0x150")]
		public ParkingLot ParkingLot;

		// Token: 0x040039CA RID: 14794
		[Token(Token = "0x40039CA")]
		[FieldOffset(Offset = "0x158")]
		public LandVehicle Vehicle;

		// Token: 0x040039CB RID: 14795
		[Token(Token = "0x40039CB")]
		[FieldOffset(Offset = "0x160")]
		[Header("Parking Settings")]
		public bool OverrideParkingType;

		// Token: 0x040039CC RID: 14796
		[Token(Token = "0x40039CC")]
		[FieldOffset(Offset = "0x164")]
		public EParkingAlignment ParkingType;

		// Token: 0x040039CD RID: 14797
		[Token(Token = "0x40039CD")]
		[FieldOffset(Offset = "0x168")]
		private bool isAtDestination;

		// Token: 0x040039CE RID: 14798
		[Token(Token = "0x40039CE")]
		[FieldOffset(Offset = "0x16C")]
		private float timeInVehicle;

		// Token: 0x040039CF RID: 14799
		[Token(Token = "0x40039CF")]
		[FieldOffset(Offset = "0x170")]
		private float timeAtDestination;

		// Token: 0x040039D0 RID: 14800
		[Token(Token = "0x40039D0")]
		[FieldOffset(Offset = "0x174")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted;

		// Token: 0x040039D1 RID: 14801
		[Token(Token = "0x40039D1")]
		[FieldOffset(Offset = "0x175")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted;
	}
}
