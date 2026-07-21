using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	public class SowSeedTask : Task
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000478")]
		public override string TaskName
		{
			[Token(Token = "0x6001742")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x5C2150", Offset = "0x5C1350", VA = "0x1805C2150")]
		public SowSeedTask(Pot _pot, SeedDefinition def)
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x5C1D00", Offset = "0x5C0F00", VA = "0x1805C1D00", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x5C1910", Offset = "0x5C0B10", VA = "0x1805C1910", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x5C1500", Offset = "0x5C0700", VA = "0x1805C1500", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x5C1330", Offset = "0x5C0530", VA = "0x1805C1330")]
		private void OnSeedExitVial()
		{
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x5C1340", Offset = "0x5C0540", VA = "0x1805C1340")]
		private void OnSeedReachedDestination()
		{
		}

		// Token: 0x0400147C RID: 5244
		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0xA8")]
		protected Pot pot;

		// Token: 0x0400147D RID: 5245
		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0xB0")]
		protected SeedDefinition definition;

		// Token: 0x0400147E RID: 5246
		[Token(Token = "0x400147E")]
		[FieldOffset(Offset = "0xB8")]
		protected FunctionalSeed seed;

		// Token: 0x0400147F RID: 5247
		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0xC0")]
		private bool seedExitedVial;

		// Token: 0x04001480 RID: 5248
		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0xC1")]
		private bool seedReachedDestination;

		// Token: 0x04001481 RID: 5249
		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0xC2")]
		private bool successfullyPlanted;

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0xC4")]
		private float weedSeedStationaryTime;

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0xC8")]
		private bool capRemoved;
	}
}
