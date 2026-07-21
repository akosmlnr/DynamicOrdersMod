using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public static class ClothingColorExtensions
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x75D6F0", Offset = "0x75C8F0", VA = "0x18075D6F0")]
		public static Color GetActualColor(this EClothingColor color)
		{
			return default(Color);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x75DB30", Offset = "0x75CD30", VA = "0x18075DB30")]
		public static Color GetLabelColor(this EClothingColor color)
		{
			return default(Color);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x75DBD0", Offset = "0x75CDD0", VA = "0x18075DBD0")]
		public static string GetLabel(this EClothingColor color)
		{
			return null;
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x75D790", Offset = "0x75C990", VA = "0x18075D790")]
		public static EClothingColor GetClothingColor(Color color)
		{
			return EClothingColor.White;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x75D680", Offset = "0x75C880", VA = "0x18075D680")]
		public static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			return default(bool);
		}
	}
}
