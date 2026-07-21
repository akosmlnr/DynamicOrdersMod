using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D13 RID: 3347
	[Token(Token = "0x2000D13")]
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06006161 RID: 24929 RVA: 0x00018240 File Offset: 0x00016440
		// (set) Token: 0x06006162 RID: 24930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DFF")]
		public bool IsOpen
		{
			[Token(Token = "0x6006161")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006162")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006163")]
		[Address(RVA = "0xA4E720", Offset = "0xA4D920", VA = "0x180A4E720")]
		private void Start()
		{
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006164")]
		[Address(RVA = "0xA4DC40", Offset = "0xA4CE40", VA = "0x180A4DC40")]
		public void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006165")]
		[Address(RVA = "0xA4D9C0", Offset = "0xA4CBC0", VA = "0x180A4D9C0")]
		private IEnumerator DelaySelectPanel()
		{
			return null;
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006166")]
		[Address(RVA = "0xA4D5D0", Offset = "0xA4C7D0", VA = "0x180A4D5D0")]
		public void Close()
		{
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006167")]
		[Address(RVA = "0xA4DA30", Offset = "0xA4CC30", VA = "0x180A4DA30")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006168")]
		[Address(RVA = "0xA4D310", Offset = "0xA4C510", VA = "0x180A4D310")]
		private void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006169")]
		[Address(RVA = "0xA4D120", Offset = "0xA4C320", VA = "0x180A4D120")]
		private void CartChanged()
		{
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616A")]
		[Address(RVA = "0xA4D950", Offset = "0xA4CB50", VA = "0x180A4D950")]
		private void ConfirmOrderPressed()
		{
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x00018258 File Offset: 0x00016458
		[Token(Token = "0x600616B")]
		[Address(RVA = "0xA4D0D0", Offset = "0xA4C2D0", VA = "0x180A4D0D0")]
		private bool CanConfirmOrder()
		{
			return default(bool);
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616C")]
		[Address(RVA = "0xA4E860", Offset = "0xA4DA60", VA = "0x180A4E860")]
		private void UpdateOrderTotal()
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00018270 File Offset: 0x00016470
		[Token(Token = "0x600616D")]
		[Address(RVA = "0xA4DAB0", Offset = "0xA4CCB0", VA = "0x180A4DAB0")]
		private float GetOrderTotal(out int itemCount)
		{
			return 0f;
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616E")]
		[Address(RVA = "0xA4E9E0", Offset = "0xA4DBE0", VA = "0x180A4E9E0")]
		public PhoneShopInterface()
		{
		}

		// Token: 0x04004353 RID: 17235
		[Token(Token = "0x4004353")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform EntryPrefab;

		// Token: 0x04004354 RID: 17236
		[Token(Token = "0x4004354")]
		[FieldOffset(Offset = "0x30")]
		public Color ValidAmountColor;

		// Token: 0x04004355 RID: 17237
		[Token(Token = "0x4004355")]
		[FieldOffset(Offset = "0x40")]
		public Color InvalidAmountColor;

		// Token: 0x04004356 RID: 17238
		[Token(Token = "0x4004356")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x04004357 RID: 17239
		[Token(Token = "0x4004357")]
		[FieldOffset(Offset = "0x58")]
		public Text TitleLabel;

		// Token: 0x04004358 RID: 17240
		[Token(Token = "0x4004358")]
		[FieldOffset(Offset = "0x60")]
		public Text SubtitleLabel;

		// Token: 0x04004359 RID: 17241
		[Token(Token = "0x4004359")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform EntryContainer;

		// Token: 0x0400435A RID: 17242
		[Token(Token = "0x400435A")]
		[FieldOffset(Offset = "0x70")]
		public Text OrderTotalLabel;

		// Token: 0x0400435B RID: 17243
		[Token(Token = "0x400435B")]
		[FieldOffset(Offset = "0x78")]
		public Text OrderLimitLabel;

		// Token: 0x0400435C RID: 17244
		[Token(Token = "0x400435C")]
		[FieldOffset(Offset = "0x80")]
		public Text DebtLabel;

		// Token: 0x0400435D RID: 17245
		[Token(Token = "0x400435D")]
		[FieldOffset(Offset = "0x88")]
		public Button ConfirmButton;

		// Token: 0x0400435E RID: 17246
		[Token(Token = "0x400435E")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ItemLimitContainer;

		// Token: 0x0400435F RID: 17247
		[Token(Token = "0x400435F")]
		[FieldOffset(Offset = "0x98")]
		public Text ItemLimitLabel;

		// Token: 0x04004360 RID: 17248
		[Token(Token = "0x4004360")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Custom UI")]
		public UIScreen uiScreen;

		// Token: 0x04004361 RID: 17249
		[Token(Token = "0x4004361")]
		[FieldOffset(Offset = "0xA8")]
		public UIPanel uiPanel;

		// Token: 0x04004362 RID: 17250
		[Token(Token = "0x4004362")]
		[FieldOffset(Offset = "0xB0")]
		private List<RectTransform> _entries;

		// Token: 0x04004363 RID: 17251
		[Token(Token = "0x4004363")]
		[FieldOffset(Offset = "0xB8")]
		private List<PhoneShopInterface.Listing> _items;

		// Token: 0x04004364 RID: 17252
		[Token(Token = "0x4004364")]
		[FieldOffset(Offset = "0xC0")]
		private List<PhoneShopInterface.CartEntry> _cart;

		// Token: 0x04004365 RID: 17253
		[Token(Token = "0x4004365")]
		[FieldOffset(Offset = "0xC8")]
		private float orderLimit;

		// Token: 0x04004366 RID: 17254
		[Token(Token = "0x4004366")]
		[FieldOffset(Offset = "0xD0")]
		private Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback;

		// Token: 0x04004367 RID: 17255
		[Token(Token = "0x4004367")]
		[FieldOffset(Offset = "0xD8")]
		private MSGConversation conversation;

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		[Serializable]
		public class Listing
		{
			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x0600616F RID: 24943 RVA: 0x00018288 File Offset: 0x00016488
			[Token(Token = "0x17000E00")]
			public float Price
			{
				[Token(Token = "0x600616F")]
				[Address(RVA = "0xA4C7A0", Offset = "0xA4B9A0", VA = "0x180A4C7A0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06006170 RID: 24944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006170")]
			[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
			public Listing(StorableItemDefinition item)
			{
			}

			// Token: 0x04004368 RID: 17256
			[Token(Token = "0x4004368")]
			[FieldOffset(Offset = "0x10")]
			public StorableItemDefinition Item;
		}

		// Token: 0x02000D15 RID: 3349
		[Token(Token = "0x2000D15")]
		[Serializable]
		public class CartEntry
		{
			// Token: 0x06006171 RID: 24945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006171")]
			[Address(RVA = "0x5E5DB0", Offset = "0x5E4FB0", VA = "0x1805E5DB0")]
			public CartEntry(PhoneShopInterface.Listing listing, int quantity)
			{
			}

			// Token: 0x04004369 RID: 17257
			[Token(Token = "0x4004369")]
			[FieldOffset(Offset = "0x10")]
			public PhoneShopInterface.Listing Listing;

			// Token: 0x0400436A RID: 17258
			[Token(Token = "0x400436A")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}
	}
}
