using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000478 RID: 1144
	[Token(Token = "0x2000478")]
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x616C50", Offset = "0x615E50", VA = "0x180616C50")]
		public RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType)
		{
		}

		// Token: 0x0400167D RID: 5757
		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x28")]
		public float RelationDelta;

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0x2C")]
		public bool Unlocked;

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x30")]
		public NPCRelationData.EUnlockType UnlockType;
	}
}
