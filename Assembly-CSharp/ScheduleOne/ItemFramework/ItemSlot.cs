using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	[Serializable]
	public class ItemSlot
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C1")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60026F2")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F3")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C2")]
		public IItemSlotOwner SlotOwner
		{
			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x170006C3")]
		private int SlotIndex
		{
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x6C7C90", Offset = "0x6C6E90", VA = "0x1806C7C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x170006C4")]
		public int Quantity
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x6C7C70", Offset = "0x6C6E70", VA = "0x1806C7C70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x170006C5")]
		public bool IsAtCapacity
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x6C7C10", Offset = "0x6C6E10", VA = "0x1806C7C10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x170006C6")]
		public bool IsLocked
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x6C7C60", Offset = "0x6C6E60", VA = "0x1806C7C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C7")]
		public ItemSlotLock ActiveLock
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C8")]
		public bool IsRemovalLocked
		{
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026FD")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C9")]
		public bool IsAddLocked
		{
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x4D4750", Offset = "0x4D3950", VA = "0x1804D4750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x4D4AD0", Offset = "0x4D3CD0", VA = "0x1804D4AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CA")]
		protected List<ItemFilter> HardFilters
		{
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CB")]
		public bool CanPlayerSetFilter
		{
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x4D4760", Offset = "0x4D3960", VA = "0x1804D4760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x4D4AE0", Offset = "0x4D3CE0", VA = "0x1804D4AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CC")]
		public SlotFilter PlayerFilter
		{
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002705")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CD")]
		public ItemSlotSiblingSet SiblingSet
		{
			[Token(Token = "0x6002706")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002707")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x6C73C0", Offset = "0x6C65C0", VA = "0x1806C73C0")]
		public void SetSlotOwner(IItemSlotOwner owner)
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x6C7330", Offset = "0x6C6530", VA = "0x1806C7330")]
		public void SetSiblingSet(ItemSlotSiblingSet set)
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x6C7B00", Offset = "0x6C6D00", VA = "0x1806C7B00")]
		public ItemSlot()
		{
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x6C79E0", Offset = "0x6C6BE0", VA = "0x1806C79E0")]
		public ItemSlot(bool canPlayerSetFilter = false)
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x6C6E90", Offset = "0x6C6090", VA = "0x1806C6E90")]
		public void ReplicateStoredInstance()
		{
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x6C74B0", Offset = "0x6C66B0", VA = "0x1806C74B0", Slot = "4")]
		public virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x6C6CE0", Offset = "0x6C5EE0", VA = "0x1806C6CE0", Slot = "5")]
		public virtual void InsertItem(ItemInstance item)
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x6C6130", Offset = "0x6C5330", VA = "0x1806C6130", Slot = "6")]
		public virtual void AddItem(ItemInstance item, bool _internal = false)
		{
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x6C6650", Offset = "0x6C5850", VA = "0x1806C6650", Slot = "7")]
		public virtual void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x6C70F0", Offset = "0x6C62F0", VA = "0x1806C70F0")]
		public void SetQuantity(int amount, bool _internal = false)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x6C63F0", Offset = "0x6C55F0", VA = "0x1806C63F0")]
		public void ChangeQuantity(int change, bool _internal = false)
		{
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x6C6D00", Offset = "0x6C5F00", VA = "0x1806C6D00", Slot = "8")]
		protected virtual void ItemDataChanged()
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x6C6630", Offset = "0x6C5830", VA = "0x1806C6630", Slot = "9")]
		protected virtual void ClearItemInstanceRequested()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x6C6030", Offset = "0x6C5230", VA = "0x1806C6030")]
		public void AddFilter(ItemFilter filter)
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x6C6230", Offset = "0x6C5430", VA = "0x1806C6230")]
		public void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x6C6D50", Offset = "0x6C5F50", VA = "0x1806C6D50")]
		public void RemoveLock(bool _internal = false)
		{
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
		public void SetIsRemovalLocked(bool locked)
		{
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x4D4AD0", Offset = "0x4D3CD0", VA = "0x1804D4AD0")]
		public void SetIsAddLocked(bool locked)
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x6C6880", Offset = "0x6C5A80", VA = "0x1806C6880", Slot = "10")]
		public virtual bool DoesItemMatchHardFilters(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x6C6A70", Offset = "0x6C5C70", VA = "0x1806C6A70", Slot = "11")]
		public virtual bool DoesItemMatchPlayerFilters(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x6C6F60", Offset = "0x6C6160", VA = "0x1806C6F60")]
		public void SetFilterable(bool filterable)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x6C6FD0", Offset = "0x6C61D0", VA = "0x1806C6FD0")]
		public void SetPlayerFilter(SlotFilter filter, bool _internal = false)
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x6C6BF0", Offset = "0x6C5DF0", VA = "0x1806C6BF0", Slot = "12")]
		public virtual int GetCapacityForItem(ItemInstance item, bool checkPlayerFilters = false)
		{
			return 0;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "13")]
		public virtual bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x6C7740", Offset = "0x6C6940", VA = "0x1806C7740")]
		public static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x20")]
		public Action onItemDataChanged;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x28")]
		public Action onItemInstanceChanged;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x38")]
		public Action onLocked;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x40")]
		public Action onUnlocked;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x68")]
		public Action onFilterChange;
	}
}
