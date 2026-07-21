using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D0D RID: 3341
	[Token(Token = "0x2000D0D")]
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x000181B0 File Offset: 0x000163B0
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF9")]
		public bool IsOpen
		{
			[Token(Token = "0x6006129")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600612A")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612B")]
		[Address(RVA = "0xA3ECE0", Offset = "0xA3DEE0", VA = "0x180A3ECE0")]
		private void Awake()
		{
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612C")]
		[Address(RVA = "0xA3F7E0", Offset = "0xA3E9E0", VA = "0x180A3F7E0")]
		private void Start()
		{
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612D")]
		[Address(RVA = "0xA3FA50", Offset = "0xA3EC50", VA = "0x180A3FA50")]
		private void Update()
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612E")]
		[Address(RVA = "0xA3F2C0", Offset = "0xA3E4C0", VA = "0x180A3F2C0")]
		public void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600612F")]
		[Address(RVA = "0xA3F140", Offset = "0xA3E340", VA = "0x180A3F140")]
		private IEnumerator DelaySelectPanel()
		{
			return null;
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006130")]
		[Address(RVA = "0xA3EF80", Offset = "0xA3E180", VA = "0x180A3EF80")]
		public void Close()
		{
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006131")]
		[Address(RVA = "0xA3F200", Offset = "0xA3E400", VA = "0x180A3F200")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006132")]
		[Address(RVA = "0xA3F670", Offset = "0xA3E870", VA = "0x180A3F670")]
		public void Send()
		{
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006133")]
		[Address(RVA = "0xA3F880", Offset = "0xA3EA80", VA = "0x180A3F880")]
		private void UpdateFairPrice()
		{
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006134")]
		[Address(RVA = "0xA3F760", Offset = "0xA3E960", VA = "0x180A3F760")]
		private void SetProduct(ProductDefinition newProduct)
		{
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006135")]
		[Address(RVA = "0xA3F1B0", Offset = "0xA3E3B0", VA = "0x180A3F1B0")]
		private void DisplayProduct(ProductDefinition tempProduct)
		{
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006136")]
		[Address(RVA = "0xA3EF20", Offset = "0xA3E120", VA = "0x180A3EF20")]
		public void ChangeQuantity(int change)
		{
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006137")]
		[Address(RVA = "0xA3F920", Offset = "0xA3EB20", VA = "0x180A3F920")]
		private void UpdatePriceQuantityLabel(string productName)
		{
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006138")]
		[Address(RVA = "0xA3EEB0", Offset = "0xA3E0B0", VA = "0x180A3EEB0")]
		public void ChangePrice(float change)
		{
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006139")]
		[Address(RVA = "0xA3F5C0", Offset = "0xA3E7C0", VA = "0x180A3F5C0")]
		public void PriceSubmitted(string value)
		{
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600613A")]
		[Address(RVA = "0xA3F280", Offset = "0xA3E480", VA = "0x180A3F280")]
		public void OpenProductSelector()
		{
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600613B")]
		[Address(RVA = "0xA3FCA0", Offset = "0xA3EEA0", VA = "0x180A3FCA0")]
		public CounterofferInterface()
		{
		}

		// Token: 0x0400431B RID: 17179
		[Token(Token = "0x400431B")]
		public const int COUNTEROFFER_SUCCESS_XP = 5;

		// Token: 0x0400431D RID: 17181
		[Token(Token = "0x400431D")]
		public const int MinQuantity = 1;

		// Token: 0x0400431E RID: 17182
		[Token(Token = "0x400431E")]
		[FieldOffset(Offset = "0x24")]
		public int MaxQuantity;

		// Token: 0x0400431F RID: 17183
		[Token(Token = "0x400431F")]
		public const float MinPrice = 1f;

		// Token: 0x04004320 RID: 17184
		[Token(Token = "0x4004320")]
		public const float MaxPrice = 9999f;

		// Token: 0x04004321 RID: 17185
		[Token(Token = "0x4004321")]
		[FieldOffset(Offset = "0x28")]
		public float IconAlignment;

		// Token: 0x04004322 RID: 17186
		[Token(Token = "0x4004322")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ProductEntryPrefab;

		// Token: 0x04004323 RID: 17187
		[Token(Token = "0x4004323")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x04004324 RID: 17188
		[Token(Token = "0x4004324")]
		[FieldOffset(Offset = "0x40")]
		public Text TitleLabel;

		// Token: 0x04004325 RID: 17189
		[Token(Token = "0x4004325")]
		[FieldOffset(Offset = "0x48")]
		public Button ConfirmButton;

		// Token: 0x04004326 RID: 17190
		[Token(Token = "0x4004326")]
		[FieldOffset(Offset = "0x50")]
		public Image ProductIcon;

		// Token: 0x04004327 RID: 17191
		[Token(Token = "0x4004327")]
		[FieldOffset(Offset = "0x58")]
		public Text ProductLabel;

		// Token: 0x04004328 RID: 17192
		[Token(Token = "0x4004328")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform ProductLabelRect;

		// Token: 0x04004329 RID: 17193
		[Token(Token = "0x4004329")]
		[FieldOffset(Offset = "0x68")]
		public InputField PriceInput;

		// Token: 0x0400432A RID: 17194
		[Token(Token = "0x400432A")]
		[FieldOffset(Offset = "0x70")]
		public Text FairPriceLabel;

		// Token: 0x0400432B RID: 17195
		[Token(Token = "0x400432B")]
		[FieldOffset(Offset = "0x78")]
		public CounterOfferProductSelector ProductSelector;

		// Token: 0x0400432C RID: 17196
		[Token(Token = "0x400432C")]
		[FieldOffset(Offset = "0x80")]
		[Header("Custom UI")]
		public UIScreen uiScreen;

		// Token: 0x0400432D RID: 17197
		[Token(Token = "0x400432D")]
		[FieldOffset(Offset = "0x88")]
		public UIPanel uiPanel;

		// Token: 0x0400432E RID: 17198
		[Token(Token = "0x400432E")]
		[FieldOffset(Offset = "0x90")]
		private Action<ProductDefinition, int, float> orderConfirmedCallback;

		// Token: 0x0400432F RID: 17199
		[Token(Token = "0x400432F")]
		[FieldOffset(Offset = "0x98")]
		private ProductDefinition selectedProduct;

		// Token: 0x04004330 RID: 17200
		[Token(Token = "0x4004330")]
		[FieldOffset(Offset = "0xA0")]
		private int quantity;

		// Token: 0x04004331 RID: 17201
		[Token(Token = "0x4004331")]
		[FieldOffset(Offset = "0xA4")]
		private float price;

		// Token: 0x04004332 RID: 17202
		[Token(Token = "0x4004332")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<ProductDefinition, RectTransform> productEntries;

		// Token: 0x04004333 RID: 17203
		[Token(Token = "0x4004333")]
		[FieldOffset(Offset = "0xB0")]
		private bool mouseUp;

		// Token: 0x04004334 RID: 17204
		[Token(Token = "0x4004334")]
		[FieldOffset(Offset = "0xB8")]
		private MSGConversation conversation;
	}
}
