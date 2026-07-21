using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	[Serializable]
	public class ItemSet
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x606170", Offset = "0x605370", VA = "0x180606170")]
		public ItemSet(List<ItemData> items)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x6057B0", Offset = "0x6049B0", VA = "0x1806057B0")]
		public string GetJSON()
		{
			return null;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x605E40", Offset = "0x605040", VA = "0x180605E40")]
		public ItemSet(List<ItemSlot> itemSlots)
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x606290", Offset = "0x605490", VA = "0x180606290")]
		public ItemSet(ItemSlot[] itemSlots)
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x605860", Offset = "0x604A60", VA = "0x180605860")]
		public void LoadTo(List<ItemSlot> slots)
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x6059B0", Offset = "0x604BB0", VA = "0x1806059B0")]
		public void LoadTo(ItemSlot[] slots)
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x6057C0", Offset = "0x6049C0", VA = "0x1806057C0")]
		public void LoadTo(ItemSlot slot, int index = 0)
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x605A10", Offset = "0x604C10", VA = "0x180605A10")]
		public static bool TryDeserialize(string json, out DeserializedItemSet itemSet)
		{
			return default(bool);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x605B60", Offset = "0x604D60", VA = "0x180605B60")]
		public static bool TryDeserialize(ItemSet set, out DeserializedItemSet itemSet)
		{
			return default(bool);
		}

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x10")]
		public string[] Items;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x18")]
		public SlotFilter[] SlotFilters;
	}
}
