using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E07 RID: 3591
	[Token(Token = "0x2000E07")]
	public class Cart : MonoBehaviour
	{
		// Token: 0x060066F9 RID: 26361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F9")]
		[Address(RVA = "0xA8BAD0", Offset = "0xA8ACD0", VA = "0x180A8BAD0", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0xA8B0F0", Offset = "0xA8A2F0", VA = "0x180A8B0F0")]
		public void SetItemQuantity(ShopListing listing, int quantity)
		{
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FB")]
		[Address(RVA = "0xA89AC0", Offset = "0xA88CC0", VA = "0x180A89AC0")]
		public void AddItem(ShopListing listing, int quantity)
		{
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0xA8AF70", Offset = "0xA8A170", VA = "0x180A8AF70")]
		public void RemoveItem(ShopListing listing, int quantity)
		{
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0xA8A5E0", Offset = "0xA897E0", VA = "0x180A8A5E0")]
		public void ClearCart()
		{
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x00019080 File Offset: 0x00017280
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0xA8A770", Offset = "0xA89970", VA = "0x180A8A770")]
		public int GetCartCount(ShopListing listing)
		{
			return 0;
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0xA8A4C0", Offset = "0xA896C0", VA = "0x180A8A4C0")]
		public bool CanPlayerAffordCart()
		{
			return default(bool);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006700")]
		[Address(RVA = "0xA89D20", Offset = "0xA88F20", VA = "0x180A89D20")]
		public void Buy()
		{
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006701")]
		[Address(RVA = "0xA8B1F0", Offset = "0xA8A3F0", VA = "0x180A8B1F0")]
		private void UpdateEntries()
		{
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006702")]
		[Address(RVA = "0xA8B8C0", Offset = "0xA8AAC0", VA = "0x180A8B8C0")]
		private void UpdateTotal()
		{
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006703")]
		[Address(RVA = "0xA8B760", Offset = "0xA8A960", VA = "0x180A8B760")]
		private void UpdateProblem()
		{
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x6006704")]
		[Address(RVA = "0xA8A210", Offset = "0xA89410", VA = "0x180A8A210")]
		private bool CanCheckout(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x000190C8 File Offset: 0x000172C8
		[Token(Token = "0x6006705")]
		[Address(RVA = "0xA8ACA0", Offset = "0xA89EA0", VA = "0x180A8ACA0")]
		private bool GetWarning(out string warning)
		{
			return default(bool);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006706")]
		[Address(RVA = "0xA8B6C0", Offset = "0xA8A8C0", VA = "0x180A8B6C0")]
		private void UpdateLoadVehicleToggle()
		{
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x6006707")]
		[Address(RVA = "0xA8A8E0", Offset = "0xA89AE0", VA = "0x180A8A8E0")]
		private int GetItemSum()
		{
			return 0;
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x6006708")]
		[Address(RVA = "0xA8A9E0", Offset = "0xA89BE0", VA = "0x180A8A9E0")]
		private float GetPriceSum()
		{
			return 0f;
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006709")]
		[Address(RVA = "0xA8A800", Offset = "0xA89A00", VA = "0x180A8A800")]
		private CartEntry GetEntry(ShopListing listing)
		{
			return null;
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x00019110 File Offset: 0x00017310
		[Token(Token = "0x600670A")]
		[Address(RVA = "0xA8AEB0", Offset = "0xA8A0B0", VA = "0x180A8AEB0")]
		private bool IsMouseOverMenuArea()
		{
			return default(bool);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x00019128 File Offset: 0x00017328
		[Token(Token = "0x600670B")]
		[Address(RVA = "0xA8AB20", Offset = "0xA89D20", VA = "0x180A8AB20")]
		public int GetTotalSlotRequirement()
		{
			return 0;
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670C")]
		[Address(RVA = "0xA8BBB0", Offset = "0xA8ADB0", VA = "0x180A8BBB0")]
		public Cart()
		{
		}

		// Token: 0x0400489E RID: 18590
		[Token(Token = "0x400489E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ShopInterface Shop;

		// Token: 0x0400489F RID: 18591
		[Token(Token = "0x400489F")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform CartEntryContainer;

		// Token: 0x040048A0 RID: 18592
		[Token(Token = "0x40048A0")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI ProblemText;

		// Token: 0x040048A1 RID: 18593
		[Token(Token = "0x40048A1")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI WarningText;

		// Token: 0x040048A2 RID: 18594
		[Token(Token = "0x40048A2")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform CartContainer;

		// Token: 0x040048A3 RID: 18595
		[Token(Token = "0x40048A3")]
		[FieldOffset(Offset = "0x48")]
		public Image CartArea;

		// Token: 0x040048A4 RID: 18596
		[Token(Token = "0x40048A4")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI TotalText;

		// Token: 0x040048A5 RID: 18597
		[Token(Token = "0x40048A5")]
		[FieldOffset(Offset = "0x58")]
		public Toggle LoadVehicleToggle;

		// Token: 0x040048A6 RID: 18598
		[Token(Token = "0x40048A6")]
		[FieldOffset(Offset = "0x60")]
		[Header("Prefabs")]
		public CartEntry EntryPrefab;

		// Token: 0x040048A7 RID: 18599
		[Token(Token = "0x40048A7")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<ShopListing, int> cartDictionary;

		// Token: 0x040048A8 RID: 18600
		[Token(Token = "0x40048A8")]
		[FieldOffset(Offset = "0x70")]
		private List<CartEntry> cartEntries;

		// Token: 0x040048A9 RID: 18601
		[Token(Token = "0x40048A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Custom UI")]
		private UIContentPanel cartPanel;

		// Token: 0x040048AA RID: 18602
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UITrigger buyUITrigger;
	}
}
