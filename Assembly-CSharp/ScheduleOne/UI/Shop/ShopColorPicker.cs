using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x17000EA2")]
		public bool IsOpen
		{
			[Token(Token = "0x6006752")]
			[Address(RVA = "0xAB4D80", Offset = "0xAB3F80", VA = "0x180AB4D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006753")]
		[Address(RVA = "0xAB4760", Offset = "0xAB3960", VA = "0x180AB4760")]
		public void Start()
		{
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006754")]
		[Address(RVA = "0xAB4690", Offset = "0xAB3890", VA = "0x180AB4690")]
		private void ColorPicked(EClothingColor color)
		{
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006755")]
		[Address(RVA = "0xAB4700", Offset = "0xAB3900", VA = "0x180AB4700")]
		public void Open(ItemDefinition item)
		{
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006756")]
		[Address(RVA = "0x74D910", Offset = "0x74CB10", VA = "0x18074D910")]
		public void Close()
		{
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006757")]
		[Address(RVA = "0xAB4600", Offset = "0xAB3800", VA = "0x180AB4600")]
		private void ColorHovered(EClothingColor color)
		{
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006758")]
		[Address(RVA = "0xAB4D00", Offset = "0xAB3F00", VA = "0x180AB4D00")]
		public ShopColorPicker()
		{
		}

		// Token: 0x040048E8 RID: 18664
		[Token(Token = "0x40048E8")]
		[FieldOffset(Offset = "0x20")]
		public Image AssetIconImage;

		// Token: 0x040048E9 RID: 18665
		[Token(Token = "0x40048E9")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI ColorLabel;

		// Token: 0x040048EA RID: 18666
		[Token(Token = "0x40048EA")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform ColorButtonParent;

		// Token: 0x040048EB RID: 18667
		[Token(Token = "0x40048EB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ColorButtonPrefab;

		// Token: 0x040048EC RID: 18668
		[Token(Token = "0x40048EC")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<EClothingColor> onColorPicked;
	}
}
