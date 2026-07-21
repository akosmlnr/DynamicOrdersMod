using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Delivery;
using ScheduleOne.Property;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x2000D3F")]
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06006275 RID: 25205 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006276 RID: 25206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E29")]
		public ShopInterface MatchingShop
		{
			[Token(Token = "0x6006275")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006276")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06006277 RID: 25207 RVA: 0x00018618 File Offset: 0x00016818
		// (set) Token: 0x06006278 RID: 25208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2A")]
		public bool IsOpen
		{
			[Token(Token = "0x6006277")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006278")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06006279 RID: 25209 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600627A RID: 25210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2B")]
		public Action<DeliveryShop> OnSelect
		{
			[Token(Token = "0x6006279")]
			[Address(RVA = "0x4B4760", Offset = "0x4B3960", VA = "0x1804B4760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600627A")]
			[Address(RVA = "0x4B5280", Offset = "0x4B4480", VA = "0x1804B5280")]
			set
			{
			}
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627B")]
		[Address(RVA = "0xA47E50", Offset = "0xA47050", VA = "0x180A47E50")]
		public void Initialize()
		{
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627C")]
		[Address(RVA = "0xA47450", Offset = "0xA46650", VA = "0x180A47450")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627D")]
		[Address(RVA = "0xA48370", Offset = "0xA47570", VA = "0x180A48370")]
		public void Open()
		{
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627E")]
		[Address(RVA = "0x491600", Offset = "0x490800", VA = "0x180491600")]
		public void Close()
		{
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627F")]
		[Address(RVA = "0xA49600", Offset = "0xA48800", VA = "0x180A49600")]
		public void SubmitOrder(string originalDeliveryID)
		{
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00018630 File Offset: 0x00016830
		[Token(Token = "0x6006280")]
		[Address(RVA = "0xA47950", Offset = "0xA46B50", VA = "0x180A47950")]
		private int GetDeliveryTime(int itemCount)
		{
			return 0;
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006281")]
		[Address(RVA = "0xA49200", Offset = "0xA48400", VA = "0x180A49200")]
		public void Reorder(DeliveryReceipt receipt)
		{
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x6006282")]
		[Address(RVA = "0xA471C0", Offset = "0xA463C0", VA = "0x180A471C0")]
		public bool CanReorder(DeliveryReceipt receipt, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00018660 File Offset: 0x00016860
		[Token(Token = "0x6006283")]
		[Address(RVA = "0xA47670", Offset = "0xA46870", VA = "0x180A47670")]
		public float GetDeliveryCost(DeliveryReceipt receipt)
		{
			return 0f;
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006284")]
		[Address(RVA = "0xA490C0", Offset = "0xA482C0", VA = "0x180A490C0")]
		public void RefreshShop()
		{
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006285")]
		[Address(RVA = "0xA49450", Offset = "0xA48650", VA = "0x180A49450")]
		public void ResetCart()
		{
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006286")]
		[Address(RVA = "0xA48400", Offset = "0xA47600", VA = "0x180A48400")]
		private void RefreshCart()
		{
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006287")]
		[Address(RVA = "0xA49020", Offset = "0xA48220", VA = "0x180A49020")]
		private void RefreshOrderButton()
		{
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00018678 File Offset: 0x00016878
		[Token(Token = "0x6006288")]
		[Address(RVA = "0xA46F10", Offset = "0xA46110", VA = "0x180A46F10")]
		public bool CanOrder(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x00018690 File Offset: 0x00016890
		[Token(Token = "0x6006289")]
		[Address(RVA = "0xA47DC0", Offset = "0xA46FC0", VA = "0x180A47DC0")]
		public bool HasActiveDelivery()
		{
			return default(bool);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x000186A8 File Offset: 0x000168A8
		[Token(Token = "0x600628A")]
		[Address(RVA = "0xA49E70", Offset = "0xA49070", VA = "0x180A49E70")]
		public bool WillCartFitInVehicle()
		{
			return default(bool);
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628B")]
		[Address(RVA = "0xA48520", Offset = "0xA47720", VA = "0x180A48520")]
		public void RefreshDestinationUI()
		{
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628C")]
		[Address(RVA = "0xA47360", Offset = "0xA46560", VA = "0x180A47360")]
		private void DestinationDropdownSelected(int index)
		{
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600628D")]
		[Address(RVA = "0xA47C40", Offset = "0xA46E40", VA = "0x180A47C40")]
		private List<Property> GetPotentialDestinations()
		{
			return null;
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628E")]
		[Address(RVA = "0xA48D50", Offset = "0xA47F50", VA = "0x180A48D50")]
		public void RefreshLoadingDockUI()
		{
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x6A06A0", Offset = "0x69F8A0", VA = "0x1806A06A0")]
		private void LoadingDockDropdownSelected(int index)
		{
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x6006290")]
		[Address(RVA = "0xA474F0", Offset = "0xA466F0", VA = "0x180A474F0")]
		private float GetCartCost()
		{
			return 0f;
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x6006291")]
		[Address(RVA = "0xA47840", Offset = "0xA46A40", VA = "0x180A47840")]
		private float GetDeliveryFee()
		{
			return 0f;
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x6006292")]
		[Address(RVA = "0xA47B10", Offset = "0xA46D10", VA = "0x180A47B10")]
		private int GetOrderItemCount()
		{
			return 0;
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006293")]
		[Address(RVA = "0xA48AA0", Offset = "0xA47CA0", VA = "0x180A48AA0")]
		private void RefreshEntryOrder()
		{
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006294")]
		[Address(RVA = "0xA488F0", Offset = "0xA47AF0", VA = "0x180A488F0")]
		private void RefreshEntriesLocked()
		{
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006295")]
		[Address(RVA = "0xA4A040", Offset = "0xA49240", VA = "0x180A4A040")]
		public DeliveryShop()
		{
		}

		// Token: 0x04004467 RID: 17511
		[Token(Token = "0x4004467")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Button BackButton;

		// Token: 0x04004468 RID: 17512
		[Token(Token = "0x4004468")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform ListingContainer;

		// Token: 0x04004469 RID: 17513
		[Token(Token = "0x4004469")]
		[FieldOffset(Offset = "0x40")]
		public Text DeliveryFeeLabel;

		// Token: 0x0400446A RID: 17514
		[Token(Token = "0x400446A")]
		[FieldOffset(Offset = "0x48")]
		public Text ItemTotalLabel;

		// Token: 0x0400446B RID: 17515
		[Token(Token = "0x400446B")]
		[FieldOffset(Offset = "0x50")]
		public Text OrderTotalLabel;

		// Token: 0x0400446C RID: 17516
		[Token(Token = "0x400446C")]
		[FieldOffset(Offset = "0x58")]
		public Text DeliveryTimeLabel;

		// Token: 0x0400446D RID: 17517
		[Token(Token = "0x400446D")]
		[FieldOffset(Offset = "0x60")]
		public Button OrderButton;

		// Token: 0x0400446E RID: 17518
		[Token(Token = "0x400446E")]
		[FieldOffset(Offset = "0x68")]
		public Text OrderButtonNote;

		// Token: 0x0400446F RID: 17519
		[Token(Token = "0x400446F")]
		[FieldOffset(Offset = "0x70")]
		public Dropdown DestinationDropdown;

		// Token: 0x04004470 RID: 17520
		[Token(Token = "0x4004470")]
		[FieldOffset(Offset = "0x78")]
		public Dropdown LoadingDockDropdown;

		// Token: 0x04004471 RID: 17521
		[Token(Token = "0x4004471")]
		[FieldOffset(Offset = "0x80")]
		[Header("Settings")]
		public string MatchingShopInterfaceName;

		// Token: 0x04004472 RID: 17522
		[Token(Token = "0x4004472")]
		[FieldOffset(Offset = "0x88")]
		public Color ShopColor;

		// Token: 0x04004473 RID: 17523
		[Token(Token = "0x4004473")]
		[FieldOffset(Offset = "0x98")]
		public bool AvailableByDefault;

		// Token: 0x04004474 RID: 17524
		[Token(Token = "0x4004474")]
		[FieldOffset(Offset = "0xA0")]
		public ListingEntry ListingEntryPrefab;

		// Token: 0x04004475 RID: 17525
		[Token(Token = "0x4004475")]
		[FieldOffset(Offset = "0xA8")]
		private List<ListingEntry> listingEntries;

		// Token: 0x04004476 RID: 17526
		[Token(Token = "0x4004476")]
		[FieldOffset(Offset = "0xB0")]
		private Property destinationProperty;

		// Token: 0x04004477 RID: 17527
		[Token(Token = "0x4004477")]
		[FieldOffset(Offset = "0xB8")]
		private int loadingDockIndex;

		// Token: 0x04004478 RID: 17528
		[Token(Token = "0x4004478")]
		[FieldOffset(Offset = "0xC0")]
		private Action<DeliveryShop> _onSelect;
	}
}
