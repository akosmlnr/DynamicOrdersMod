using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x2000BCC")]
	[Serializable]
	public class AudioSettingsWrapper
	{
		// Token: 0x06005986 RID: 22918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005986")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public AudioSettingsWrapper()
		{
		}

		// Token: 0x04003BBD RID: 15293
		[Token(Token = "0x4003BBD")]
		[FieldOffset(Offset = "0x10")]
		public EAudioType AudioType;

		// Token: 0x04003BBE RID: 15294
		[Token(Token = "0x4003BBE")]
		[FieldOffset(Offset = "0x14")]
		public float Volume;

		// Token: 0x04003BBF RID: 15295
		[Token(Token = "0x4003BBF")]
		[FieldOffset(Offset = "0x18")]
		public float VolumeMultiplier;

		// Token: 0x04003BC0 RID: 15296
		[Token(Token = "0x4003BC0")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 MinMaxPitch;

		// Token: 0x04003BC1 RID: 15297
		[Token(Token = "0x4003BC1")]
		[FieldOffset(Offset = "0x24")]
		public float PitchMultiplier;

		// Token: 0x04003BC2 RID: 15298
		[Token(Token = "0x4003BC2")]
		[FieldOffset(Offset = "0x28")]
		public bool RandomizePitch;

		// Token: 0x04003BC3 RID: 15299
		[Token(Token = "0x4003BC3")]
		[FieldOffset(Offset = "0x2C")]
		[Range(10f, 22000f)]
		public int LowPassCutoffFrequency;
	}
}
