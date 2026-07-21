using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Product
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EA")]
		public ProductDefinition Definition
		{
			[Token(Token = "0x6003FA3")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA4")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x861D00", Offset = "0x860F00", VA = "0x180861D00")]
		public void Initialize(ProductDefinition definition)
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x861B50", Offset = "0x860D50", VA = "0x180861B50")]
		public void Destroy()
		{
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x8624B0", Offset = "0x8616B0", VA = "0x1808624B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x861AC0", Offset = "0x860CC0", VA = "0x180861AC0")]
		private void Clicked()
		{
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x861BD0", Offset = "0x860DD0", VA = "0x180861BD0")]
		private void FavouriteClicked()
		{
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x862AB0", Offset = "0x861CB0", VA = "0x180862AB0")]
		private void ProductListedOrDelisted(ProductDefinition def)
		{
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x862E50", Offset = "0x862050", VA = "0x180862E50")]
		public void UpdateListed()
		{
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x862A30", Offset = "0x861C30", VA = "0x180862A30")]
		private void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x862D10", Offset = "0x861F10", VA = "0x180862D10")]
		public void UpdateFavourited()
		{
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x862B60", Offset = "0x861D60", VA = "0x180862B60")]
		public void UpdateDiscovered(ProductDefinition def)
		{
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ProductEntry()
		{
		}

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x28")]
		public Color SelectedColor;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x38")]
		public Color DeselectedColor;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x48")]
		public Color FavouritedColor;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x58")]
		public Color UnfavouritedColor;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Button Button;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0x70")]
		public Image Frame;

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x78")]
		public Image Icon;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform Tick;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform Cross;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x90")]
		public EventTrigger Trigger;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0x98")]
		public Button FavouriteButton;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0xA0")]
		public Image FavouriteIcon;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onHovered;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0xB0")]
		private bool destroyed;
	}
}
