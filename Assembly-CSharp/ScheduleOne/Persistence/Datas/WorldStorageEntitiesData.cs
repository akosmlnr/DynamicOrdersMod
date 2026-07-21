using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[Serializable]
	public class WorldStorageEntitiesData : SaveData
	{
		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public WorldStorageEntitiesData(WorldStorageEntityData[] entities)
		{
		}

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		[FieldOffset(Offset = "0x28")]
		public WorldStorageEntityData[] Entities;
	}
}
