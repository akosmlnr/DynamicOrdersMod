using System;
using Il2CppDummyDll;

namespace ScheduleOne.Product
{
	// Token: 0x02000910 RID: 2320
	[Token(Token = "0x2000910")]
	[Serializable]
	public class NewMixOperation
	{
		// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
		public NewMixOperation(string productID, string ingredientID)
		{
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public NewMixOperation()
		{
		}

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x10")]
		public string ProductID;

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x18")]
		public string IngredientID;
	}
}
