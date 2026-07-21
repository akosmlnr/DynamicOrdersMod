using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E0C RID: 3596
	[Token(Token = "0x2000E0C")]
	public class ClothingShopInterface : ShopInterface
	{
		// Token: 0x0600672C RID: 26412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672C")]
		[Address(RVA = "0xAA2500", Offset = "0xAA1700", VA = "0x180AA2500", Slot = "28")]
		protected override void Start()
		{
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672D")]
		[Address(RVA = "0xAA22A0", Offset = "0xAA14A0", VA = "0x180AA22A0", Slot = "33")]
		public override void ListingClicked(ListingUI listingUI)
		{
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672E")]
		[Address(RVA = "0xAA1B60", Offset = "0xAA0D60", VA = "0x180AA1B60", Slot = "32")]
		protected override void Exit(ExitAction action)
		{
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672F")]
		[Address(RVA = "0xAA1A00", Offset = "0xAA0C00", VA = "0x180AA1A00")]
		private void ColorPicked(EClothingColor color)
		{
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x6006730")]
		[Address(RVA = "0xAA1C80", Offset = "0xAA0E80", VA = "0x180AA1C80", Slot = "34")]
		public override bool HandoverItems()
		{
			return default(bool);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006731")]
		[Address(RVA = "0xAA25C0", Offset = "0xAA17C0", VA = "0x180AA25C0")]
		public ClothingShopInterface()
		{
		}

		// Token: 0x040048B9 RID: 18617
		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x160")]
		public ShopColorPicker ColorPicker;

		// Token: 0x040048BA RID: 18618
		[Token(Token = "0x40048BA")]
		[FieldOffset(Offset = "0x168")]
		private ShopListing _selectedListing;
	}
}
