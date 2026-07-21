using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	public class ParkingLot : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0000AB48 File Offset: 0x00008D48
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055C")]
		public Guid GUID
		{
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x4D6AD0", Offset = "0x4D5CD0", VA = "0x1804D6AD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x4F3EE0", Offset = "0x4F30E0", VA = "0x1804F3EE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x62AC90", Offset = "0x629E90", VA = "0x18062AC90")]
		private void Awake()
		{
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x62B250", Offset = "0x62A450", VA = "0x18062B250", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x62B140", Offset = "0x62A340", VA = "0x18062B140")]
		public ParkingSpot GetRandomFreeSpot()
		{
			return null;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x62B080", Offset = "0x62A280", VA = "0x18062B080")]
		public int GetRandomFreeSpotIndex()
		{
			return 0;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x62AEF0", Offset = "0x62A0F0", VA = "0x18062AEF0")]
		public List<ParkingSpot> GetFreeParkingSpots()
		{
			return null;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x62B2B0", Offset = "0x62A4B0", VA = "0x18062B2B0")]
		public ParkingLot()
		{
		}

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[FieldOffset(Offset = "0x38")]
		[Header("READONLY")]
		public List<ParkingSpot> ParkingSpots;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x40")]
		[Header("Entry")]
		public Transform EntryPoint;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x48")]
		public Transform HiddenVehicleAccessPoint;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x50")]
		[Header("Exit")]
		public bool UseExitPoint;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x54")]
		public EParkingAlignment ExitAlignment;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[FieldOffset(Offset = "0x58")]
		public Transform ExitPoint;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x60")]
		public VehicleDetector ExitPointVehicleDetector;
	}
}
