using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public class SewerData : SaveData
	{
		// Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x618070", Offset = "0x617270", VA = "0x180618070")]
		public SewerData(bool isSewerUnlocked, bool isRandomWorldKeyCollected, int randomSewerKeyLocationIndex, bool hasSewerKingBeenDefeated, int hoursSinceLastSewerGoblinAppearance, int randomKeyPossessorIndex, List<int> activeMushroomLocationIndices)
		{
		}

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x28")]
		public bool IsSewerUnlocked;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x29")]
		public bool IsRandomWorldKeyCollected;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x2C")]
		public int RandomSewerKeyLocationIndex;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x30")]
		public bool HasSewerKingBeenDefeated;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x34")]
		public int HoursSinceLastSewerGoblinAppearance;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x38")]
		public int RandomKeyPossessorIndex;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x3C")]
		public bool RandomKeyPossessorSet;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x40")]
		public List<int> ActiveMushroomLocationIndices;
	}
}
