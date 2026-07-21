using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x0600608E RID: 24718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600608E")]
		[Address(RVA = "0xA27C60", Offset = "0xA26E60", VA = "0x180A27C60", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600608F")]
		[Address(RVA = "0xA27D30", Offset = "0xA26F30", VA = "0x180A27D30", Slot = "6")]
		protected override void OnValueChanged(float value)
		{
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006090")]
		[Address(RVA = "0xA27B60", Offset = "0xA26D60", VA = "0x180A27B60", Slot = "7")]
		protected override string GetDisplayValue(float value)
		{
			return null;
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006091")]
		[Address(RVA = "0xA21850", Offset = "0xA20A50", VA = "0x180A21850")]
		public IntefaceScaleSlider()
		{
		}

		// Token: 0x040042C0 RID: 17088
		[Token(Token = "0x40042C0")]
		public const float MULTIPLIER = 0.1f;

		// Token: 0x040042C1 RID: 17089
		[Token(Token = "0x40042C1")]
		public const float MinScale = 0.7f;

		// Token: 0x040042C2 RID: 17090
		[Token(Token = "0x40042C2")]
		public const float MaxScale = 1.4f;
	}
}
