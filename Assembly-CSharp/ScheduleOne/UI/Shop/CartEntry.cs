using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E09 RID: 3593
	[Token(Token = "0x2000E09")]
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600670F RID: 26383 RVA: 0x00019158 File Offset: 0x00017358
		// (set) Token: 0x06006710 RID: 26384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9B")]
		public int Quantity
		{
			[Token(Token = "0x600670F")]
			[Address(RVA = "0x4B47D0", Offset = "0x4B39D0", VA = "0x1804B47D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006710")]
			[Address(RVA = "0x4E0E70", Offset = "0x4E0070", VA = "0x1804E0E70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06006711 RID: 26385 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006712 RID: 26386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9C")]
		public Cart Cart
		{
			[Token(Token = "0x6006711")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006712")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06006713 RID: 26387 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006714 RID: 26388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9D")]
		public ShopListing Listing
		{
			[Token(Token = "0x6006713")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006714")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006715")]
		[Address(RVA = "0xAA0C30", Offset = "0xA9FE30", VA = "0x180AA0C30")]
		public void Initialize(Cart cart, ShopListing listing, int quantity)
		{
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006716")]
		[Address(RVA = "0xAA14E0", Offset = "0xAA06E0", VA = "0x180AA14E0")]
		public void SetQuantity(int quantity)
		{
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006717")]
		[Address(RVA = "0xAA1660", Offset = "0xAA0860", VA = "0x180AA1660", Slot = "4")]
		protected virtual void UpdateTitle()
		{
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006718")]
		[Address(RVA = "0xAA15E0", Offset = "0xAA07E0", VA = "0x180AA15E0")]
		private void UpdatePrice()
		{
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006719")]
		[Address(RVA = "0xAA0980", Offset = "0xA9FB80", VA = "0x180AA0980")]
		private void ChangeAmount(int change)
		{
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671A")]
		[Address(RVA = "0xAA0E60", Offset = "0xAA0060", VA = "0x180AA0E60")]
		private void SetAmount(int amount)
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671B")]
		[Address(RVA = "0xAA14B0", Offset = "0xAA06B0", VA = "0x180AA14B0")]
		private void SetItemQuantity(int amount)
		{
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CartEntry()
		{
		}

		// Token: 0x040048AC RID: 18604
		[Token(Token = "0x40048AC")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x040048AD RID: 18605
		[Token(Token = "0x40048AD")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI PriceLabel;

		// Token: 0x040048AE RID: 18606
		[Token(Token = "0x40048AE")]
		[FieldOffset(Offset = "0x30")]
		public Button IncrementButton;

		// Token: 0x040048AF RID: 18607
		[Token(Token = "0x40048AF")]
		[FieldOffset(Offset = "0x38")]
		public Button DecrementButton;

		// Token: 0x040048B0 RID: 18608
		[Token(Token = "0x40048B0")]
		[FieldOffset(Offset = "0x40")]
		public Button RemoveButton;

		// Token: 0x040048B1 RID: 18609
		[Token(Token = "0x40048B1")]
		[FieldOffset(Offset = "0x48")]
		public UITrigger ModifyButton;
	}
}
