using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	public class InocculateGrainBagTask : Task
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000473")]
		public override string TaskName
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600171E")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171F")]
		[Address(RVA = "0x5BB5E0", Offset = "0x5BA7E0", VA = "0x1805BB5E0")]
		public InocculateGrainBagTask(MushroomSpawnStation station)
		{
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x5BB2D0", Offset = "0x5BA4D0", VA = "0x1805BB2D0", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001721")]
		[Address(RVA = "0x5BB1C0", Offset = "0x5BA3C0", VA = "0x1805BB1C0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x5BB490", Offset = "0x5BA690", VA = "0x1805BB490", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001723")]
		[Address(RVA = "0x5BAF70", Offset = "0x5BA170", VA = "0x1805BAF70")]
		private string GetInstructionForStage(InocculateGrainBagTask.EStage stage)
		{
			return null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x5BB120", Offset = "0x5BA320", VA = "0x1805BB120")]
		private void OnSyringeCapRemoved()
		{
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x5BB170", Offset = "0x5BA370", VA = "0x1805BB170")]
		private void OnSyringeInserted()
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x5BB0C0", Offset = "0x5BA2C0", VA = "0x1805BB0C0")]
		private void OnPlungerPushed(float amount)
		{
		}

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0xA8")]
		private MushroomSpawnStation _station;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0xB0")]
		private MushroomSpawnStationItem _spawn;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0xB8")]
		private SporeSyringeStationItem _syringe;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0xC0")]
		private InocculateGrainBagTask.EStage _currentStage;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0xC8")]
		private ItemInstance _grainBagInstance;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0xD0")]
		private ItemInstance _syringeInstance;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0xD8")]
		private ShroomSpawnDefinition _spawnDefinition;

		// Token: 0x02000397 RID: 919
		[Token(Token = "0x2000397")]
		public enum EStage
		{
			// Token: 0x04001465 RID: 5221
			[Token(Token = "0x4001465")]
			RemoveCap,
			// Token: 0x04001466 RID: 5222
			[Token(Token = "0x4001466")]
			InsertSyringe,
			// Token: 0x04001467 RID: 5223
			[Token(Token = "0x4001467")]
			PushPlunger
		}
	}
}
