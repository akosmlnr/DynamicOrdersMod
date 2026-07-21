using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[Serializable]
	public class ShroomColonyData
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x618160", Offset = "0x617360", VA = "0x180618160")]
		public ShroomColonyData(string mushroomSpawnID, float growthProgress, float quality, int[] activeMushroomAlignmentIndices)
		{
		}

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x10")]
		public string MushroomSpawnID;

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x18")]
		public float GrowthProgress;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x1C")]
		public float Quality;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x20")]
		public int[] ActiveMushroomAlignmentIndices;
	}
}
