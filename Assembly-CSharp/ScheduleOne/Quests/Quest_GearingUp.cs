using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public class Quest_GearingUp : Quest
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x5A7800", Offset = "0x5A6A00", VA = "0x1805A7800", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x5A7510", Offset = "0x5A6710", VA = "0x1805A7510", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x5A74C0", Offset = "0x5A66C0", VA = "0x1805A74C0")]
		private void DropReady()
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x5A78B0", Offset = "0x5A6AB0", VA = "0x1805A78B0")]
		public Quest_GearingUp()
		{
		}

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry WaitForDropEntry;

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry CollectDropEntry;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x148")]
		public Supplier Supplier;

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x150")]
		private bool setCollectionPosition;
	}
}
