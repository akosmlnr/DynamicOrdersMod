using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E0D RID: 3597
	[Token(Token = "0x2000E0D")]
	public class ClothingShopListing : ShopListing
	{
		// Token: 0x06006732 RID: 26418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006732")]
		[Address(RVA = "0xAA2610", Offset = "0xAA1810", VA = "0x180AA2610")]
		public ClothingShopListing()
		{
		}

		// Token: 0x040048BB RID: 18619
		[Token(Token = "0x40048BB")]
		[FieldOffset(Offset = "0xA8")]
		public EClothingColor Color;
	}
}
