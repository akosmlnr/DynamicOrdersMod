using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	public class UseChemistryStationTask : Task
	{
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x000098E8 File Offset: 0x00007AE8
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000482")]
		public ChemistryStation.EStep CurrentStep
		{
			[Token(Token = "0x6001776")]
			[Address(RVA = "0x5CC030", Offset = "0x5CB230", VA = "0x1805CC030")]
			[CompilerGenerated]
			get
			{
				return ChemistryStation.EStep.CombineIngredients;
			}
			[Token(Token = "0x6001777")]
			[Address(RVA = "0x5CC040", Offset = "0x5CB240", VA = "0x1805CC040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000483")]
		public ChemistryStation Station
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x4B47C0", Offset = "0x4B39C0", VA = "0x1804B47C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001779")]
			[Address(RVA = "0x4B5340", Offset = "0x4B4540", VA = "0x1804B5340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public StationRecipe Recipe
		{
			[Token(Token = "0x600177A")]
			[Address(RVA = "0x4B4770", Offset = "0x4B3970", VA = "0x1804B4770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600177B")]
			[Address(RVA = "0x4B52A0", Offset = "0x4B44A0", VA = "0x1804B52A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x5CA340", Offset = "0x5C9540", VA = "0x1805CA340")]
		public static string GetStepDescription(ChemistryStation.EStep step)
		{
			return null;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x5CB3F0", Offset = "0x5CA5F0", VA = "0x1805CB3F0")]
		public UseChemistryStationTask(ChemistryStation station, StationRecipe recipe)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x5CB3C0", Offset = "0x5CA5C0", VA = "0x1805CB3C0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x5CB180", Offset = "0x5CA380", VA = "0x1805CB180")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x5C98A0", Offset = "0x5C8AA0", VA = "0x1805C98A0")]
		private void CheckProgress()
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x5CA480", Offset = "0x5C9680", VA = "0x1805CA480")]
		private void ProgressStep()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x5C9A40", Offset = "0x5C8C40", VA = "0x1805C9A40")]
		private void CheckStep_CombineIngredients()
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x5CA150", Offset = "0x5C9350", VA = "0x1805CA150")]
		private void CheckStep_StirMixture()
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x5C9CB0", Offset = "0x5C8EB0", VA = "0x1805C9CB0")]
		private void CheckStep_LowerBoilingFlask()
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x5C9D40", Offset = "0x5C8F40", VA = "0x1805C9D40")]
		private void CheckStep_PourIntoBoilingFlask()
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x5C9DD0", Offset = "0x5C8FD0", VA = "0x1805C9DD0")]
		private void CheckStep_RaiseBoilingFlask()
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x5C9E60", Offset = "0x5C9060", VA = "0x1805C9E60")]
		private void CheckStep_StartHeat()
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x5CAEE0", Offset = "0x5CA0E0", VA = "0x1805CAEE0", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x5CA950", Offset = "0x5C9B50", VA = "0x1805CA950", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		public const float STIR_TIME = 1.5f;

		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		public const float TEMPERATURE_TIME = 2f;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0xB8")]
		private Beaker beaker;

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0xC0")]
		private StirringRod stirringRod;

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0xC8")]
		private List<StationItem> items;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0xD0")]
		private List<IngredientPiece> ingredientPieces;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0xD8")]
		private float stirProgress;

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0xDC")]
		private float timeInTemperatureRange;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0xE0")]
		private ItemInstance[] RemovedIngredients;
	}
}
