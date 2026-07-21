using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	[Serializable]
	public class ParkData
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0xAF7F10", Offset = "0xAF7110", VA = "0x180AF7F10")]
		public ParkData(Guid lotGUID, int spotIndex, EParkingAlignment alignment)
		{
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ParkData()
		{
		}

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x10")]
		public Guid lotGUID;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x20")]
		public int spotIndex;

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x24")]
		public EParkingAlignment alignment;
	}
}
