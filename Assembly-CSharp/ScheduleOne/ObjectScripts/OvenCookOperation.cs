using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009AC RID: 2476
	[Token(Token = "0x20009AC")]
	[Serializable]
	public class OvenCookOperation
	{
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ABD")]
		[CodegenExclude]
		public StorableItemDefinition Ingredient
		{
			[Token(Token = "0x60044B4")]
			[Address(RVA = "0x8B1700", Offset = "0x8B0900", VA = "0x1808B1700")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ABE")]
		[CodegenExclude]
		public StorableItemDefinition Product
		{
			[Token(Token = "0x60044B5")]
			[Address(RVA = "0x8B1810", Offset = "0x8B0A10", VA = "0x1808B1810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ABF")]
		[CodegenExclude]
		public CookableModule Cookable
		{
			[Token(Token = "0x60044B6")]
			[Address(RVA = "0x8B1650", Offset = "0x8B0850", VA = "0x1808B1650")]
			get
			{
				return null;
			}
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B7")]
		[Address(RVA = "0x8B1530", Offset = "0x8B0730", VA = "0x1808B1530")]
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID)
		{
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B8")]
		[Address(RVA = "0x8B15D0", Offset = "0x8B07D0", VA = "0x1808B15D0")]
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress)
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B9")]
		[Address(RVA = "0x8B15B0", Offset = "0x8B07B0", VA = "0x1808B15B0")]
		public OvenCookOperation()
		{
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x8B1520", Offset = "0x8B0720", VA = "0x1808B1520")]
		public void UpdateCookProgress(int change)
		{
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x8B1260", Offset = "0x8B0460", VA = "0x1808B1260")]
		public int GetCookDuration()
		{
			return 0;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x8B14A0", Offset = "0x8B06A0", VA = "0x1808B14A0")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x8B12D0", Offset = "0x8B04D0", VA = "0x1808B12D0")]
		public ItemInstance GetProductItem(int quantity)
		{
			return null;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x8B14A0", Offset = "0x8B06A0", VA = "0x1808B14A0")]
		public bool IsReady()
		{
			return default(bool);
		}

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x10")]
		[CodegenExclude]
		private StorableItemDefinition _itemDefinition;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x18")]
		[CodegenExclude]
		private StorableItemDefinition _productionDefinition;

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x20")]
		[CodegenExclude]
		private CookableModule _cookable;

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x28")]
		public string IngredientID;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x30")]
		public EQuality IngredientQuality;

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x34")]
		public int IngredientQuantity;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x38")]
		public string ProductID;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x40")]
		public int CookProgress;

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0x44")]
		[CodegenExclude]
		private int cookDuration;
	}
}
