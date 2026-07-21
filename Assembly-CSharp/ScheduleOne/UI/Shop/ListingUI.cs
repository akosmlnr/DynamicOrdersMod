using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E0F RID: 3599
	[Token(Token = "0x2000E0F")]
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9F")]
		public ShopListing Listing
		{
			[Token(Token = "0x6006733")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006734")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006735")]
		[Address(RVA = "0xAB1560", Offset = "0xAB0760", VA = "0x180AB1560", Slot = "4")]
		public virtual void Initialize(ShopListing listing)
		{
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006736")]
		[Address(RVA = "0xAB1450", Offset = "0xAB0650", VA = "0x180AB1450", Slot = "5")]
		public virtual RectTransform GetIconCopy(RectTransform parent)
		{
			return null;
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006737")]
		[Address(RVA = "0xAB2130", Offset = "0xAB1330", VA = "0x180AB2130")]
		public void Update()
		{
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006738")]
		[Address(RVA = "0xAB13F0", Offset = "0xAB05F0", VA = "0x180AB13F0")]
		private void Clicked()
		{
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006739")]
		[Address(RVA = "0xAB1420", Offset = "0xAB0620", VA = "0x180AB1420")]
		private void DropdownClicked()
		{
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673A")]
		[Address(RVA = "0xAB1530", Offset = "0xAB0730", VA = "0x180AB1530")]
		private void HoverStart()
		{
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673B")]
		[Address(RVA = "0xAB1500", Offset = "0xAB0700", VA = "0x180AB1500")]
		private void HoverEnd()
		{
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673C")]
		[Address(RVA = "0xAB1C50", Offset = "0xAB0E50", VA = "0x180AB1C50")]
		private void StockChanged()
		{
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673D")]
		[Address(RVA = "0xAB1D60", Offset = "0xAB0F60", VA = "0x180AB1D60")]
		private void UpdatePrice()
		{
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673E")]
		[Address(RVA = "0xAB1EC0", Offset = "0xAB10C0", VA = "0x180AB1EC0")]
		private void UpdateStock()
		{
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673F")]
		[Address(RVA = "0xAB1C80", Offset = "0xAB0E80", VA = "0x180AB1C80")]
		private void UpdateButtons()
		{
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x6006740")]
		[Address(RVA = "0xAB13A0", Offset = "0xAB05A0", VA = "0x180AB13A0")]
		public bool CanAddToCart()
		{
			return default(bool);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006741")]
		[Address(RVA = "0xAB1D00", Offset = "0xAB0F00", VA = "0x180AB1D00")]
		public void UpdateLockStatus()
		{
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006742")]
		[Address(RVA = "0xAB21A0", Offset = "0xAB13A0", VA = "0x180AB21A0")]
		public ListingUI()
		{
		}

		// Token: 0x040048CF RID: 18639
		[Token(Token = "0x40048CF")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 PriceLabelColor_Normal;

		// Token: 0x040048D0 RID: 18640
		[Token(Token = "0x40048D0")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 PriceLabelColor_NoStock;

		// Token: 0x040048D2 RID: 18642
		[Token(Token = "0x40048D2")]
		[FieldOffset(Offset = "0x28")]
		[Header("Colors")]
		public Color32 StockLabelDefault;

		// Token: 0x040048D3 RID: 18643
		[Token(Token = "0x40048D3")]
		[FieldOffset(Offset = "0x2C")]
		public Color32 StockLabelNone;

		// Token: 0x040048D4 RID: 18644
		[Token(Token = "0x40048D4")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Image Icon;

		// Token: 0x040048D5 RID: 18645
		[Token(Token = "0x40048D5")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x040048D6 RID: 18646
		[Token(Token = "0x40048D6")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI PriceLabel;

		// Token: 0x040048D7 RID: 18647
		[Token(Token = "0x40048D7")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI StockLabel;

		// Token: 0x040048D8 RID: 18648
		[Token(Token = "0x40048D8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LockedContainer;

		// Token: 0x040048D9 RID: 18649
		[Token(Token = "0x40048D9")]
		[FieldOffset(Offset = "0x58")]
		public Button BuyButton;

		// Token: 0x040048DA RID: 18650
		[Token(Token = "0x40048DA")]
		[FieldOffset(Offset = "0x60")]
		public Button DropdownButton;

		// Token: 0x040048DB RID: 18651
		[Token(Token = "0x40048DB")]
		[FieldOffset(Offset = "0x68")]
		public EventTrigger Trigger;

		// Token: 0x040048DC RID: 18652
		[Token(Token = "0x40048DC")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform DetailPanelAnchor;

		// Token: 0x040048DD RID: 18653
		[Token(Token = "0x40048DD")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform DropdownAnchor;

		// Token: 0x040048DE RID: 18654
		[Token(Token = "0x40048DE")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform TopDropdownAnchor;

		// Token: 0x040048DF RID: 18655
		[Token(Token = "0x40048DF")]
		[FieldOffset(Offset = "0x88")]
		public Action hoverStart;

		// Token: 0x040048E0 RID: 18656
		[Token(Token = "0x40048E0")]
		[FieldOffset(Offset = "0x90")]
		public Action hoverEnd;

		// Token: 0x040048E1 RID: 18657
		[Token(Token = "0x40048E1")]
		[FieldOffset(Offset = "0x98")]
		public Action onClicked;

		// Token: 0x040048E2 RID: 18658
		[Token(Token = "0x40048E2")]
		[FieldOffset(Offset = "0xA0")]
		public Action onDropdownClicked;
	}
}
