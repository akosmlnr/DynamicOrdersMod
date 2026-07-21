using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	public static class ItemQuality
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x6C5580", Offset = "0x6C4780", VA = "0x1806C5580")]
		public static EQuality GetQuality(float qualityScalar)
		{
			return EQuality.Trash;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x6C55C0", Offset = "0x6C47C0", VA = "0x1806C55C0")]
		public static EQuality ShiftQuality(EQuality baseQuality, int shiftAmount)
		{
			return EQuality.Trash;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x6C53B0", Offset = "0x6C45B0", VA = "0x1806C53B0")]
		public static Color GetColor(EQuality quality)
		{
			return default(Color);
		}

		// Token: 0x04001E63 RID: 7779
		[Token(Token = "0x4001E63")]
		public const float Heavenly_Threshold = 0.9f;

		// Token: 0x04001E64 RID: 7780
		[Token(Token = "0x4001E64")]
		public const float Premium_Threshold = 0.75f;

		// Token: 0x04001E65 RID: 7781
		[Token(Token = "0x4001E65")]
		public const float Standard_Threshold = 0.4f;

		// Token: 0x04001E66 RID: 7782
		[Token(Token = "0x4001E66")]
		public const float Poor_Threshold = 0.25f;

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x0")]
		public static Color Heavenly_Color;

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		[FieldOffset(Offset = "0x10")]
		public static Color Premium_Color;

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x20")]
		public static Color Standard_Color;

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x30")]
		public static Color Poor_Color;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x40")]
		public static Color Trash_Color;
	}
}
