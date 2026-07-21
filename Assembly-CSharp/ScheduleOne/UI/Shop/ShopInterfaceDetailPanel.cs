using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E1B RID: 3611
	[Token(Token = "0x2000E1B")]
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		// Token: 0x060067AB RID: 26539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AB")]
		[Address(RVA = "0x863150", Offset = "0x862350", VA = "0x180863150")]
		private void Awake()
		{
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AC")]
		[Address(RVA = "0xAB4E10", Offset = "0xAB4010", VA = "0x180AB4E10")]
		public void Open(ListingUI _listing)
		{
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AD")]
		[Address(RVA = "0xAB4E00", Offset = "0xAB4000", VA = "0x180AB4E00")]
		private void LateUpdate()
		{
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AE")]
		[Address(RVA = "0xAB5080", Offset = "0xAB4280", VA = "0x180AB5080")]
		private void Position()
		{
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AF")]
		[Address(RVA = "0xAB4DB0", Offset = "0xAB3FB0", VA = "0x180AB4DB0")]
		public void Close()
		{
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ShopInterfaceDetailPanel()
		{
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60067B1")]
		[Address(RVA = "0xAB51B0", Offset = "0xAB43B0", VA = "0x180AB51B0")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Wait|6_0()
		{
			return null;
		}

		// Token: 0x04004930 RID: 18736
		[Token(Token = "0x4004930")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public RectTransform Panel;

		// Token: 0x04004931 RID: 18737
		[Token(Token = "0x4004931")]
		[FieldOffset(Offset = "0x28")]
		public VerticalLayoutGroup LayoutGroup;

		// Token: 0x04004932 RID: 18738
		[Token(Token = "0x4004932")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI DescriptionLabel;

		// Token: 0x04004933 RID: 18739
		[Token(Token = "0x4004933")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI UnlockLabel;

		// Token: 0x04004934 RID: 18740
		[Token(Token = "0x4004934")]
		[FieldOffset(Offset = "0x40")]
		private ListingUI listing;
	}
}
