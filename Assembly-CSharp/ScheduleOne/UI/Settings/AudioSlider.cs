using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CE9 RID: 3305
	[Token(Token = "0x2000CE9")]
	public class AudioSlider : SettingsSlider
	{
		// Token: 0x0600606E RID: 24686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600606E")]
		[Address(RVA = "0xA201B0", Offset = "0xA1F3B0", VA = "0x180A201B0", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600606F")]
		[Address(RVA = "0xA202B0", Offset = "0xA1F4B0", VA = "0x180A202B0", Slot = "6")]
		protected override void OnValueChanged(float value)
		{
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006070")]
		[Address(RVA = "0xA20620", Offset = "0xA1F820", VA = "0x180A20620")]
		public AudioSlider()
		{
		}

		// Token: 0x040042B4 RID: 17076
		[Token(Token = "0x40042B4")]
		public const float MULTIPLIER = 0.01f;

		// Token: 0x040042B5 RID: 17077
		[Token(Token = "0x40042B5")]
		[FieldOffset(Offset = "0x40")]
		public bool Master;

		// Token: 0x040042B6 RID: 17078
		[Token(Token = "0x40042B6")]
		[FieldOffset(Offset = "0x44")]
		public EAudioType AudioType;
	}
}
