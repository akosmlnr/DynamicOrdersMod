using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000E0B")]
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x00019170 File Offset: 0x00017370
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9E")]
		public bool isSelected
		{
			[Token(Token = "0x6006724")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006725")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006726")]
		[Address(RVA = "0xAA1700", Offset = "0xAA0900", VA = "0x180AA1700")]
		private void Awake()
		{
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006727")]
		[Address(RVA = "0xAA1800", Offset = "0xAA0A00", VA = "0x180AA1800")]
		private void Clicked()
		{
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006728")]
		[Address(RVA = "0xAA1820", Offset = "0xAA0A20", VA = "0x180AA1820")]
		public void Deselect()
		{
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006729")]
		[Address(RVA = "0xAA1900", Offset = "0xAA0B00", VA = "0x180AA1900")]
		public void Select()
		{
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672A")]
		[Address(RVA = "0xAA1830", Offset = "0xAA0A30", VA = "0x180AA1830")]
		private void RefreshUI()
		{
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CategoryButton()
		{
		}

		// Token: 0x040048B6 RID: 18614
		[Token(Token = "0x40048B6")]
		[FieldOffset(Offset = "0x24")]
		public EShopCategory Category;

		// Token: 0x040048B7 RID: 18615
		[Token(Token = "0x40048B7")]
		[FieldOffset(Offset = "0x28")]
		private Button button;

		// Token: 0x040048B8 RID: 18616
		[Token(Token = "0x40048B8")]
		[FieldOffset(Offset = "0x30")]
		private ShopInterface shop;
	}
}
