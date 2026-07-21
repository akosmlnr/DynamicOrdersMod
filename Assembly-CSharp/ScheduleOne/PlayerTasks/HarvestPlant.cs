using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	public class HarvestPlant : Task
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public override string TaskName
		{
			[Token(Token = "0x6001715")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001716")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x5BA640", Offset = "0x5B9840", VA = "0x1805BA640")]
		public HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab)
		{
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x5B9D50", Offset = "0x5B8F50", VA = "0x1805B9D50")]
		private void UpdateInstructionText()
		{
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x5B9810", Offset = "0x5B8A10", VA = "0x1805B9810", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x5B9C40", Offset = "0x5B8E40", VA = "0x1805B9C40", Slot = "10")]
		protected override void UpdateCursor()
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x5B9FC0", Offset = "0x5B91C0", VA = "0x1805B9FC0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600171C")]
		[Address(RVA = "0x5B9650", Offset = "0x5B8850", VA = "0x1805B9650")]
		private PlantHarvestable GetHoveredHarvestable()
		{
			return null;
		}

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0xA8")]
		protected Pot pot;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0xB0")]
		private int HarvestCount;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0xB4")]
		private int HarvestTotal;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0xB8")]
		private float rotation;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x0")]
		private static bool hintShown;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x1")]
		private static bool CanDrag;

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0xC0")]
		private AudioSourceController SoundLoop;
	}
}
