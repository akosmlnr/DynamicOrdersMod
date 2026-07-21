using System;
using HSVPicker;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000DD5 RID: 3541
	[Token(Token = "0x2000DD5")]
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x060065A3 RID: 26019 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x60065A3")]
		[Address(RVA = "0xA896F0", Offset = "0xA888F0", VA = "0x180A896F0", Slot = "5")]
		public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return default(bool);
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A4")]
		[Address(RVA = "0xA897A0", Offset = "0xA889A0", VA = "0x180A897A0", Slot = "6")]
		public override void OptionSelected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A5")]
		[Address(RVA = "0xA89910", Offset = "0xA88B10", VA = "0x180A89910", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A6")]
		[Address(RVA = "0xA89720", Offset = "0xA88920", VA = "0x180A89720", Slot = "9")]
		public override void Open()
		{
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A7")]
		[Address(RVA = "0xA89670", Offset = "0xA88870", VA = "0x180A89670")]
		public void ColorFieldChanged(Color color)
		{
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0xA895E0", Offset = "0xA887E0", VA = "0x180A895E0")]
		public void ApplyColorChange()
		{
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0xA89850", Offset = "0xA88A50", VA = "0x180A89850")]
		public void RevertColorChange()
		{
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0xA89A60", Offset = "0xA88C60", VA = "0x180A89A60")]
		public BarbershopUI()
		{
		}

		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0xB0")]
		public ColorPicker ColorPicker;

		// Token: 0x04004796 RID: 18326
		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0xB8")]
		public Button ApplyColorButton;

		// Token: 0x04004797 RID: 18327
		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0xC0")]
		private Color appliedColor;
	}
}
