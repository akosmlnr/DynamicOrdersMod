using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[Serializable]
	public class VehicleCollectionData : SaveData
	{
		// Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public VehicleCollectionData(VehicleData[] vehicles)
		{
		}

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x28")]
		public VehicleData[] Vehicles;
	}
}
