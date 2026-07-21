using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x02000D28 RID: 3368
	[Token(Token = "0x2000D28")]
	public class ProductManagerApp : App<ProductManagerApp>
	{
		// Token: 0x06006203 RID: 25091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006203")]
		[Address(RVA = "0xA51210", Offset = "0xA50410", VA = "0x180A51210", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006204")]
		[Address(RVA = "0xA51FF0", Offset = "0xA511F0", VA = "0x180A51FF0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006205")]
		[Address(RVA = "0xA517B0", Offset = "0xA509B0", VA = "0x180A517B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006206")]
		[Address(RVA = "0xA51270", Offset = "0xA50470", VA = "0x180A51270", Slot = "12")]
		public virtual void CreateEntry(ProductDefinition definition)
		{
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006207")]
		[Address(RVA = "0xA51890", Offset = "0xA50A90", VA = "0x180A51890")]
		private void ProductFavourited(ProductDefinition product)
		{
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006208")]
		[Address(RVA = "0xA518A0", Offset = "0xA50AA0", VA = "0x180A518A0")]
		private void ProductUnfavourited(ProductDefinition product)
		{
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006209")]
		[Address(RVA = "0xA51500", Offset = "0xA50700", VA = "0x180A51500")]
		private void CreateFavouriteEntry(ProductDefinition definition)
		{
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620A")]
		[Address(RVA = "0xA518B0", Offset = "0xA50AB0", VA = "0x180A518B0")]
		private void RemoveFavouriteEntry(ProductDefinition definition)
		{
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620B")]
		[Address(RVA = "0xA51730", Offset = "0xA50930", VA = "0x180A51730")]
		private void DelayedRebuildLayout()
		{
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620C")]
		[Address(RVA = "0xA51AE0", Offset = "0xA50CE0", VA = "0x180A51AE0")]
		public void SelectProduct(ProductEntry entry)
		{
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620D")]
		[Address(RVA = "0xA51BB0", Offset = "0xA50DB0", VA = "0x180A51BB0", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620E")]
		[Address(RVA = "0xA525F0", Offset = "0xA517F0", VA = "0x180A525F0")]
		public ProductManagerApp()
		{
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600620F")]
		[Address(RVA = "0xA52580", Offset = "0xA51780", VA = "0x180A52580")]
		[CompilerGenerated]
		private IEnumerator <DelayedRebuildLayout>g__Delay|17_0()
		{
			return null;
		}

		// Token: 0x040043F7 RID: 17399
		[Token(Token = "0x40043F7")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public ProductManagerApp.ProductTypeContainer FavouritesContainer;

		// Token: 0x040043F8 RID: 17400
		[Token(Token = "0x40043F8")]
		[FieldOffset(Offset = "0x70")]
		public List<ProductManagerApp.ProductTypeContainer> ProductTypeContainers;

		// Token: 0x040043F9 RID: 17401
		[Token(Token = "0x40043F9")]
		[FieldOffset(Offset = "0x78")]
		public ProductAppDetailPanel DetailPanel;

		// Token: 0x040043FA RID: 17402
		[Token(Token = "0x40043FA")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform SelectionIndicator;

		// Token: 0x040043FB RID: 17403
		[Token(Token = "0x40043FB")]
		[FieldOffset(Offset = "0x88")]
		public GameObject EntryPrefab;

		// Token: 0x040043FC RID: 17404
		[Token(Token = "0x40043FC")]
		[FieldOffset(Offset = "0x90")]
		private List<ProductEntry> favouriteEntries;

		// Token: 0x040043FD RID: 17405
		[Token(Token = "0x40043FD")]
		[FieldOffset(Offset = "0x98")]
		private List<ProductEntry> entries;

		// Token: 0x040043FE RID: 17406
		[Token(Token = "0x40043FE")]
		[FieldOffset(Offset = "0xA0")]
		private ProductEntry selectedEntry;

		// Token: 0x02000D29 RID: 3369
		[Token(Token = "0x2000D29")]
		[Serializable]
		public class ProductTypeContainer
		{
			// Token: 0x06006210 RID: 25104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006210")]
			[Address(RVA = "0xA526E0", Offset = "0xA518E0", VA = "0x180A526E0")]
			public void RefreshNoneDisplay()
			{
			}

			// Token: 0x06006211 RID: 25105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006211")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ProductTypeContainer()
			{
			}

			// Token: 0x040043FF RID: 17407
			[Token(Token = "0x40043FF")]
			[FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04004400 RID: 17408
			[Token(Token = "0x4004400")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform Container;

			// Token: 0x04004401 RID: 17409
			[Token(Token = "0x4004401")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform NoneDisplay;
		}
	}
}
