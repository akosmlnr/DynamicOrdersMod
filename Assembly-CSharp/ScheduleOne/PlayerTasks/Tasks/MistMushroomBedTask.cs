using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class MistMushroomBedTask : Task
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000489")]
		public override string TaskName
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001796")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x5BD790", Offset = "0x5BC990", VA = "0x1805BD790")]
		public MistMushroomBedTask(MushroomBed mushroomBed, ItemInstance item, GameObject sprayablePrefab)
		{
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x5BD180", Offset = "0x5BC380", VA = "0x1805BD180")]
		private void OnSuccessfulSpray()
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x5BD150", Offset = "0x5BC350", VA = "0x1805BD150")]
		private void OnSpray()
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x5BD380", Offset = "0x5BC580", VA = "0x1805BD380", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x040014BB RID: 5307
		[Token(Token = "0x40014BB")]
		private const float TARGET_SPRAY_RADIUS = 0.15f;

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40014BC")]
		private const float TARGET_SPRAY_DISTANCE = 0.35f;

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		[FieldOffset(Offset = "0xA8")]
		private MushroomBed _mushroomBed;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0xB0")]
		private Sprayable _sprayable;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject _sprayableObj;

		// Token: 0x040014C0 RID: 5312
		[Token(Token = "0x40014C0")]
		[FieldOffset(Offset = "0xC0")]
		private WaterContainerInstance _waterContainerInstance;
	}
}
