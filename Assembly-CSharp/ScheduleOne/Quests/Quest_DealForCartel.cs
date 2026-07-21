using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;

namespace ScheduleOne.Quests
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	public class Quest_DealForCartel : Quest
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x5A5D20", Offset = "0x5A4F20", VA = "0x1805A5D20")]
		public void Initialize(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x5A5C50", Offset = "0x5A4E50", VA = "0x1805A5C50", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x5A6080", Offset = "0x5A5280", VA = "0x1805A6080", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x5A60B0", Offset = "0x5A52B0", VA = "0x1805A60B0")]
		private void UpdateTimingLabel()
		{
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x5A6000", Offset = "0x5A5200", VA = "0x1805A6000")]
		public void NotifyDealCompleted()
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x5A6040", Offset = "0x5A5240", VA = "0x1805A6040")]
		public void NotifyTruceEnded()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x5A6500", Offset = "0x5A5700", VA = "0x1805A6500")]
		public Quest_DealForCartel()
		{
		}

		// Token: 0x04001276 RID: 4726
		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry MainEntry;

		// Token: 0x04001277 RID: 4727
		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry EndTruceEntry;

		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x148")]
		private CartelDealInfo dealInfo;
	}
}
