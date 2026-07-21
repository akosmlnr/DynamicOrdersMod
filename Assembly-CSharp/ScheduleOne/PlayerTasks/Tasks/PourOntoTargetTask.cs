using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class PourOntoTargetTask : GrowContainerPourTask
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x5D7980", Offset = "0x5D6B80", VA = "0x1805D7980")]
		public PourOntoTargetTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x5D7840", Offset = "0x5D6A40", VA = "0x1805D7840", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x5D7760", Offset = "0x5D6960", VA = "0x1805D7760", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x5D77A0", Offset = "0x5D69A0", VA = "0x1805D77A0", Slot = "19")]
		public virtual void TargetReached()
		{
		}

		// Token: 0x040014C1 RID: 5313
		[Token(Token = "0x40014C1")]
		[FieldOffset(Offset = "0xD0")]
		public float SUCCESS_THRESHOLD;

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		[FieldOffset(Offset = "0xD4")]
		public float SUCCESS_TIME;

		// Token: 0x040014C3 RID: 5315
		[Token(Token = "0x40014C3")]
		[FieldOffset(Offset = "0xD8")]
		private float timeOverTarget;
	}
}
