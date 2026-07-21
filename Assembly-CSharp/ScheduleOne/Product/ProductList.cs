using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Product
{
	// Token: 0x02000919 RID: 2329
	[Token(Token = "0x2000919")]
	[Serializable]
	public class ProductList
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x83ACD0", Offset = "0x839ED0", VA = "0x18083ACD0")]
		public ProductList()
		{
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x83A540", Offset = "0x839740", VA = "0x18083A540")]
		public string GetCommaSeperatedString()
		{
			return null;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x83A7B0", Offset = "0x8399B0", VA = "0x18083A7B0")]
		public string GetLineSeperatedString()
		{
			return null;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x83A9D0", Offset = "0x839BD0", VA = "0x18083A9D0")]
		public string GetQualityString()
		{
			return null;
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x6003E41")]
		[Address(RVA = "0x83ABA0", Offset = "0x839DA0", VA = "0x18083ABA0")]
		public int GetTotalQuantity()
		{
			return 0;
		}

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0x10")]
		public List<ProductList.Entry> entries;

		// Token: 0x0200091A RID: 2330
		[Token(Token = "0x200091A")]
		[Serializable]
		public class Entry
		{
			// Token: 0x06003E42 RID: 15938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E42")]
			[Address(RVA = "0x82C4E0", Offset = "0x82B6E0", VA = "0x18082C4E0")]
			public Entry(string productID, EQuality quality, int quantity)
			{
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E43")]
			[Address(RVA = "0x82C540", Offset = "0x82B740", VA = "0x18082C540")]
			public Entry()
			{
			}

			// Token: 0x04002D9C RID: 11676
			[Token(Token = "0x4002D9C")]
			[FieldOffset(Offset = "0x10")]
			public string ProductID;

			// Token: 0x04002D9D RID: 11677
			[Token(Token = "0x4002D9D")]
			[FieldOffset(Offset = "0x18")]
			public EQuality Quality;

			// Token: 0x04002D9E RID: 11678
			[Token(Token = "0x4002D9E")]
			[FieldOffset(Offset = "0x1C")]
			public int Quantity;
		}
	}
}
