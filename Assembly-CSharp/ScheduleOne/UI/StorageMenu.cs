using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CAD RID: 3245
	[Token(Token = "0x2000CAD")]
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x00017CE8 File Offset: 0x00015EE8
		// (set) Token: 0x06005EE9 RID: 24297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC2")]
		public bool IsOpen
		{
			[Token(Token = "0x6005EE8")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005EE9")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005EEB RID: 24299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC3")]
		public StorageEntity OpenedStorageEntity
		{
			[Token(Token = "0x6005EEA")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005EEB")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0xA132B0", Offset = "0xA124B0", VA = "0x180A132B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EED")]
		[Address(RVA = "0xA14370", Offset = "0xA13570", VA = "0x180A14370", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0xA13A10", Offset = "0xA12C10", VA = "0x180A13A10", Slot = "7")]
		public virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0xA14300", Offset = "0xA13500", VA = "0x180A14300", Slot = "8")]
		public virtual void Open(StorageEntity entity)
		{
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0xA13AA0", Offset = "0xA12CA0", VA = "0x180A13AA0")]
		private void Open(string title, string subtitle, IItemSlotOwner owner)
		{
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0xA138B0", Offset = "0xA12AB0", VA = "0x180A138B0")]
		public void Close()
		{
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0xA133A0", Offset = "0xA125A0", VA = "0x180A133A0", Slot = "9")]
		public virtual void CloseMenu()
		{
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0xA13950", Offset = "0xA12B50", VA = "0x180A13950")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0xA14440", Offset = "0xA13640", VA = "0x180A14440")]
		public StorageMenu()
		{
		}

		// Token: 0x04004141 RID: 16705
		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004142 RID: 16706
		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Container;

		// Token: 0x04004143 RID: 16707
		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x48")]
		public UIScreen UIScreen;

		// Token: 0x04004144 RID: 16708
		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04004145 RID: 16709
		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI SubtitleLabel;

		// Token: 0x04004146 RID: 16710
		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform SlotContainer;

		// Token: 0x04004147 RID: 16711
		[Token(Token = "0x4004147")]
		[FieldOffset(Offset = "0x68")]
		public ItemSlotUI[] SlotsUIs;

		// Token: 0x04004148 RID: 16712
		[Token(Token = "0x4004148")]
		[FieldOffset(Offset = "0x70")]
		public GridLayoutGroup SlotGridLayout;

		// Token: 0x04004149 RID: 16713
		[Token(Token = "0x4004149")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform CloseButton;

		// Token: 0x0400414A RID: 16714
		[Token(Token = "0x400414A")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onClosed;
	}
}
