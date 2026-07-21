using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000D44 RID: 3396
	[Token(Token = "0x2000D44")]
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060062A8 RID: 25256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2D")]
		public ShopListing MatchingListing
		{
			[Token(Token = "0x60062A7")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062A8")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x00018768 File Offset: 0x00016968
		// (set) Token: 0x060062AA RID: 25258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2E")]
		public int SelectedQuantity
		{
			[Token(Token = "0x60062A9")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60062AA")]
			[Address(RVA = "0x4929B0", Offset = "0x491BB0", VA = "0x1804929B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AB")]
		[Address(RVA = "0xA4C000", Offset = "0xA4B200", VA = "0x180A4C000")]
		public void Initialize(ShopListing match)
		{
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AC")]
		[Address(RVA = "0xA4C420", Offset = "0xA4B620", VA = "0x180A4C420")]
		public void RefreshLocked()
		{
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AD")]
		[Address(RVA = "0xA4C490", Offset = "0xA4B690", VA = "0x180A4C490")]
		public void SetQuantity(int quant, bool notify = true)
		{
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AE")]
		[Address(RVA = "0xA4BF60", Offset = "0xA4B160", VA = "0x180A4BF60")]
		private void ChangeQuantity(int change)
		{
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AF")]
		[Address(RVA = "0xA4C320", Offset = "0xA4B520", VA = "0x180A4C320")]
		private void OnQuantityInputSubmitted(string value)
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B0")]
		[Address(RVA = "0xA4C680", Offset = "0xA4B880", VA = "0x180A4C680")]
		private void ValidateInput()
		{
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ListingEntry()
		{
		}

		// Token: 0x04004490 RID: 17552
		[Token(Token = "0x4004490")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Image Icon;

		// Token: 0x04004491 RID: 17553
		[Token(Token = "0x4004491")]
		[FieldOffset(Offset = "0x38")]
		public Text ItemNameLabel;

		// Token: 0x04004492 RID: 17554
		[Token(Token = "0x4004492")]
		[FieldOffset(Offset = "0x40")]
		public Text ItemPriceLabel;

		// Token: 0x04004493 RID: 17555
		[Token(Token = "0x4004493")]
		[FieldOffset(Offset = "0x48")]
		public InputField QuantityInput;

		// Token: 0x04004494 RID: 17556
		[Token(Token = "0x4004494")]
		[FieldOffset(Offset = "0x50")]
		public Button IncrementButton;

		// Token: 0x04004495 RID: 17557
		[Token(Token = "0x4004495")]
		[FieldOffset(Offset = "0x58")]
		public Button DecrementButton;

		// Token: 0x04004496 RID: 17558
		[Token(Token = "0x4004496")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform LockedContainer;

		// Token: 0x04004497 RID: 17559
		[Token(Token = "0x4004497")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onQuantityChanged;
	}
}
