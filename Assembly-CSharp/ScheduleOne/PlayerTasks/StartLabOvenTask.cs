using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200039D RID: 925
	[Token(Token = "0x200039D")]
	public class StartLabOvenTask : Task
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000479")]
		public LabOven Oven
		{
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00009888 File Offset: 0x00007A88
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public StartLabOvenTask.EStep CurrentStep
		{
			[Token(Token = "0x600174C")]
			[Address(RVA = "0x5B5870", Offset = "0x5B4A70", VA = "0x1805B5870")]
			[CompilerGenerated]
			get
			{
				return StartLabOvenTask.EStep.OpenDoor;
			}
			[Token(Token = "0x600174D")]
			[Address(RVA = "0x5B5880", Offset = "0x5B4A80", VA = "0x1805B5880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x5C4CF0", Offset = "0x5C3EF0", VA = "0x1805C4CF0")]
		public StartLabOvenTask(LabOven oven)
		{
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x5C4A90", Offset = "0x5C3C90", VA = "0x1805C4A90", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x5C4860", Offset = "0x5C3A60", VA = "0x1805C4860", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x5C4440", Offset = "0x5C3640", VA = "0x1805C4440", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001752")]
		[Address(RVA = "0x5C3E60", Offset = "0x5C3060", VA = "0x1805C3E60")]
		private void CheckProgress()
		{
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x5C42C0", Offset = "0x5C34C0", VA = "0x1805C42C0")]
		private void ProgressStep()
		{
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x5C4090", Offset = "0x5C3290", VA = "0x1805C4090")]
		private void CheckStep_OpenDoor()
		{
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x5C4130", Offset = "0x5C3330", VA = "0x1805C4130")]
		private void CheckStep_Pour()
		{
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x5C4000", Offset = "0x5C3200", VA = "0x1805C4000")]
		private void CheckStep_CloseDoor()
		{
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x5C4150", Offset = "0x5C3350", VA = "0x1805C4150")]
		private void CheckStep_PressButton()
		{
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x5C4250", Offset = "0x5C3450", VA = "0x1805C4250")]
		private IEnumerator PlayPourAnimation()
		{
			return null;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x5C4190", Offset = "0x5C3390", VA = "0x1805C4190")]
		public static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			return null;
		}

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0xB0")]
		private ItemInstance ingredient;

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0xB8")]
		private Coroutine pourRoutine;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0xC0")]
		private StationItem stationItem;

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0xC8")]
		private PourableModule pourableModule;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0xD0")]
		private bool pourAnimDone;

		// Token: 0x0200039E RID: 926
		[Token(Token = "0x200039E")]
		public enum EStep
		{
			// Token: 0x0400148C RID: 5260
			[Token(Token = "0x400148C")]
			OpenDoor,
			// Token: 0x0400148D RID: 5261
			[Token(Token = "0x400148D")]
			Pour,
			// Token: 0x0400148E RID: 5262
			[Token(Token = "0x400148E")]
			CloseDoor,
			// Token: 0x0400148F RID: 5263
			[Token(Token = "0x400148F")]
			PressButton
		}
	}
}
