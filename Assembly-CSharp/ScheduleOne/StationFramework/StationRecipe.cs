using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008F7 RID: 2295
	[Token(Token = "0x20008F7")]
	[CreateAssetMenu(fileName = "StationRecipe", menuName = "StationFramework/StationRecipe", order = 1)]
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x170009AF")]
		public float CookTemperatureLowerBound
		{
			[Token(Token = "0x6003D95")]
			[Address(RVA = "0x84F100", Offset = "0x84E300", VA = "0x18084F100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x170009B0")]
		public float CookTemperatureUpperBound
		{
			[Token(Token = "0x6003D96")]
			[Address(RVA = "0x84F110", Offset = "0x84E310", VA = "0x18084F110")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009B1")]
		public string RecipeID
		{
			[Token(Token = "0x6003D97")]
			[Address(RVA = "0x84F120", Offset = "0x84E320", VA = "0x18084F120")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x84EDA0", Offset = "0x84DFA0", VA = "0x18084EDA0")]
		public StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			return null;
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x84EF20", Offset = "0x84E120", VA = "0x18084EF20")]
		public StorableItemInstance GetProductInstance(EQuality quality)
		{
			return null;
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x84EA50", Offset = "0x84DC50", VA = "0x18084EA50")]
		public bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			return default(bool);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x84E840", Offset = "0x84DA40", VA = "0x18084E840")]
		public EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			return EQuality.Trash;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x84F060", Offset = "0x84E260", VA = "0x18084F060")]
		public StationRecipe()
		{
		}

		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool IsDiscovered;

		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		[FieldOffset(Offset = "0x20")]
		public string RecipeTitle;

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x28")]
		public bool Unlocked;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x30")]
		public List<StationRecipe.IngredientQuantity> Ingredients;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x38")]
		public StationRecipe.ItemQuantity Product;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x40")]
		public Color FinalLiquidColor;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The time it takes to cook this recipe in minutes")]
		public int CookTime_Mins;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The temperature at which this recipe should be cooked")]
		[Range(0f, 500f)]
		public float CookTemperature;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 100f)]
		public float CookTemperatureTolerance;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x5C")]
		public StationRecipe.EQualityCalculationMethod QualityCalculationMethod;

		// Token: 0x020008F8 RID: 2296
		[Token(Token = "0x20008F8")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x04002D22 RID: 11554
			[Token(Token = "0x4002D22")]
			Additive
		}

		// Token: 0x020008F9 RID: 2297
		[Token(Token = "0x20008F9")]
		[Serializable]
		public class ItemQuantity
		{
			// Token: 0x06003D9D RID: 15773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x82D180", Offset = "0x82C380", VA = "0x18082D180")]
			public ItemQuantity()
			{
			}

			// Token: 0x04002D23 RID: 11555
			[Token(Token = "0x4002D23")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Item;

			// Token: 0x04002D24 RID: 11556
			[Token(Token = "0x4002D24")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		[Serializable]
		public class IngredientQuantity
		{
			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x06003D9E RID: 15774 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170009B2")]
			public ItemDefinition Item
			{
				[Token(Token = "0x6003D9E")]
				[Address(RVA = "0x82D140", Offset = "0x82C340", VA = "0x18082D140")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003D9F RID: 15775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D9F")]
			[Address(RVA = "0x82D0C0", Offset = "0x82C2C0", VA = "0x18082D0C0")]
			public IngredientQuantity()
			{
			}

			// Token: 0x04002D25 RID: 11557
			[Token(Token = "0x4002D25")]
			[FieldOffset(Offset = "0x10")]
			public List<ItemDefinition> Items;

			// Token: 0x04002D26 RID: 11558
			[Token(Token = "0x4002D26")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}
	}
}
