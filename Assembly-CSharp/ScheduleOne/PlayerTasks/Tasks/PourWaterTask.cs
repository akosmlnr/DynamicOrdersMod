using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public class PourWaterTask : PourOntoTargetTask
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x1700048A")]
		protected override bool UseCoverage
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x1700048B")]
		protected override bool FailOnEmpty
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x1700048C")]
		protected override GrowContainerCameraHandler.ECameraPosition CameraPosition
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x5B1DD0", Offset = "0x5B0FD0", VA = "0x1805B1DD0", Slot = "16")]
			get
			{
				return GrowContainerCameraHandler.ECameraPosition.Closeup;
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x5D8630", Offset = "0x5D7830", VA = "0x1805D8630")]
		public PourWaterTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x5D8320", Offset = "0x5D7520", VA = "0x1805D8320", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x5D83E0", Offset = "0x5D75E0", VA = "0x1805D83E0", Slot = "19")]
		public override void TargetReached()
		{
		}

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		public const float NORMALIZED_FILL_PER_TARGET = 0.2f;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0x0")]
		public static bool hintShown;
	}
}
