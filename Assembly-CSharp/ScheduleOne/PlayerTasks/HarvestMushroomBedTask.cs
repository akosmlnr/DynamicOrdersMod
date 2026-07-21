using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	public class HarvestMushroomBedTask : Task
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x5B8FC0", Offset = "0x5B81C0", VA = "0x1805B8FC0")]
		public HarvestMushroomBedTask(MushroomBed mushroomBed, bool canDrag, AudioSourceController soundLoopPrefab)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x5B83E0", Offset = "0x5B75E0", VA = "0x1805B83E0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x5B8A40", Offset = "0x5B7C40", VA = "0x1805B8A40", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x5B8850", Offset = "0x5B7A50", VA = "0x1805B8850")]
		private void UpdateInstructionText()
		{
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x5B8740", Offset = "0x5B7940", VA = "0x1805B8740", Slot = "10")]
		protected override void UpdateCursor()
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x5B8220", Offset = "0x5B7420", VA = "0x1805B8220")]
		private GrowingMushroom GetHoveredHarvestable()
		{
			return null;
		}

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0xA0")]
		private AudioSourceController _soundLoop;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0xA8")]
		private MushroomBed _mushroomBed;

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0xB0")]
		protected bool _canDrag;

		// Token: 0x04001452 RID: 5202
		[Token(Token = "0x4001452")]
		[FieldOffset(Offset = "0xB4")]
		private int _harvestCount;

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0xB8")]
		private int _harvestTotal;
	}
}
