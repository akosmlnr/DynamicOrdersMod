using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000996 RID: 2454
	[Token(Token = "0x2000996")]
	public class ChemistryCookOperation
	{
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A5E")]
		[CodegenExclude]
		public StationRecipe Recipe
		{
			[Token(Token = "0x6004297")]
			[Address(RVA = "0x87F820", Offset = "0x87EA20", VA = "0x18087F820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x87F7A0", Offset = "0x87E9A0", VA = "0x18087F7A0")]
		public ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x87F730", Offset = "0x87E930", VA = "0x18087F730")]
		public ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ChemistryCookOperation()
		{
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x87F6D0", Offset = "0x87E8D0", VA = "0x18087F6D0")]
		public void Progress(int mins)
		{
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x87F6A0", Offset = "0x87E8A0", VA = "0x18087F6A0")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x10")]
		[CodegenExclude]
		private StationRecipe recipe;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x18")]
		public string RecipeID;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x20")]
		public EQuality ProductQuality;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x24")]
		public Color StartLiquidColor;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x34")]
		public float LiquidLevel;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x38")]
		public int CurrentTime;
	}
}
