using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	public class Equippable : MonoBehaviour
	{
		// Token: 0x06003FD6 RID: 16342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x852460", Offset = "0x851660", VA = "0x180852460", Slot = "4")]
		public virtual void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x85A090", Offset = "0x859290", VA = "0x18085A090", Slot = "5")]
		public virtual void Unequip()
		{
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0x851D80", Offset = "0x850F80", VA = "0x180851D80")]
		public Equippable()
		{
		}

		// Token: 0x04002E82 RID: 11906
		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0x20")]
		protected ItemInstance itemInstance;

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x28")]
		public bool CanInteractWhenEquipped;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x29")]
		public bool CanPickUpWhenEquipped;
	}
}
