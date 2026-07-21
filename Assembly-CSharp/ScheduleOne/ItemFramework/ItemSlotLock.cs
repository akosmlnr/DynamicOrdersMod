using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000634 RID: 1588
	[Token(Token = "0x2000634")]
	public class ItemSlotLock
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CE")]
		public ItemSlot Slot
		{
			[Token(Token = "0x6002721")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002722")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CF")]
		public NetworkObject LockOwner
		{
			[Token(Token = "0x6002723")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002724")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D0")]
		public string LockReason
		{
			[Token(Token = "0x6002725")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002726")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x6C5BF0", Offset = "0x6C4DF0", VA = "0x1806C5BF0")]
		public ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason)
		{
		}
	}
}
