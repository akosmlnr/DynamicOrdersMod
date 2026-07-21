using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	public class CookableModule : ItemModule
	{
		// Token: 0x06003C8F RID: 15503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x813F10", Offset = "0x813110", VA = "0x180813F10")]
		public CookableModule()
		{
		}

		// Token: 0x04002C72 RID: 11378
		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x30")]
		[Header("Cook Settings")]
		public int CookTime;

		// Token: 0x04002C73 RID: 11379
		[Token(Token = "0x4002C73")]
		[FieldOffset(Offset = "0x34")]
		public CookableModule.ECookableType CookType;

		// Token: 0x04002C74 RID: 11380
		[Token(Token = "0x4002C74")]
		[FieldOffset(Offset = "0x38")]
		[Header("Product Settings")]
		public StorableItemDefinition Product;

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x40")]
		public int ProductQuantity;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x48")]
		public Rigidbody ProductShardPrefab;

		// Token: 0x04002C77 RID: 11383
		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x50")]
		[Header("Appearance")]
		public Color LiquidColor;

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x60")]
		public Color SolidColor;

		// Token: 0x020008DD RID: 2269
		[Token(Token = "0x20008DD")]
		public enum ECookableType
		{
			// Token: 0x04002C7A RID: 11386
			[Token(Token = "0x4002C7A")]
			Liquid,
			// Token: 0x04002C7B RID: 11387
			[Token(Token = "0x4002C7B")]
			Solid
		}
	}
}
