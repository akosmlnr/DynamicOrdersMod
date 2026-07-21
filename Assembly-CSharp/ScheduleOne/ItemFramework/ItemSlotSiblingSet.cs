using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public class ItemSlotSiblingSet
	{
		// Token: 0x06002728 RID: 10024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x6C5F60", Offset = "0x6C5160", VA = "0x1806C5F60")]
		public ItemSlotSiblingSet(params ItemSlot[] slots)
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x6C5DF0", Offset = "0x6C4FF0", VA = "0x1806C5DF0")]
		public ItemSlotSiblingSet(List<ItemSlot> slots)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x6C5CA0", Offset = "0x6C4EA0", VA = "0x1806C5CA0")]
		public void AddSlot(ItemSlot slot)
		{
		}

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemSlot> Slots;
	}
}
