using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020009DE RID: 2526
	[Token(Token = "0x20009DE")]
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x06004879 RID: 18553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004879")]
		[Address(RVA = "0x8F4700", Offset = "0x8F3900", VA = "0x1808F4700", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487A")]
		[Address(RVA = "0x8F47B0", Offset = "0x8F39B0", VA = "0x1808F47B0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x8F4850", Offset = "0x8F3A50", VA = "0x1808F4850")]
		private void UpdateCashVisuals()
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x5944E0", Offset = "0x5936E0", VA = "0x1805944E0")]
		public Equippable_Cash()
		{
		}

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x60")]
		private int amountIndex;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Transform Container_Under100;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x70")]
		public List<Transform> SingleNotes;

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		[FieldOffset(Offset = "0x78")]
		public Transform Container_100_300;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x80")]
		public List<Transform> Under300Stacks;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0x88")]
		public Transform Container_300Plus;

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x90")]
		public List<Transform> PlusStacks;
	}
}
