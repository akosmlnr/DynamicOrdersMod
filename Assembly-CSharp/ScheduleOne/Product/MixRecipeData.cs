using System;
using Il2CppDummyDll;

namespace ScheduleOne.Product
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	[Serializable]
	public class MixRecipeData
	{
		// Token: 0x06003DE8 RID: 15848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x43FEB0", Offset = "0x43F0B0", VA = "0x18043FEB0")]
		public MixRecipeData(string product, string mixer, string output)
		{
		}

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x10")]
		public string Product;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x18")]
		public string Mixer;

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x20")]
		public string Output;
	}
}
