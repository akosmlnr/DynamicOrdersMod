using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x6166F0", Offset = "0x6158F0", VA = "0x1806166F0")]
		public ProductManagerData(string[] discoveredProducts, string[] listedProducts, NewMixOperation activeOperation, bool isMixComplete, MixRecipeData[] mixRecipes, StringIntPair[] productPrices, string[] favouritedProducts, WeedProductData[] createdWeed, MethProductData[] createdMeth, CocaineProductData[] createdCocaine, ShroomProductData[] createdShrooms, ContractReceipt[] receipts)
		{
		}

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x28")]
		public string[] DiscoveredProducts;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x30")]
		public string[] ListedProducts;

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x38")]
		public NewMixOperation ActiveMixOperation;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x40")]
		public bool IsMixComplete;

		// Token: 0x04001735 RID: 5941
		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x48")]
		public MixRecipeData[] MixRecipes;

		// Token: 0x04001736 RID: 5942
		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0x50")]
		public StringIntPair[] ProductPrices;

		// Token: 0x04001737 RID: 5943
		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x58")]
		public string[] FavouritedProducts;

		// Token: 0x04001738 RID: 5944
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x60")]
		public WeedProductData[] CreatedWeed;

		// Token: 0x04001739 RID: 5945
		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x68")]
		public MethProductData[] CreatedMeth;

		// Token: 0x0400173A RID: 5946
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x70")]
		public CocaineProductData[] CreatedCocaine;

		// Token: 0x0400173B RID: 5947
		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0x78")]
		public ShroomProductData[] CreatedShrooms;

		// Token: 0x0400173C RID: 5948
		[Token(Token = "0x400173C")]
		[FieldOffset(Offset = "0x80")]
		public ContractReceipt[] ContractReceipts;
	}
}
