using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	[Serializable]
	public struct FullRank
	{
		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x53E580", Offset = "0x53D780", VA = "0x18053E580")]
		public FullRank(ERank rank, int tier)
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x670F40", Offset = "0x670140", VA = "0x180670F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x670ED0", Offset = "0x6700D0", VA = "0x180670ED0")]
		public FullRank NextRank()
		{
			return default(FullRank);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x670F20", Offset = "0x670120", VA = "0x180670F20")]
		public float ToFloat()
		{
			return 0f;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x670D60", Offset = "0x66FF60", VA = "0x180670D60")]
		public int GetRankIndex()
		{
			return 0;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x670D70", Offset = "0x66FF70", VA = "0x180670D70")]
		public static string GetString(FullRank rank)
		{
			return null;
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x6710E0", Offset = "0x6702E0", VA = "0x1806710E0")]
		public static bool operator >(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x671160", Offset = "0x670360", VA = "0x180671160")]
		public static bool operator <(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x671120", Offset = "0x670320", VA = "0x180671120")]
		public static bool operator <=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x6710A0", Offset = "0x6702A0", VA = "0x1806710A0")]
		public static bool operator >=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x50C400", Offset = "0x50B600", VA = "0x18050C400")]
		public static bool operator ==(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x671100", Offset = "0x670300", VA = "0x180671100")]
		public static bool operator !=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x670C70", Offset = "0x66FE70", VA = "0x180670C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x670D10", Offset = "0x66FF10", VA = "0x180670D10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x670C20", Offset = "0x66FE20", VA = "0x180670C20")]
		public int CompareTo(FullRank other)
		{
			return 0;
		}

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		public const int TIER_COUNT = 5;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x0")]
		public ERank Rank;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x4")]
		[Range(1f, 5f)]
		public int Tier;
	}
}
