using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x02000D27 RID: 3367
	[Token(Token = "0x2000D27")]
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060061F8 RID: 25080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E1E")]
		public ProductDefinition ActiveProduct
		{
			[Token(Token = "0x60061F7")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60061F8")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060061F9 RID: 25081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061F9")]
		[Address(RVA = "0xA4FA60", Offset = "0xA4EC60", VA = "0x180A4FA60")]
		public void Awake()
		{
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0xA4FEB0", Offset = "0xA4F0B0", VA = "0x180A4FEB0")]
		public void SetActiveProduct(ProductDefinition productDefinition)
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0xA51170", Offset = "0xA50370", VA = "0x180A51170")]
		private void Update()
		{
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0xA51010", Offset = "0xA50210", VA = "0x180A51010")]
		private void UpdateListed()
		{
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0xA510B0", Offset = "0xA502B0", VA = "0x180A510B0")]
		private void UpdatePrice()
		{
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0xA4FB80", Offset = "0xA4ED80", VA = "0x180A4FB80")]
		private void ListingToggled()
		{
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0xA4FCF0", Offset = "0xA4EEF0", VA = "0x180A4FCF0")]
		private void PriceSubmitted(string value)
		{
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006200")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ProductAppDetailPanel()
		{
		}

		// Token: 0x040043E4 RID: 17380
		[Token(Token = "0x40043E4")]
		[FieldOffset(Offset = "0x28")]
		public Color AddictionColor_Min;

		// Token: 0x040043E5 RID: 17381
		[Token(Token = "0x40043E5")]
		[FieldOffset(Offset = "0x38")]
		public Color AddictionColor_Max;

		// Token: 0x040043E6 RID: 17382
		[Token(Token = "0x40043E6")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public GameObject NothingSelected;

		// Token: 0x040043E7 RID: 17383
		[Token(Token = "0x40043E7")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Container;

		// Token: 0x040043E8 RID: 17384
		[Token(Token = "0x40043E8")]
		[FieldOffset(Offset = "0x58")]
		public Text NameLabel;

		// Token: 0x040043E9 RID: 17385
		[Token(Token = "0x40043E9")]
		[FieldOffset(Offset = "0x60")]
		public InputField ValueLabel;

		// Token: 0x040043EA RID: 17386
		[Token(Token = "0x40043EA")]
		[FieldOffset(Offset = "0x68")]
		public Text SuggestedPriceLabel;

		// Token: 0x040043EB RID: 17387
		[Token(Token = "0x40043EB")]
		[FieldOffset(Offset = "0x70")]
		public Toggle ListedForSale;

		// Token: 0x040043EC RID: 17388
		[Token(Token = "0x40043EC")]
		[FieldOffset(Offset = "0x78")]
		public Text DescLabel;

		// Token: 0x040043ED RID: 17389
		[Token(Token = "0x40043ED")]
		[FieldOffset(Offset = "0x80")]
		public Text[] PropertyLabels;

		// Token: 0x040043EE RID: 17390
		[Token(Token = "0x40043EE")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform Listed;

		// Token: 0x040043EF RID: 17391
		[Token(Token = "0x40043EF")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform Delisted;

		// Token: 0x040043F0 RID: 17392
		[Token(Token = "0x40043F0")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform NotDiscovered;

		// Token: 0x040043F1 RID: 17393
		[Token(Token = "0x40043F1")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform RecipesLabel;

		// Token: 0x040043F2 RID: 17394
		[Token(Token = "0x40043F2")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform[] RecipeEntries;

		// Token: 0x040043F3 RID: 17395
		[Token(Token = "0x40043F3")]
		[FieldOffset(Offset = "0xB0")]
		public VerticalLayoutGroup LayoutGroup;

		// Token: 0x040043F4 RID: 17396
		[Token(Token = "0x40043F4")]
		[FieldOffset(Offset = "0xB8")]
		public Scrollbar AddictionSlider;

		// Token: 0x040043F5 RID: 17397
		[Token(Token = "0x40043F5")]
		[FieldOffset(Offset = "0xC0")]
		public Text AddictionLabel;

		// Token: 0x040043F6 RID: 17398
		[Token(Token = "0x40043F6")]
		[FieldOffset(Offset = "0xC8")]
		public ScrollRect ScrollRect;
	}
}
