using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	public class LabOvenSolidTask : Task
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000474")]
		public LabOven Oven
		{
			[Token(Token = "0x6001727")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001728")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00009870 File Offset: 0x00007A70
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000475")]
		public LabOvenSolidTask.EStep CurrentStep
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x5B5870", Offset = "0x5B4A70", VA = "0x1805B5870")]
			[CompilerGenerated]
			get
			{
				return LabOvenSolidTask.EStep.OpenDoor;
			}
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x5B5880", Offset = "0x5B4A80", VA = "0x1805B5880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x5BCC50", Offset = "0x5BBE50", VA = "0x1805BCC50")]
		public LabOvenSolidTask(LabOven oven)
		{
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x5BCB80", Offset = "0x5BBD80", VA = "0x1805BCB80", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x5BC950", Offset = "0x5BBB50", VA = "0x1805BC950", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x5BC530", Offset = "0x5BB730", VA = "0x1805BC530", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x5BBBB0", Offset = "0x5BADB0", VA = "0x1805BBBB0")]
		private void CheckProgress()
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x5BC300", Offset = "0x5BB500", VA = "0x1805BC300")]
		private void ProgressStep()
		{
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x5BBFA0", Offset = "0x5BB1A0", VA = "0x1805BBFA0")]
		private void CheckStep_OpenDoor()
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x5BC040", Offset = "0x5BB240", VA = "0x1805BC040")]
		private void CheckStep_PlaceItems()
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x5BBF10", Offset = "0x5BB110", VA = "0x1805BBF10")]
		private void CheckStep_CloseDoor()
		{
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x5BC200", Offset = "0x5BB400", VA = "0x1805BC200")]
		private void CheckStep_PressButton()
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x5BC240", Offset = "0x5BB440", VA = "0x1805BC240")]
		public static string GetStepInstruction(LabOvenSolidTask.EStep step)
		{
			return null;
		}

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0xB0")]
		private ItemInstance ingredient;

		// Token: 0x0400146B RID: 5227
		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0xB8")]
		private int ingredientQuantity;

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0xC0")]
		private StationItem[] stationItems;

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0xC8")]
		private Draggable[] stationDraggables;

		// Token: 0x02000399 RID: 921
		[Token(Token = "0x2000399")]
		public enum EStep
		{
			// Token: 0x0400146F RID: 5231
			[Token(Token = "0x400146F")]
			OpenDoor,
			// Token: 0x04001470 RID: 5232
			[Token(Token = "0x4001470")]
			PlaceItems,
			// Token: 0x04001471 RID: 5233
			[Token(Token = "0x4001471")]
			CloseDoor,
			// Token: 0x04001472 RID: 5234
			[Token(Token = "0x4001472")]
			PressButton
		}
	}
}
