using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public class CauldronTask : Task
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046A")]
		public Cauldron Cauldron
		{
			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00009828 File Offset: 0x00007A28
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046B")]
		public CauldronTask.EStep CurrentStep
		{
			[Token(Token = "0x60016E6")]
			[Address(RVA = "0x5B5870", Offset = "0x5B4A70", VA = "0x1805B5870")]
			[CompilerGenerated]
			get
			{
				return CauldronTask.EStep.CombineIngredients;
			}
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x5B5880", Offset = "0x5B4A80", VA = "0x1805B5880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x5B42F0", Offset = "0x5B34F0", VA = "0x1805B42F0")]
		public static string GetStepDescription(CauldronTask.EStep step)
		{
			return null;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x5B4E10", Offset = "0x5B4010", VA = "0x1805B4E10")]
		public CauldronTask(Cauldron caudron)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x5B4A60", Offset = "0x5B3C60", VA = "0x1805B4A60", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x5B46E0", Offset = "0x5B38E0", VA = "0x1805B46E0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x5B4C30", Offset = "0x5B3E30", VA = "0x1805B4C30", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x5B4040", Offset = "0x5B3240", VA = "0x1805B4040")]
		private void CheckProgress()
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x5B41A0", Offset = "0x5B33A0", VA = "0x1805B41A0")]
		private void CheckStep_CombineIngredients()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x5B4380", Offset = "0x5B3580", VA = "0x1805B4380")]
		private void StartMixing()
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x5B4BB0", Offset = "0x5B3DB0", VA = "0x1805B4BB0")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x5B4360", Offset = "0x5B3560", VA = "0x1805B4360")]
		private void StartButtonPressed()
		{
		}

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0xB0")]
		private StationItem[] CocaLeaves;

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0xB8")]
		private StationItem Gasoline;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0xC0")]
		private Draggable Tub;

		// Token: 0x0200038E RID: 910
		[Token(Token = "0x200038E")]
		public enum EStep
		{
			// Token: 0x0400143A RID: 5178
			[Token(Token = "0x400143A")]
			CombineIngredients,
			// Token: 0x0400143B RID: 5179
			[Token(Token = "0x400143B")]
			StartMixing
		}
	}
}
