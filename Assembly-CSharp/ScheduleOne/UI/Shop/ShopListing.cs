using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E1D RID: 3613
	[Token(Token = "0x2000E1D")]
	[Serializable]
	public class ShopListing
	{
		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x00019398 File Offset: 0x00017598
		[Token(Token = "0x17000EAF")]
		public bool IsInStock
		{
			[Token(Token = "0x60067B8")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x000193B0 File Offset: 0x000175B0
		[Token(Token = "0x17000EB0")]
		public float Price
		{
			[Token(Token = "0x60067B9")]
			[Address(RVA = "0xABB260", Offset = "0xABA460", VA = "0x180ABB260")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x000193C8 File Offset: 0x000175C8
		[Token(Token = "0x17000EB1")]
		public bool IsUnlimitedStock
		{
			[Token(Token = "0x60067BA")]
			[Address(RVA = "0xABB250", Offset = "0xABA450", VA = "0x180ABB250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB2")]
		public ShopInterface Shop
		{
			[Token(Token = "0x60067BB")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BC")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x000193E0 File Offset: 0x000175E0
		// (set) Token: 0x060067BE RID: 26558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB3")]
		public int CurrentStock
		{
			[Token(Token = "0x60067BD")]
			[Address(RVA = "0x4D4840", Offset = "0x4D3A40", VA = "0x1804D4840")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067BE")]
			[Address(RVA = "0x4D4B00", Offset = "0x4D3D00", VA = "0x1804D4B00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060067BF RID: 26559 RVA: 0x000193F8 File Offset: 0x000175F8
		// (set) Token: 0x060067C0 RID: 26560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB4")]
		public int QuantityInCart
		{
			[Token(Token = "0x60067BF")]
			[Address(RVA = "0x6A0400", Offset = "0x69F600", VA = "0x1806A0400")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067C0")]
			[Address(RVA = "0xABB290", Offset = "0xABA490", VA = "0x180ABB290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x00019410 File Offset: 0x00017610
		[Token(Token = "0x17000EB5")]
		public int CurrentStockMinusCart
		{
			[Token(Token = "0x60067C1")]
			[Address(RVA = "0xABB240", Offset = "0xABA440", VA = "0x180ABB240")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C2")]
		[Address(RVA = "0xABA840", Offset = "0xAB9A40", VA = "0x180ABA840")]
		public void Initialize(ShopInterface shop)
		{
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C3")]
		[Address(RVA = "0xABAEF0", Offset = "0xABA0F0", VA = "0x180ABAEF0")]
		public void Restock(bool network)
		{
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0xABAE40", Offset = "0xABA040", VA = "0x180ABAE40")]
		public void RemoveStock(int quantity)
		{
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0xABAF30", Offset = "0xABA130", VA = "0x180ABAF30")]
		public void SetStock(int quantity, bool network = true)
		{
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0xABAD70", Offset = "0xAB9F70", VA = "0x180ABAD70")]
		public void PullStockFromVariable()
		{
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C7")]
		[Address(RVA = "0xABB170", Offset = "0xABA370", VA = "0x180ABB170")]
		private void StockVariableChanged(float newValue)
		{
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00019428 File Offset: 0x00017628
		[Token(Token = "0x60067C8")]
		[Address(RVA = "0xABB0B0", Offset = "0xABA2B0", VA = "0x180ABB0B0", Slot = "4")]
		public virtual bool ShouldShow()
		{
			return default(bool);
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x60067C9")]
		[Address(RVA = "0xABA6E0", Offset = "0xAB98E0", VA = "0x180ABA6E0", Slot = "5")]
		public virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			return default(bool);
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00019458 File Offset: 0x00017658
		[Token(Token = "0x60067CA")]
		[Address(RVA = "0xABA7E0", Offset = "0xAB99E0", VA = "0x180ABA7E0", Slot = "6")]
		public virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			return default(bool);
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CB")]
		[Address(RVA = "0xABAF00", Offset = "0xABA100", VA = "0x180ABAF00")]
		public void SetQuantityInCart(int quantity)
		{
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CC")]
		[Address(RVA = "0xAA2610", Offset = "0xAA1810", VA = "0x180AA2610")]
		public ShopListing()
		{
		}

		// Token: 0x04004938 RID: 18744
		[Token(Token = "0x4004938")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04004939 RID: 18745
		[Token(Token = "0x4004939")]
		[FieldOffset(Offset = "0x18")]
		public StorableItemDefinition Item;

		// Token: 0x0400493A RID: 18746
		[Token(Token = "0x400493A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Pricing")]
		protected bool OverridePrice;

		// Token: 0x0400493B RID: 18747
		[Token(Token = "0x400493B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float OverriddenPrice;

		// Token: 0x0400493C RID: 18748
		[Token(Token = "0x400493C")]
		[FieldOffset(Offset = "0x28")]
		[Header("Stock")]
		public bool LimitedStock;

		// Token: 0x0400493D RID: 18749
		[Token(Token = "0x400493D")]
		[FieldOffset(Offset = "0x2C")]
		public int DefaultStock;

		// Token: 0x0400493E RID: 18750
		[Token(Token = "0x400493E")]
		[FieldOffset(Offset = "0x30")]
		public ShopListing.ERestockRate RestockRate;

		// Token: 0x0400493F RID: 18751
		[Token(Token = "0x400493F")]
		[FieldOffset(Offset = "0x34")]
		public bool TieStockToNumberVariable;

		// Token: 0x04004940 RID: 18752
		[Token(Token = "0x4004940")]
		[FieldOffset(Offset = "0x38")]
		public string StockVariableName;

		// Token: 0x04004941 RID: 18753
		[Token(Token = "0x4004941")]
		[FieldOffset(Offset = "0x40")]
		[Header("Purchase Tracking")]
		public bool TrackPurchases;

		// Token: 0x04004942 RID: 18754
		[Token(Token = "0x4004942")]
		[FieldOffset(Offset = "0x48")]
		public string PurchasedQuantityVariableName;

		// Token: 0x04004943 RID: 18755
		[Token(Token = "0x4004943")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public bool EnforceMinimumGameCreationVersion;

		// Token: 0x04004944 RID: 18756
		[Token(Token = "0x4004944")]
		[FieldOffset(Offset = "0x54")]
		public float MinimumGameCreationVersion;

		// Token: 0x04004945 RID: 18757
		[Token(Token = "0x4004945")]
		[FieldOffset(Offset = "0x58")]
		public bool CanBeDelivered;

		// Token: 0x04004946 RID: 18758
		[Token(Token = "0x4004946")]
		[FieldOffset(Offset = "0x59")]
		[Header("Color")]
		public bool UseIconTint;

		// Token: 0x04004947 RID: 18759
		[Token(Token = "0x4004947")]
		[FieldOffset(Offset = "0x5C")]
		public Color IconTint;

		// Token: 0x04004948 RID: 18760
		[Token(Token = "0x4004948")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Visibility")]
		public bool ConditionalVisibility;

		// Token: 0x04004949 RID: 18761
		[Token(Token = "0x4004949")]
		[FieldOffset(Offset = "0x70")]
		public string ConditionalVisibilityVariableName;

		// Token: 0x0400494D RID: 18765
		[Token(Token = "0x400494D")]
		[FieldOffset(Offset = "0x88")]
		public Action onStockChanged;

		// Token: 0x0400494E RID: 18766
		[Token(Token = "0x400494E")]
		[FieldOffset(Offset = "0x90")]
		private NumberVariable stockVariable;

		// Token: 0x0400494F RID: 18767
		[Token(Token = "0x400494F")]
		[FieldOffset(Offset = "0x98")]
		private NumberVariable purchasedQuantityVariable;

		// Token: 0x04004950 RID: 18768
		[Token(Token = "0x4004950")]
		[FieldOffset(Offset = "0xA0")]
		private BoolVariable conditionalVisibilityVariable;

		// Token: 0x02000E1E RID: 3614
		[Token(Token = "0x2000E1E")]
		[Serializable]
		public class CategoryInstance
		{
			// Token: 0x060067CD RID: 26573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60067CD")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public CategoryInstance()
			{
			}

			// Token: 0x04004951 RID: 18769
			[Token(Token = "0x4004951")]
			[FieldOffset(Offset = "0x10")]
			public EShopCategory Category;
		}

		// Token: 0x02000E1F RID: 3615
		[Token(Token = "0x2000E1F")]
		public enum ERestockRate
		{
			// Token: 0x04004953 RID: 18771
			[Token(Token = "0x4004953")]
			Daily,
			// Token: 0x04004954 RID: 18772
			[Token(Token = "0x4004954")]
			Weekly,
			// Token: 0x04004955 RID: 18773
			[Token(Token = "0x4004955")]
			Never
		}
	}
}
