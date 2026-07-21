using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	[Serializable]
	public class VODatabaseEntry
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0xAFC1C0", Offset = "0xAFB3C0", VA = "0x180AFC1C0")]
		public AudioClip GetRandomClip()
		{
			return null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0xAFC2D0", Offset = "0xAFB4D0", VA = "0x180AFC2D0")]
		public VODatabaseEntry()
		{
		}

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x10")]
		public EVOLineType LineType;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] Clips;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x20")]
		private AudioClip lastClip;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x28")]
		public float VolumeMultiplier;
	}
}
