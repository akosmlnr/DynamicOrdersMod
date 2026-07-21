using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06002E96 RID: 11926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x74C5A0", Offset = "0x74B7A0", VA = "0x18074C5A0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x737360", Offset = "0x736560", VA = "0x180737360")]
		public SensorRollerDoors()
		{
		}

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public VehicleDetector Detector;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x70")]
		public VehicleDetector ClipDetector;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x78")]
		[Header("Settings")]
		public bool DetectPlayerOccupiedVehiclesOnly;
	}
}
