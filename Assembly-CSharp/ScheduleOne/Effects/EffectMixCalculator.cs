using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B8A RID: 2954
	[Token(Token = "0x2000B8A")]
	public static class EffectMixCalculator
	{
		// Token: 0x060057F6 RID: 22518 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x994A90", Offset = "0x993C90", VA = "0x180994A90")]
		public static List<Effect> MixProperties(List<Effect> existingProperties, Effect newProperty, EDrugType drugType)
		{
			return null;
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F7")]
		public static void Shuffle<T>(List<T> list, int seed)
		{
		}

		// Token: 0x04003A5F RID: 14943
		[Token(Token = "0x4003A5F")]
		public const int MAX_PROPERTIES = 8;

		// Token: 0x04003A60 RID: 14944
		[Token(Token = "0x4003A60")]
		public const float MAX_DELTA_DIFFERENCE = 0.5f;

		// Token: 0x02000B8B RID: 2955
		[Token(Token = "0x2000B8B")]
		private class Reaction
		{
			// Token: 0x060057F8 RID: 22520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60057F8")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Reaction()
			{
			}

			// Token: 0x04003A61 RID: 14945
			[Token(Token = "0x4003A61")]
			[FieldOffset(Offset = "0x10")]
			public Effect Existing;

			// Token: 0x04003A62 RID: 14946
			[Token(Token = "0x4003A62")]
			[FieldOffset(Offset = "0x18")]
			public Effect Output;
		}
	}
}
