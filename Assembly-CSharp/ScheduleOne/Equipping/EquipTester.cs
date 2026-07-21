using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000964 RID: 2404
	[Token(Token = "0x2000964")]
	public class EquipTester : MonoBehaviour
	{
		// Token: 0x0600404F RID: 16463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x84FF70", Offset = "0x84F170", VA = "0x18084FF70")]
		[Button]
		public void Equip()
		{
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x84FEF0", Offset = "0x84F0F0", VA = "0x18084FEF0")]
		[Button]
		public void EquipLocally()
		{
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x8500D0", Offset = "0x84F2D0", VA = "0x1808500D0")]
		[Button]
		public void Unequip()
		{
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x84FFF0", Offset = "0x84F1F0", VA = "0x18084FFF0")]
		[Button]
		public void UnequipAll()
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public EquipTester()
		{
		}

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x20")]
		public EquippableData TestEquippable;

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x28")]
		private IEquippedItemHandler _equippedItemHandler;
	}
}
