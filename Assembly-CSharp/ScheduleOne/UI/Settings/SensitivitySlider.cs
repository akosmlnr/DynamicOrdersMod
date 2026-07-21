using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x2000CF9")]
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x060060B8 RID: 24760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B8")]
		[Address(RVA = "0xA34440", Offset = "0xA33640", VA = "0x180A34440", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0xA34290", Offset = "0xA33490", VA = "0x180A34290", Slot = "6")]
		protected override void OnValueChanged(float value)
		{
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BA")]
		[Address(RVA = "0xA21850", Offset = "0xA20A50", VA = "0x180A21850")]
		public SensitivitySlider()
		{
		}

		// Token: 0x040042C9 RID: 17097
		[Token(Token = "0x40042C9")]
		public const float MULTIPLIER = 0.033333335f;
	}
}
