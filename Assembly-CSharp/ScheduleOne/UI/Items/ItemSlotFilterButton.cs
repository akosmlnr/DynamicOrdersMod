using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DFB RID: 3579
	[Token(Token = "0x2000DFB")]
	public class ItemSlotFilterButton : MonoBehaviour
	{
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600668E RID: 26254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8D")]
		public ItemSlot AssignedSlot
		{
			[Token(Token = "0x600668D")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600668E")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006690")]
		[Address(RVA = "0xA95600", Offset = "0xA94800", VA = "0x180A95600")]
		public void AssignSlot(ItemSlot slot)
		{
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006691")]
		[Address(RVA = "0xA96150", Offset = "0xA95350", VA = "0x180A96150")]
		public void UnassignSlot()
		{
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006692")]
		[Address(RVA = "0xA95C40", Offset = "0xA94E40", VA = "0x180A95C40")]
		public void Clicked()
		{
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006693")]
		[Address(RVA = "0xA95D40", Offset = "0xA94F40", VA = "0x180A95D40")]
		private void RefreshAppearance()
		{
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006694")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemSlotFilterButton()
		{
		}

		// Token: 0x0400485E RID: 18526
		[Token(Token = "0x400485E")]
		[FieldOffset(Offset = "0x28")]
		public ItemSlotUI ItemSlotUI;

		// Token: 0x0400485F RID: 18527
		[Token(Token = "0x400485F")]
		[FieldOffset(Offset = "0x30")]
		public Button Button;

		// Token: 0x04004860 RID: 18528
		[Token(Token = "0x4004860")]
		[FieldOffset(Offset = "0x38")]
		public Image IconImage;

		// Token: 0x04004861 RID: 18529
		[Token(Token = "0x4004861")]
		[FieldOffset(Offset = "0x40")]
		public Image SpotImage;

		// Token: 0x04004862 RID: 18530
		[Token(Token = "0x4004862")]
		[FieldOffset(Offset = "0x48")]
		public Image[] FilterItemImages;

		// Token: 0x04004863 RID: 18531
		[Token(Token = "0x4004863")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI FilterMoreItemsLabel;
	}
}
