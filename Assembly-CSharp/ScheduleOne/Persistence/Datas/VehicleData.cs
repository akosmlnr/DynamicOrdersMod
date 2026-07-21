using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x06001B39 RID: 6969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x61CEC0", Offset = "0x61C0C0", VA = "0x18061CEC0")]
		public VehicleData(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col, ItemSet vehicleContents, List<SpraySurfaceData> spraySurfaces)
		{
		}

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x30")]
		public string VehicleCode;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 Position;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x44")]
		public Quaternion Rotation;

		// Token: 0x0400178B RID: 6027
		[Token(Token = "0x400178B")]
		[FieldOffset(Offset = "0x58")]
		public string Color;

		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet VehicleContents;

		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		[FieldOffset(Offset = "0x68")]
		public List<SpraySurfaceData> SpraySurfaces;
	}
}
