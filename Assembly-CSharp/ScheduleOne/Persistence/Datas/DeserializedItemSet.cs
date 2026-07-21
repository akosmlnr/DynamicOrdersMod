using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	public class DeserializedItemSet
	{
		// Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DeserializedItemSet()
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x603770", Offset = "0x602970", VA = "0x180603770")]
		public ItemInstance GetItemAt(int index)
		{
			return null;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x6037B0", Offset = "0x6029B0", VA = "0x1806037B0")]
		public SlotFilter GetSlotFilterAt(int index)
		{
			return null;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x6037F0", Offset = "0x6029F0", VA = "0x1806037F0")]
		public void LoadTo(List<ItemSlot> slots)
		{
		}

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x10")]
		public ItemInstance[] Items;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x18")]
		public SlotFilter[] SlotFilters;
	}
}
