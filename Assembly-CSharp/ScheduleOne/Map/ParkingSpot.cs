using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055D")]
		public LandVehicle OccupantVehicle
		{
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x62B360", Offset = "0x62A560", VA = "0x18062B360")]
		private void Awake()
		{
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x62B560", Offset = "0x62A760", VA = "0x18062B560")]
		private void Init()
		{
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x62B6E0", Offset = "0x62A8E0", VA = "0x18062B6E0")]
		public void SetOccupant(LandVehicle vehicle)
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ParkingSpot()
		{
		}

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x20")]
		private ParkingLot ParentLot;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x28")]
		public Transform AlignmentPoint;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x30")]
		public EParkingAlignment Alignment;

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LandVehicle OccupantVehicle_Readonly;
	}
}
