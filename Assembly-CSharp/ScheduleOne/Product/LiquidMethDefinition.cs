using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	[CreateAssetMenu(fileName = "LiquidMethDefinition", menuName = "ScriptableObjects/LiquidMethDefinition", order = 1)]
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x82D3C0", Offset = "0x82C5C0", VA = "0x18082D3C0")]
		public LiquidMethDefinition()
		{
		}

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Liquid Meth Color Settings")]
		public Color StaticLiquidColor;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0xD0")]
		public Color LiquidVolumeColor;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0xE0")]
		public Color PourParticlesColor;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0xF0")]
		public Color CookableLiquidColor;

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x100")]
		public Color CookableSolidColor;
	}
}
