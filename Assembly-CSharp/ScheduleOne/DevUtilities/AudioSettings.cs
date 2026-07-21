using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	[Serializable]
	public class AudioSettings
	{
		// Token: 0x060049E6 RID: 18918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E6")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public AudioSettings()
		{
		}

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x10")]
		public float MasterVolume;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x14")]
		public float AmbientVolume;

		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		[FieldOffset(Offset = "0x18")]
		public float MusicVolume;

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x1C")]
		public float SFXVolume;

		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		[FieldOffset(Offset = "0x20")]
		public float UIVolume;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x24")]
		public float DialogueVolume;

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x28")]
		public float FootstepsVolume;

		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		[FieldOffset(Offset = "0x2C")]
		public float WeatherVolume;
	}
}
