using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Storage;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E13 RID: 3603
	[Token(Token = "0x2000E13")]
	public class ShopInterface : MonoBehaviour, ISaveable
	{
		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x00019200 File Offset: 0x00017400
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA3")]
		public bool IsOpen
		{
			[Token(Token = "0x600675C")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600675D")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000EA4")]
		public string SaveFolderName
		{
			[Token(Token = "0x600675E")]
			[Address(RVA = "0xABA6D0", Offset = "0xAB98D0", VA = "0x180ABA6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600675F RID: 26463 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000EA5")]
		public string SaveFileName
		{
			[Token(Token = "0x600675F")]
			[Address(RVA = "0xABA6D0", Offset = "0xAB98D0", VA = "0x180ABA6D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000EA6")]
		public Loader Loader
		{
			[Token(Token = "0x6006760")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06006761 RID: 26465 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x17000EA7")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6006761")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA8")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6006762")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006763")]
			[Address(RVA = "0x6BCD20", Offset = "0x6BBF20", VA = "0x1806BCD20", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006765 RID: 26469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA9")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6006764")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006765")]
			[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x00019230 File Offset: 0x00017430
		// (set) Token: 0x06006767 RID: 26471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAA")]
		public bool HasChanged
		{
			[Token(Token = "0x6006766")]
			[Address(RVA = "0x5AF090", Offset = "0x5AE290", VA = "0x1805AF090", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006767")]
			[Address(RVA = "0x61FCC0", Offset = "0x61EEC0", VA = "0x18061FCC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006768")]
		[Address(RVA = "0xAB5220", Offset = "0xAB4420", VA = "0x180AB5220", Slot = "27")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006769")]
		[Address(RVA = "0xAB9770", Offset = "0xAB8970", VA = "0x180AB9770", Slot = "28")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676A")]
		[Address(RVA = "0xAB6F50", Offset = "0xAB6150", VA = "0x180AB6F50", Slot = "29")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676B")]
		[Address(RVA = "0xAB7410", Offset = "0xAB6610", VA = "0x180AB7410")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676C")]
		[Address(RVA = "0xAB7490", Offset = "0xAB6690", VA = "0x180AB7490")]
		private void OnValidate()
		{
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676D")]
		[Address(RVA = "0xAB9FF0", Offset = "0xAB91F0", VA = "0x180AB9FF0", Slot = "30")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676E")]
		[Address(RVA = "0xAB7310", Offset = "0xAB6510", VA = "0x180AB7310")]
		protected void OnDayPass()
		{
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676F")]
		[Address(RVA = "0xAB79D0", Offset = "0xAB6BD0", VA = "0x180AB79D0")]
		protected void OnWeekPass()
		{
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006770")]
		[Address(RVA = "0xAB7C90", Offset = "0xAB6E90", VA = "0x180AB7C90")]
		[Button]
		public void Open()
		{
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006771")]
		[Address(RVA = "0xAB8BF0", Offset = "0xAB7DF0", VA = "0x180AB8BF0", Slot = "31")]
		public virtual void SetIsOpen(bool isOpen)
		{
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006772")]
		[Address(RVA = "0xAB6370", Offset = "0xAB5570", VA = "0x180AB6370")]
		private void Exit()
		{
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006773")]
		[Address(RVA = "0xAB6EB0", Offset = "0xAB60B0", VA = "0x180AB6EB0")]
		private void Hint()
		{
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006774")]
		[Address(RVA = "0xAB6390", Offset = "0xAB5590", VA = "0x180AB6390", Slot = "32")]
		protected virtual void Exit(ExitAction action)
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006775")]
		[Address(RVA = "0xAB5760", Offset = "0xAB4960", VA = "0x180AB5760")]
		private void CreateListingUI(ShopListing listing)
		{
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006776")]
		[Address(RVA = "0xAB8A40", Offset = "0xAB7C40", VA = "0x180AB8A40")]
		public void SelectCategory(EShopCategory category)
		{
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006777")]
		[Address(RVA = "0xAB6FE0", Offset = "0xAB61E0", VA = "0x180AB6FE0", Slot = "33")]
		public virtual void ListingClicked(ListingUI listingUI)
		{
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006778")]
		[Address(RVA = "0xAB5670", Offset = "0xAB4870", VA = "0x180AB5670")]
		public void CategorySelected(EShopCategory category)
		{
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006779")]
		[Address(RVA = "0xAB7DF0", Offset = "0xAB6FF0", VA = "0x180AB7DF0")]
		private void PullStockVariables()
		{
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677A")]
		[Address(RVA = "0xAB5C30", Offset = "0xAB4E30", VA = "0x180AB5C30")]
		private void DeselectCurrentCategory()
		{
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677B")]
		[Address(RVA = "0xAB8200", Offset = "0xAB7400", VA = "0x180AB8200")]
		private void RefreshShownItems()
		{
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600677C")]
		[Address(RVA = "0xAB8190", Offset = "0xAB7390", VA = "0x180AB8190")]
		private IEnumerator RefreshShownItemsNextFrame()
		{
			return null;
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677D")]
		[Address(RVA = "0xAB8830", Offset = "0xAB7A30", VA = "0x180AB8830")]
		private void RefreshUnlockStatus()
		{
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677E")]
		[Address(RVA = "0xAB8920", Offset = "0xAB7B20", VA = "0x180AB8920")]
		private void RestockAllListings()
		{
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00019248 File Offset: 0x00017448
		[Token(Token = "0x600677F")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
		public bool CanCartFitItem(ShopListing listing)
		{
			return default(bool);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00019260 File Offset: 0x00017460
		[Token(Token = "0x6006780")]
		[Address(RVA = "0xABA350", Offset = "0xAB9550", VA = "0x180ABA350")]
		public bool WillCartFit()
		{
			return default(bool);
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00019278 File Offset: 0x00017478
		[Token(Token = "0x6006781")]
		[Address(RVA = "0xABA080", Offset = "0xAB9280", VA = "0x180ABA080")]
		public bool WillCartFit(List<ItemSlot> availableSlots)
		{
			return default(bool);
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00019290 File Offset: 0x00017490
		[Token(Token = "0x6006782")]
		[Address(RVA = "0xAB6AD0", Offset = "0xAB5CD0", VA = "0x180AB6AD0", Slot = "34")]
		public virtual bool HandoverItems()
		{
			return default(bool);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006783")]
		[Address(RVA = "0xAB63F0", Offset = "0xAB55F0", VA = "0x180AB63F0")]
		public List<ItemSlot> GetAvailableSlots()
		{
			return null;
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006784")]
		[Address(RVA = "0xAB6760", Offset = "0xAB5960", VA = "0x180AB6760")]
		public LandVehicle GetLoadingBayVehicle()
		{
			return null;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006785")]
		[Address(RVA = "0xAB7CB0", Offset = "0xAB6EB0", VA = "0x180AB7CB0")]
		public void PlaceItemInDeliveryBay(ItemInstance item)
		{
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006786")]
		[Address(RVA = "0xAB8000", Offset = "0xAB7200", VA = "0x180AB8000")]
		public void QuantitySelected(int amount)
		{
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006787")]
		[Address(RVA = "0xAB7AD0", Offset = "0xAB6CD0", VA = "0x180AB7AD0")]
		public void OpenAmountSelector(ListingUI listing)
		{
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006788")]
		[Address(RVA = "0xAB5CE0", Offset = "0xAB4EE0", VA = "0x180AB5CE0")]
		private void DropdownClicked(ListingUI listing)
		{
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006789")]
		[Address(RVA = "0xAB7EA0", Offset = "0xAB70A0", VA = "0x180AB7EA0")]
		private void QuantitySelectedNew(int amount)
		{
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678A")]
		[Address(RVA = "0xAB62E0", Offset = "0xAB54E0", VA = "0x180AB62E0")]
		private void EntryHovered(ListingUI listing)
		{
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678B")]
		[Address(RVA = "0xAB6310", Offset = "0xAB5510", VA = "0x180AB6310")]
		private void EntryUnhovered()
		{
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678C")]
		[Address(RVA = "0xAB7100", Offset = "0xAB6300", VA = "0x180AB7100")]
		public void Load(ShopData data)
		{
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x000192A8 File Offset: 0x000174A8
		[Token(Token = "0x600678D")]
		[Address(RVA = "0xAB9610", Offset = "0xAB8810", VA = "0x180AB9610")]
		public bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600678E")]
		[Address(RVA = "0xAB6680", Offset = "0xAB5880", VA = "0x180AB6680")]
		public ShopListing GetListing(string itemID)
		{
			return null;
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600678F")]
		[Address(RVA = "0xAB6830", Offset = "0xAB5A30", VA = "0x180AB6830", Slot = "35")]
		public virtual ShopData GetSaveData()
		{
			return null;
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006790")]
		[Address(RVA = "0xAB6A90", Offset = "0xAB5C90", VA = "0x180AB6A90", Slot = "15")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006791")]
		[Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
		public ShopInterface()
		{
		}

		// Token: 0x040048EF RID: 18671
		[Token(Token = "0x40048EF")]
		[FieldOffset(Offset = "0x0")]
		public static List<ShopInterface> AllShops;

		// Token: 0x040048F0 RID: 18672
		[Token(Token = "0x40048F0")]
		public const int MAX_ITEM_QUANTITY = 999;

		// Token: 0x040048F2 RID: 18674
		[Token(Token = "0x40048F2")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string ShopName;

		// Token: 0x040048F3 RID: 18675
		[Token(Token = "0x40048F3")]
		[FieldOffset(Offset = "0x30")]
		public string ShopCode;

		// Token: 0x040048F4 RID: 18676
		[Token(Token = "0x40048F4")]
		[FieldOffset(Offset = "0x38")]
		public string ShopDescription;

		// Token: 0x040048F5 RID: 18677
		[Token(Token = "0x40048F5")]
		[FieldOffset(Offset = "0x40")]
		public ShopInterface.EPaymentType PaymentType;

		// Token: 0x040048F6 RID: 18678
		[Token(Token = "0x40048F6")]
		[FieldOffset(Offset = "0x44")]
		public bool ShowCurrencyHint;

		// Token: 0x040048F7 RID: 18679
		[Token(Token = "0x40048F7")]
		[FieldOffset(Offset = "0x48")]
		[Header("Listings")]
		public List<ShopListing> Listings;

		// Token: 0x040048F8 RID: 18680
		[Token(Token = "0x40048F8")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040048F9 RID: 18681
		[Token(Token = "0x40048F9")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform Container;

		// Token: 0x040048FA RID: 18682
		[Token(Token = "0x40048FA")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform ListingContainer;

		// Token: 0x040048FB RID: 18683
		[Token(Token = "0x40048FB")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI StoreNameLabel;

		// Token: 0x040048FC RID: 18684
		[Token(Token = "0x40048FC")]
		[FieldOffset(Offset = "0x70")]
		public Cart Cart;

		// Token: 0x040048FD RID: 18685
		[Token(Token = "0x40048FD")]
		[FieldOffset(Offset = "0x78")]
		public StorageEntity[] DeliveryBays;

		// Token: 0x040048FE RID: 18686
		[Token(Token = "0x40048FE")]
		[FieldOffset(Offset = "0x80")]
		public VehicleDetector LoadingBayDetector;

		// Token: 0x040048FF RID: 18687
		[Token(Token = "0x40048FF")]
		[FieldOffset(Offset = "0x88")]
		public ShopInterfaceDetailPanel DetailPanel;

		// Token: 0x04004900 RID: 18688
		[Token(Token = "0x4004900")]
		[FieldOffset(Offset = "0x90")]
		public ScrollRect ListingScrollRect;

		// Token: 0x04004901 RID: 18689
		[Token(Token = "0x4004901")]
		[FieldOffset(Offset = "0x98")]
		public ShopAmountSelector AmountSelector;

		// Token: 0x04004902 RID: 18690
		[Token(Token = "0x4004902")]
		[FieldOffset(Offset = "0xA0")]
		public DeliveryVehicle DeliveryVehicle;

		// Token: 0x04004903 RID: 18691
		[Token(Token = "0x4004903")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Audio")]
		public AudioSourceController AddItemSound;

		// Token: 0x04004904 RID: 18692
		[Token(Token = "0x4004904")]
		[FieldOffset(Offset = "0xB0")]
		public AudioSourceController RemoveItemSound;

		// Token: 0x04004905 RID: 18693
		[Token(Token = "0x4004905")]
		[FieldOffset(Offset = "0xB8")]
		public AudioSourceController CheckoutSound;

		// Token: 0x04004906 RID: 18694
		[Token(Token = "0x4004906")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Prefabs")]
		public ListingUI ListingUIPrefab;

		// Token: 0x04004907 RID: 18695
		[Token(Token = "0x4004907")]
		[FieldOffset(Offset = "0xC8")]
		public UnityEvent onOrderCompleted;

		// Token: 0x04004908 RID: 18696
		[Token(Token = "0x4004908")]
		[FieldOffset(Offset = "0xD0")]
		public Action<float> onOrderCompletedWithSpend;

		// Token: 0x04004909 RID: 18697
		[Token(Token = "0x4004909")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Header("Custom UI")]
		private UIScreen shopScreen;

		// Token: 0x0400490A RID: 18698
		[Token(Token = "0x400490A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIPanel listingPanel;

		// Token: 0x0400490B RID: 18699
		[Token(Token = "0x400490B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Header("Add To Cart Popup Values")]
		private int defaultAddToCartAmount;

		// Token: 0x0400490C RID: 18700
		[Token(Token = "0x400490C")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int minAddToCartAmount;

		// Token: 0x0400490D RID: 18701
		[Token(Token = "0x400490D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int addToCartTier1Amount;

		// Token: 0x0400490E RID: 18702
		[Token(Token = "0x400490E")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int addToCartTier2Amount;

		// Token: 0x0400490F RID: 18703
		[Token(Token = "0x400490F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private int addToCartTier3Amount;

		// Token: 0x04004910 RID: 18704
		[Token(Token = "0x4004910")]
		[FieldOffset(Offset = "0xFC")]
		[Header("Modify Cart Popup Values")]
		public int minModifyAmount;

		// Token: 0x04004911 RID: 18705
		[Token(Token = "0x4004911")]
		[FieldOffset(Offset = "0x100")]
		public int modifyTier1Amount;

		// Token: 0x04004912 RID: 18706
		[Token(Token = "0x4004912")]
		[FieldOffset(Offset = "0x104")]
		public int modifyTier2Amount;

		// Token: 0x04004913 RID: 18707
		[Token(Token = "0x4004913")]
		[FieldOffset(Offset = "0x108")]
		public int modifyTier3Amount;

		// Token: 0x04004914 RID: 18708
		[Token(Token = "0x4004914")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<CategoryButton> categoryButtons;

		// Token: 0x04004915 RID: 18709
		[Token(Token = "0x4004915")]
		[FieldOffset(Offset = "0x118")]
		private EShopCategory categoryFilter;

		// Token: 0x04004916 RID: 18710
		[Token(Token = "0x4004916")]
		[FieldOffset(Offset = "0x120")]
		private string searchTerm;

		// Token: 0x04004917 RID: 18711
		[Token(Token = "0x4004917")]
		[FieldOffset(Offset = "0x128")]
		private List<ListingUI> listingUI;

		// Token: 0x04004918 RID: 18712
		[Token(Token = "0x4004918")]
		[FieldOffset(Offset = "0x130")]
		private ListingUI selectedListing;

		// Token: 0x04004919 RID: 18713
		[Token(Token = "0x4004919")]
		[FieldOffset(Offset = "0x138")]
		private bool amountSelectorMouseUp;

		// Token: 0x0400491A RID: 18714
		[Token(Token = "0x400491A")]
		[FieldOffset(Offset = "0x140")]
		private ShopLoader loader;

		// Token: 0x02000E14 RID: 3604
		[Token(Token = "0x2000E14")]
		public enum EPaymentType
		{
			// Token: 0x0400491F RID: 18719
			[Token(Token = "0x400491F")]
			Cash,
			// Token: 0x04004920 RID: 18720
			[Token(Token = "0x4004920")]
			Online,
			// Token: 0x04004921 RID: 18721
			[Token(Token = "0x4004921")]
			PreferCash,
			// Token: 0x04004922 RID: 18722
			[Token(Token = "0x4004922")]
			PreferOnline
		}
	}
}
