using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06005E27 RID: 24103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0xA0AE40", Offset = "0xA0A040", VA = "0x180A0AE40", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0xA0B1E0", Offset = "0xA0A3E0", VA = "0x180A0B1E0")]
		private void UpdateDisplayedEnergy()
		{
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0xA0AF90", Offset = "0xA0A190", VA = "0x180A0AF90")]
		public void SetDisplayedEnergy(float energy)
		{
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0xA0B2D0", Offset = "0xA0A4D0", VA = "0x180A0B2D0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0xA0B630", Offset = "0xA0A830", VA = "0x180A0B630")]
		public PlayerEnergyUI()
		{
		}

		// Token: 0x040040A2 RID: 16546
		[Token(Token = "0x40040A2")]
		[FieldOffset(Offset = "0x28")]
		public Slider Slider;

		// Token: 0x040040A3 RID: 16547
		[Token(Token = "0x40040A3")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform SliderRect;

		// Token: 0x040040A4 RID: 16548
		[Token(Token = "0x40040A4")]
		[FieldOffset(Offset = "0x38")]
		public Image FillImage;

		// Token: 0x040040A5 RID: 16549
		[Token(Token = "0x40040A5")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI Label;

		// Token: 0x040040A6 RID: 16550
		[Token(Token = "0x40040A6")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public Color SliderColor_Green;

		// Token: 0x040040A7 RID: 16551
		[Token(Token = "0x40040A7")]
		[FieldOffset(Offset = "0x58")]
		public Color SliderColor_Red;

		// Token: 0x040040A8 RID: 16552
		[Token(Token = "0x40040A8")]
		[FieldOffset(Offset = "0x68")]
		private float displayedValue;
	}
}
