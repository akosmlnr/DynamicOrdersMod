using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x615270", Offset = "0x614470", VA = "0x180615270")]
		public PlantData(string seedID, float growthProgress, int[] activeBuds)
		{
		}

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x28")]
		public string SeedID;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x30")]
		public float GrowthProgress;

		// Token: 0x04001724 RID: 5924
		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x38")]
		public int[] ActiveBuds;
	}
}
