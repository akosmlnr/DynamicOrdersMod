using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public class UseMixingStationTask : Task
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048D")]
		public MixingStation Station
		{
			[Token(Token = "0x60017AC")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00009990 File Offset: 0x00007B90
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048E")]
		public UseMixingStationTask.EStep CurrentStep
		{
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x5B5870", Offset = "0x5B4A70", VA = "0x1805B5870")]
			[CompilerGenerated]
			get
			{
				return UseMixingStationTask.EStep.CombineIngredients;
			}
			[Token(Token = "0x60017AF")]
			[Address(RVA = "0x5B5880", Offset = "0x5B4A80", VA = "0x1805B5880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x5DE6F0", Offset = "0x5DD8F0", VA = "0x1805DE6F0")]
		public static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			return null;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x5DF860", Offset = "0x5DEA60", VA = "0x1805DF860")]
		public UseMixingStationTask(MixingStation station)
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x5DDD40", Offset = "0x5DCF40", VA = "0x1805DDD40")]
		private Beaker CreateJug()
		{
			return null;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x5DF760", Offset = "0x5DE960", VA = "0x1805DF760", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x5DF520", Offset = "0x5DE720", VA = "0x1805DF520")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x5DDB80", Offset = "0x5DCD80", VA = "0x1805DDB80")]
		private void CheckProgress()
		{
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x5DDC60", Offset = "0x5DCE60", VA = "0x1805DDC60")]
		private void CheckStep_CombineIngredients()
		{
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x5DE410", Offset = "0x5DD610", VA = "0x1805DE410")]
		private int GetCombinedIngredients()
		{
			return 0;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x5DE760", Offset = "0x5DD960", VA = "0x1805DE760")]
		private void ProgressStep()
		{
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x5B4360", Offset = "0x5B3560", VA = "0x1805B4360")]
		private void StartButtonPressed()
		{
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x5DEC40", Offset = "0x5DDE40", VA = "0x1805DEC40", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x5DDF20", Offset = "0x5DD120", VA = "0x1805DDF20")]
		private void CreateTrash()
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x5DE7A0", Offset = "0x5DD9A0", VA = "0x1805DE7A0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x5DEE20", Offset = "0x5DE020", VA = "0x1805DEE20")]
		[CompilerGenerated]
		private void <.ctor>g__SetupIngredient|15_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.<>c__DisplayClass15_0 A_4)
		{
		}

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0xB0")]
		private List<StationItem> items;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0xB8")]
		private List<StationItem> mixerItems;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0xC0")]
		private List<IngredientPiece> ingredientPieces;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0xC8")]
		private ItemInstance[] removedIngredients;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		[FieldOffset(Offset = "0xD0")]
		private Beaker Jug;

		// Token: 0x020003AB RID: 939
		[Token(Token = "0x20003AB")]
		public enum EStep
		{
			// Token: 0x040014D2 RID: 5330
			[Token(Token = "0x40014D2")]
			CombineIngredients,
			// Token: 0x040014D3 RID: 5331
			[Token(Token = "0x40014D3")]
			StartMixing
		}
	}
}
