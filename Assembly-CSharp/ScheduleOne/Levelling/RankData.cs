using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005AE RID: 1454
	[Token(Token = "0x20005AE")]
	public class RankData : SaveData
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216B")]
		[Address(RVA = "0x684420", Offset = "0x683620", VA = "0x180684420")]
		public RankData(int rank, int tier, int xp, int totalXP, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x04001B18 RID: 6936
		[Token(Token = "0x4001B18")]
		[FieldOffset(Offset = "0x28")]
		public int Rank;

		// Token: 0x04001B19 RID: 6937
		[Token(Token = "0x4001B19")]
		[FieldOffset(Offset = "0x2C")]
		public int Tier;

		// Token: 0x04001B1A RID: 6938
		[Token(Token = "0x4001B1A")]
		[FieldOffset(Offset = "0x30")]
		public int XP;

		// Token: 0x04001B1B RID: 6939
		[Token(Token = "0x4001B1B")]
		[FieldOffset(Offset = "0x34")]
		public int TotalXP;

		// Token: 0x04001B1C RID: 6940
		[Token(Token = "0x4001B1C")]
		[FieldOffset(Offset = "0x38")]
		public List<EMapRegion> UnlockedRegions;
	}
}
