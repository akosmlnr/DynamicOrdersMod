using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	public static class ItemSerializers
	{
		// Token: 0x060026EE RID: 9966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x6C5B70", Offset = "0x6C4D70", VA = "0x1806C5B70")]
		public static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x6C59D0", Offset = "0x6C4BD0", VA = "0x1806C59D0")]
		public static ItemInstance ReadItemInstance(this Reader reader)
		{
			return null;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x6C5B70", Offset = "0x6C4D70", VA = "0x1806C5B70")]
		public static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x6C5A70", Offset = "0x6C4C70", VA = "0x1806C5A70")]
		public static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			return null;
		}

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		public const string NullItem = "";
	}
}
