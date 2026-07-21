using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using ScheduleOne.Temperature;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class BuildUpdate_AirConditioner : BuildUpdate_Grid
	{
		// Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x788C00", Offset = "0x787E00", VA = "0x180788C00", Slot = "5")]
		public override void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x7892E0", Offset = "0x7884E0", VA = "0x1807892E0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x788BA0", Offset = "0x787DA0", VA = "0x180788BA0")]
		private void CycleACMode()
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x7892A0", Offset = "0x7884A0", VA = "0x1807892A0")]
		private void SetACMode(AirConditioner.EMode mode)
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x7890F0", Offset = "0x7882F0", VA = "0x1807890F0", Slot = "11")]
		protected override void OnPlacedObjectPreSpawn(GridItem item)
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x788D50", Offset = "0x787F50", VA = "0x180788D50", Slot = "12")]
		protected override void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current)
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x788A40", Offset = "0x787C40", VA = "0x180788A40")]
		private void AddToProperty(Property property)
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x789190", Offset = "0x788390", VA = "0x180789190")]
		public void RemoveFromPropery()
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x789380", Offset = "0x788580", VA = "0x180789380")]
		public BuildUpdate_AirConditioner()
		{
		}

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x68")]
		private AirConditioner _ac;

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x70")]
		private AirConditioner.EMode _currentMode;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x78")]
		private Property _currentProperty;
	}
}
