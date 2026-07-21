using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DFC RID: 3580
	[Token(Token = "0x2000DFC")]
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x06006695 RID: 26261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006695")]
		[Address(RVA = "0xA9B730", Offset = "0xA9A930", VA = "0x180A9B730", Slot = "4")]
		public virtual void Setup(ItemInstance item)
		{
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006696")]
		[Address(RVA = "0xA9B3F0", Offset = "0xA9A5F0", VA = "0x180A9B3F0", Slot = "5")]
		public virtual void Destroy()
		{
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006697")]
		[Address(RVA = "0xA9B4D0", Offset = "0xA9A6D0", VA = "0x180A9B4D0", Slot = "6")]
		public virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006698")]
		[Address(RVA = "0xA9B6F0", Offset = "0xA9A8F0", VA = "0x180A9B6F0", Slot = "7")]
		public virtual void SetVisible(bool vis)
		{
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006699")]
		[Address(RVA = "0xA9B860", Offset = "0xA9AA60", VA = "0x180A9B860", Slot = "8")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600669A")]
		[Address(RVA = "0xA9B630", Offset = "0xA9A830", VA = "0x180A9B630", Slot = "9")]
		public virtual void SetDisplayedQuantity(int quantity)
		{
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600669B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemUI()
		{
		}

		// Token: 0x04004864 RID: 18532
		[Token(Token = "0x4004864")]
		[FieldOffset(Offset = "0x20")]
		protected ItemInstance itemInstance;

		// Token: 0x04004865 RID: 18533
		[Token(Token = "0x4004865")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04004866 RID: 18534
		[Token(Token = "0x4004866")]
		[FieldOffset(Offset = "0x30")]
		public Image IconImg;

		// Token: 0x04004867 RID: 18535
		[Token(Token = "0x4004867")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x04004868 RID: 18536
		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0x40")]
		protected int DisplayedQuantity;

		// Token: 0x04004869 RID: 18537
		[Token(Token = "0x4004869")]
		[FieldOffset(Offset = "0x44")]
		protected bool Destroyed;
	}
}
