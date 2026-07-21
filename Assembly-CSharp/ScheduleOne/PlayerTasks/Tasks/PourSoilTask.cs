using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.Soil;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	public class PourSoilTask : GrowContainerPourTask
	{
		// Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x5D80B0", Offset = "0x5D72B0", VA = "0x1805D80B0")]
		public PourSoilTask(GrowContainer growContainer, ItemInstance itemInstance, Pourable pourablePrefab)
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x5D7B70", Offset = "0x5D6D70", VA = "0x1805D7B70", Slot = "17")]
		protected override void OnInitialPour()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x5D7EA0", Offset = "0x5D70A0", VA = "0x1805D7EA0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x5D7C60", Offset = "0x5D6E60", VA = "0x1805D7C60", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x5D7D00", Offset = "0x5D6F00", VA = "0x1805D7D00", Slot = "10")]
		protected override void UpdateCursor()
		{
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x5D7E70", Offset = "0x5D7070", VA = "0x1805D7E70")]
		private void UpdateHover()
		{
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x5D79E0", Offset = "0x5D6BE0", VA = "0x1805D79E0")]
		private Collider GetHoveredTopCollider()
		{
			return null;
		}

		// Token: 0x040014C4 RID: 5316
		[Token(Token = "0x40014C4")]
		[FieldOffset(Offset = "0xD0")]
		private SoilDefinition _soilDefinition;

		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		[FieldOffset(Offset = "0xD8")]
		private PourableSoil _pourableSoil;

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0xE0")]
		private Collider _hoveredTopCollider;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0xE8")]
		private GrowContainer _growContainer;
	}
}
