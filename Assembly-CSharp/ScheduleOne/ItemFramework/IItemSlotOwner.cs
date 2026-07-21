using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	public interface IItemSlotOwner
	{
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060026B0 RID: 9904
		// (set) Token: 0x060026B1 RID: 9905
		[Token(Token = "0x170006BC")]
		List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60026B0")]
			get;
			[Token(Token = "0x60026B1")]
			set;
		}

		// Token: 0x060026B2 RID: 9906
		[Token(Token = "0x60026B2")]
		void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance);

		// Token: 0x060026B3 RID: 9907
		[Token(Token = "0x60026B3")]
		void SetItemSlotQuantity(int itemSlotIndex, int quantity);

		// Token: 0x060026B4 RID: 9908
		[Token(Token = "0x60026B4")]
		void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason);

		// Token: 0x060026B5 RID: 9909
		[Token(Token = "0x60026B5")]
		void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter);

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x6C0070", Offset = "0x6BF270", VA = "0x1806C0070", Slot = "6")]
		void SendItemSlotDataToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x6BFF30", Offset = "0x6BF130", VA = "0x1806BFF30", Slot = "7")]
		int GetQuantitySum()
		{
			return 0;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x6BFCB0", Offset = "0x6BEEB0", VA = "0x1806BFCB0", Slot = "8")]
		int GetQuantityOfItem(string id)
		{
			return 0;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x6BFB00", Offset = "0x6BED00", VA = "0x1806BFB00", Slot = "9")]
		int GetNonEmptySlotCount()
		{
			return 0;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x6BF990", Offset = "0x6BEB90", VA = "0x1806BF990", Slot = "10")]
		ItemSlot GetFirstSlotContaining(string id)
		{
			return null;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x6C0270", Offset = "0x6BF470", VA = "0x1806C0270")]
		[CompilerGenerated]
		void <SendItemSlotDataToClient>g__Send|7_0(NetworkConnection conn)
		{
		}
	}
}
