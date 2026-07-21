using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public class RelationshipCategory
	{
		// Token: 0x06004D30 RID: 19760 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x942260", Offset = "0x941460", VA = "0x180942260")]
		public static ERelationshipCategory GetCategory(float delta)
		{
			return ERelationshipCategory.Hostile;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x9422A0", Offset = "0x9414A0", VA = "0x1809422A0")]
		public static Color32 GetColor(ERelationshipCategory category)
		{
			return default(Color32);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public RelationshipCategory()
		{
		}

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 Hostile_Color;

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 Unfriendly_Color;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0x8")]
		public static Color32 Neutral_Color;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0xC")]
		public static Color32 Friendly_Color;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x10")]
		public static Color32 Loyal_Color;
	}
}
