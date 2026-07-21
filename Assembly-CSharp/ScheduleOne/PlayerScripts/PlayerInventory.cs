using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public class PlayerInventory : PlayerSingleton<PlayerInventory>, IFirstPersonReferencesProvider
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x1700067C")]
		public int TOTAL_SLOT_COUNT
		{
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x6B01D0", Offset = "0x6AF3D0", VA = "0x1806B01D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700067D")]
		public Transform EquipContainer
		{
			[Token(Token = "0x6002527")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067E")]
		public CashSlot cashSlot
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067F")]
		public CashInstance cashInstance
		{
			[Token(Token = "0x600252A")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600252B")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0000C270 File Offset: 0x0000A470
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000680")]
		public int EquippedSlotIndex
		{
			[Token(Token = "0x600252C")]
			[Address(RVA = "0x4FF8E0", Offset = "0x4FEAE0", VA = "0x1804FF8E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x6B0270", Offset = "0x6AF470", VA = "0x1806B0270")]
			set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0000C288 File Offset: 0x0000A488
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000681")]
		public bool HotbarEnabled
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x6B01C0", Offset = "0x6AF3C0", VA = "0x1806B01C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x6B0310", Offset = "0x6AF510", VA = "0x1806B0310")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000682")]
		public bool EquippingEnabled
		{
			[Token(Token = "0x6002530")]
			[Address(RVA = "0x6B01A0", Offset = "0x6AF3A0", VA = "0x1806B01A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002531")]
			[Address(RVA = "0x6B02F0", Offset = "0x6AF4F0", VA = "0x1806B02F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000683")]
		public bool HolsterEnabled
		{
			[Token(Token = "0x6002532")]
			[Address(RVA = "0x6B01B0", Offset = "0x6AF3B0", VA = "0x1806B01B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002533")]
			[Address(RVA = "0x6B0300", Offset = "0x6AF500", VA = "0x1806B0300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000684")]
		public Equippable equippable
		{
			[Token(Token = "0x6002534")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002535")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000685")]
		public HotbarSlot equippedSlot
		{
			[Token(Token = "0x6002536")]
			[Address(RVA = "0x6B01F0", Offset = "0x6AF3F0", VA = "0x1806B01F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000686")]
		public ItemInstance EquippedItem
		{
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x6B0150", Offset = "0x6AF350", VA = "0x1806B0150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x17000687")]
		public bool isAnythingEquipped
		{
			[Token(Token = "0x6002538")]
			[Address(RVA = "0x6B0210", Offset = "0x6AF410", VA = "0x1806B0210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x6AC6E0", Offset = "0x6AB8E0", VA = "0x1806AC6E0")]
		public HotbarSlot IndexAllSlots(int index)
		{
			return null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x6ABB20", Offset = "0x6AAD20", VA = "0x1806ABB20", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x6ADC00", Offset = "0x6ACE00", VA = "0x1806ADC00")]
		private void SetupInventoryUI()
		{
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x6ACE00", Offset = "0x6AC000", VA = "0x1806ACE00")]
		private void RepositionUI()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x6AE750", Offset = "0x6AD950", VA = "0x1806AE750", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x6AC540", Offset = "0x6AB740", VA = "0x1806AC540")]
		private void GiveStartupItems()
		{
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x6AF930", Offset = "0x6AEB30", VA = "0x1806AF930", Slot = "9")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x6AEC90", Offset = "0x6ADE90", VA = "0x1806AEC90")]
		private void UpdateHotbarSelection()
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x6AC1A0", Offset = "0x6AB3A0", VA = "0x1806AC1A0")]
		public void Equip(HotbarSlot slot)
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x6AD990", Offset = "0x6ACB90", VA = "0x1806AD990")]
		public void SetInventoryEnabled(bool enabled)
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x6AD740", Offset = "0x6AC940", VA = "0x1806AD740")]
		public void SetEquippingEnabled(bool enabled)
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x6AB9B0", Offset = "0x6AABB0", VA = "0x1806AB9B0")]
		public void AttachToScreen(UIScreen screen)
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x6ABFD0", Offset = "0x6AB1D0", VA = "0x1806ABFD0")]
		public void DetachFromScreen()
		{
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x6ABF90", Offset = "0x6AB190", VA = "0x1806ABF90")]
		private void ClipboardAcquiredVarChange(bool newVal)
		{
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x6ABF90", Offset = "0x6AB190", VA = "0x1806ABF90")]
		public void SetManagementClipboardEnabled(bool enabled)
		{
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x6ADA70", Offset = "0x6ACC70", VA = "0x1806ADA70")]
		public void SetViewmodelVisible(bool visible)
		{
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x6ABCE0", Offset = "0x6AAEE0", VA = "0x1806ABCE0")]
		public bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x6AB590", Offset = "0x6AA790", VA = "0x1806AB590")]
		public void AddItemToInventory(ItemInstance item)
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x6AC3D0", Offset = "0x6AB5D0", VA = "0x1806AC3D0")]
		public uint GetAmountOfItem(string ID)
		{
			return 0U;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x6AC840", Offset = "0x6ABA40", VA = "0x1806AC840")]
		public void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x6ABED0", Offset = "0x6AB0D0", VA = "0x1806ABED0")]
		public void ClearInventory()
		{
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x6ACAA0", Offset = "0x6ABCA0", VA = "0x1806ACAA0")]
		public void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x6ACCD0", Offset = "0x6ABED0", VA = "0x1806ACCD0")]
		public void RemoveRandomItemsFromInventory()
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x6AD6B0", Offset = "0x6AC8B0", VA = "0x1806AD6B0")]
		public void SetEquippable(Equippable eq)
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x6AC1D0", Offset = "0x6AB3D0", VA = "0x1806AC1D0")]
		public void EquippedSlotChanged()
		{
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x6AC7D0", Offset = "0x6AB9D0", VA = "0x1806AC7D0")]
		public void Reequip()
		{
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x6AC200", Offset = "0x6AB400", VA = "0x1806AC200")]
		public List<ItemSlot> GetAllInventorySlots()
		{
			return null;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x6AF170", Offset = "0x6AE370", VA = "0x1806AF170")]
		private void UpdateInventoryVariables()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x6AFFD0", Offset = "0x6AF1D0", VA = "0x1806AFFD0")]
		public PlayerInventory()
		{
		}

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		public const float LABEL_DISPLAY_TIME = 2f;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		public const float LABEL_FADE_TIME = 0.5f;

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		public const float DISCARD_TIME = 1.25f;

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		public const int INVENTORY_SLOT_COUNT = 8;

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Startup Items (Editor only)")]
		private bool giveStartupItems;

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerInventory.ItemAmount> startupItems;

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform equipContainer;

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		[FieldOffset(Offset = "0x38")]
		public List<HotbarSlot> hotbarSlots;

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x50")]
		private ClipboardSlot clipboardSlot;

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		[FieldOffset(Offset = "0x58")]
		private List<ItemSlotUI> slotUIs;

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		[FieldOffset(Offset = "0x60")]
		private ItemSlot discardSlot;

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		[FieldOffset(Offset = "0x68")]
		[Header("Item Variables")]
		public List<PlayerInventory.ItemVariable> ItemVariables;

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		[FieldOffset(Offset = "0x70")]
		private int _equippedSlotIndex;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x80")]
		public Action<bool> onInventoryStateChanged;

		// Token: 0x04001D01 RID: 7425
		[Token(Token = "0x4001D01")]
		[FieldOffset(Offset = "0x88")]
		public Action<int> onEquippedSlotChanged;

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x90")]
		private int PriorEquippedSlotIndex;

		// Token: 0x04001D03 RID: 7427
		[Token(Token = "0x4001D03")]
		[FieldOffset(Offset = "0x94")]
		private int PreviousEquippedSlotIndex;

		// Token: 0x04001D04 RID: 7428
		[Token(Token = "0x4001D04")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onPreItemEquipped;

		// Token: 0x04001D05 RID: 7429
		[Token(Token = "0x4001D05")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onItemEquipped;

		// Token: 0x04001D06 RID: 7430
		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0xA8")]
		private bool ManagementSlotEnabled;

		// Token: 0x04001D07 RID: 7431
		[Token(Token = "0x4001D07")]
		[FieldOffset(Offset = "0xAC")]
		public float currentEquipTime;

		// Token: 0x04001D08 RID: 7432
		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0xB0")]
		protected float currentDiscardTime;

		// Token: 0x04001D09 RID: 7433
		[Token(Token = "0x4001D09")]
		[FieldOffset(Offset = "0xB8")]
		protected UIScreen attachedScreen;

		// Token: 0x04001D0A RID: 7434
		[Token(Token = "0x4001D0A")]
		[FieldOffset(Offset = "0xC0")]
		protected UIPanel uiPanel;

		// Token: 0x04001D0B RID: 7435
		[Token(Token = "0x4001D0B")]
		[FieldOffset(Offset = "0xC8")]
		protected UIPanel originalSelectedPanel;

		// Token: 0x020005F4 RID: 1524
		[Token(Token = "0x20005F4")]
		[Serializable]
		public class ItemVariable
		{
			// Token: 0x06002557 RID: 9559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002557")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ItemVariable()
			{
			}

			// Token: 0x04001D0C RID: 7436
			[Token(Token = "0x4001D0C")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Definition;

			// Token: 0x04001D0D RID: 7437
			[Token(Token = "0x4001D0D")]
			[FieldOffset(Offset = "0x18")]
			public string VariableName;
		}

		// Token: 0x020005F5 RID: 1525
		[Token(Token = "0x20005F5")]
		[Serializable]
		private class ItemAmount
		{
			// Token: 0x06002558 RID: 9560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002558")]
			[Address(RVA = "0x6A2BB0", Offset = "0x6A1DB0", VA = "0x1806A2BB0")]
			public ItemAmount()
			{
			}

			// Token: 0x04001D0E RID: 7438
			[Token(Token = "0x4001D0E")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Definition;

			// Token: 0x04001D0F RID: 7439
			[Token(Token = "0x4001D0F")]
			[FieldOffset(Offset = "0x18")]
			public int Amount;
		}
	}
}
