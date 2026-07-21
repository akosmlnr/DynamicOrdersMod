using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D45 RID: 3397
	[Token(Token = "0x2000D45")]
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060062B6 RID: 25270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2F")]
		public Dealer SelectedDealer
		{
			[Token(Token = "0x60062B5")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062B6")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0xA40DE0", Offset = "0xA3FFE0", VA = "0x180A40DE0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0xA43440", Offset = "0xA42640", VA = "0x180A43440", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B9")]
		[Address(RVA = "0xA414C0", Offset = "0xA406C0", VA = "0x180A414C0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0xA41B20", Offset = "0xA40D20", VA = "0x180A41B20")]
		public void Refresh()
		{
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BB")]
		[Address(RVA = "0xA43300", Offset = "0xA42500", VA = "0x180A43300", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BC")]
		[Address(RVA = "0xA41CA0", Offset = "0xA40EA0", VA = "0x180A41CA0")]
		public void SetDisplayedDealer(Dealer dealer)
		{
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BD")]
		[Address(RVA = "0xA40B90", Offset = "0xA3FD90", VA = "0x180A40B90")]
		private void AddDealer(Dealer dealer)
		{
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0xA40AC0", Offset = "0xA3FCC0", VA = "0x180A40AC0")]
		private void AddCustomer(Customer customer)
		{
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062BF")]
		[Address(RVA = "0xA41C50", Offset = "0xA40E50", VA = "0x180A41C50")]
		private void RemoveCustomer(Customer customer)
		{
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C0")]
		[Address(RVA = "0xA41380", Offset = "0xA40580", VA = "0x180A41380")]
		private void BackPressed()
		{
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C1")]
		[Address(RVA = "0xA41410", Offset = "0xA40610", VA = "0x180A41410")]
		private void NextPressed()
		{
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C2")]
		[Address(RVA = "0xA40DB0", Offset = "0xA3FFB0", VA = "0x180A40DB0")]
		public void AssignCustomer()
		{
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0xA41750", Offset = "0xA40950", VA = "0x180A41750")]
		private void RefreshDropdown()
		{
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C4")]
		[Address(RVA = "0xA41690", Offset = "0xA40890", VA = "0x180A41690")]
		private void OnDropdownValueChanged(int value)
		{
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0xA41620", Offset = "0xA40820", VA = "0x180A41620")]
		private void OnDropdownOpen()
		{
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C6")]
		[Address(RVA = "0xA43510", Offset = "0xA42710", VA = "0x180A43510")]
		public DealerManagementApp()
		{
		}

		// Token: 0x04004499 RID: 17561
		[Token(Token = "0x4004499")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public Text NoDealersLabel;

		// Token: 0x0400449A RID: 17562
		[Token(Token = "0x400449A")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform Content;

		// Token: 0x0400449B RID: 17563
		[Token(Token = "0x400449B")]
		[FieldOffset(Offset = "0x80")]
		public CustomerSelector CustomerSelector;

		// Token: 0x0400449C RID: 17564
		[Token(Token = "0x400449C")]
		[FieldOffset(Offset = "0x88")]
		[Header("Selector")]
		public Image SelectorImage;

		// Token: 0x0400449D RID: 17565
		[Token(Token = "0x400449D")]
		[FieldOffset(Offset = "0x90")]
		public Text SelectorTitle;

		// Token: 0x0400449E RID: 17566
		[Token(Token = "0x400449E")]
		[FieldOffset(Offset = "0x98")]
		public Button BackButton;

		// Token: 0x0400449F RID: 17567
		[Token(Token = "0x400449F")]
		[FieldOffset(Offset = "0xA0")]
		public Button NextButton;

		// Token: 0x040044A0 RID: 17568
		[Token(Token = "0x40044A0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DropdownUI _dropdown;

		// Token: 0x040044A1 RID: 17569
		[Token(Token = "0x40044A1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _dropdownBackground;

		// Token: 0x040044A2 RID: 17570
		[Token(Token = "0x40044A2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _dropdownCaptionImage;

		// Token: 0x040044A3 RID: 17571
		[Token(Token = "0x40044A3")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _dropDownCaptionText;

		// Token: 0x040044A4 RID: 17572
		[Token(Token = "0x40044A4")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Basic Info")]
		public Text CashLabel;

		// Token: 0x040044A5 RID: 17573
		[Token(Token = "0x40044A5")]
		[FieldOffset(Offset = "0xD0")]
		public Text CutLabel;

		// Token: 0x040044A6 RID: 17574
		[Token(Token = "0x40044A6")]
		[FieldOffset(Offset = "0xD8")]
		public Text HomeLabel;

		// Token: 0x040044A7 RID: 17575
		[Token(Token = "0x40044A7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Header("Inventory")]
		private Text _inventoryTextLabel;

		// Token: 0x040044A8 RID: 17576
		[Token(Token = "0x40044A8")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _inventoryEntryContainer;

		// Token: 0x040044A9 RID: 17577
		[Token(Token = "0x40044A9")]
		[FieldOffset(Offset = "0xF0")]
		public RectTransform[] InventoryEntries;

		// Token: 0x040044AA RID: 17578
		[Token(Token = "0x40044AA")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Customers")]
		public Text CustomerTitleLabel;

		// Token: 0x040044AB RID: 17579
		[Token(Token = "0x40044AB")]
		[FieldOffset(Offset = "0x100")]
		public RectTransform[] CustomerEntries;

		// Token: 0x040044AC RID: 17580
		[Token(Token = "0x40044AC")]
		[FieldOffset(Offset = "0x108")]
		public Button AssignCustomerButton;

		// Token: 0x040044AD RID: 17581
		[Token(Token = "0x40044AD")]
		[FieldOffset(Offset = "0x110")]
		[Header("Fonts")]
		[SerializeField]
		private SpriteFont _uiGeneralSpriteFont;

		// Token: 0x040044AE RID: 17582
		[Token(Token = "0x40044AE")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ColorFont _productColorFont;

		// Token: 0x040044AF RID: 17583
		[Token(Token = "0x40044AF")]
		[FieldOffset(Offset = "0x120")]
		private List<Dealer> dealers;

		// Token: 0x040044B0 RID: 17584
		[Token(Token = "0x40044B0")]
		[FieldOffset(Offset = "0x128")]
		private bool _isOpen;

		// Token: 0x02000D46 RID: 3398
		[Token(Token = "0x2000D46")]
		private class InventoryItem
		{
			// Token: 0x060062C7 RID: 25287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062C7")]
			[Address(RVA = "0x82C4E0", Offset = "0x82B6E0", VA = "0x18082C4E0")]
			public InventoryItem(string id, int quantity, int quality)
			{
			}

			// Token: 0x040044B1 RID: 17585
			[Token(Token = "0x40044B1")]
			[FieldOffset(Offset = "0x10")]
			public string ID;

			// Token: 0x040044B2 RID: 17586
			[Token(Token = "0x40044B2")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;

			// Token: 0x040044B3 RID: 17587
			[Token(Token = "0x40044B3")]
			[FieldOffset(Offset = "0x1C")]
			public int Quality;
		}
	}
}
