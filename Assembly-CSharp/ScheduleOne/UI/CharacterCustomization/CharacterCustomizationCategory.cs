using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000DD6 RID: 3542
	[Token(Token = "0x2000DD6")]
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x060065AB RID: 26027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0xA8D1D0", Offset = "0xA8C3D0", VA = "0x180A8D1D0")]
		private void Awake()
		{
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AC")]
		[Address(RVA = "0xA8D700", Offset = "0xA8C900", VA = "0x180A8D700")]
		public void Open()
		{
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AD")]
		[Address(RVA = "0xA8D630", Offset = "0xA8C830", VA = "0x180A8D630")]
		public void Back()
		{
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AE")]
		[Address(RVA = "0xA8DAE0", Offset = "0xA8CCE0", VA = "0x180A8DAE0")]
		private void OptionSelected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AF")]
		[Address(RVA = "0xA8D930", Offset = "0xA8CB30", VA = "0x180A8D930")]
		private void OptionDeselected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B0")]
		[Address(RVA = "0xA8D960", Offset = "0xA8CB60", VA = "0x180A8D960")]
		private void OptionPurchased(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CharacterCustomizationCategory()
		{
		}

		// Token: 0x04004798 RID: 18328
		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x20")]
		public string CategoryName;

		// Token: 0x04004799 RID: 18329
		[Token(Token = "0x4004799")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI TitleText;

		// Token: 0x0400479A RID: 18330
		[Token(Token = "0x400479A")]
		[FieldOffset(Offset = "0x30")]
		public Button BackButton;

		// Token: 0x0400479B RID: 18331
		[Token(Token = "0x400479B")]
		[FieldOffset(Offset = "0x38")]
		public ScrollRect ScrollRect;

		// Token: 0x0400479C RID: 18332
		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x40")]
		private CharacterCustomizationUI ui;

		// Token: 0x0400479D RID: 18333
		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x48")]
		private CharacterCustomizationOption[] options;

		// Token: 0x0400479E RID: 18334
		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onOpen;

		// Token: 0x0400479F RID: 18335
		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onClose;
	}
}
