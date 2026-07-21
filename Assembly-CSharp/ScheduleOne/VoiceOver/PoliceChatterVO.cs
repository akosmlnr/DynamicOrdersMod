using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class PoliceChatterVO : VOEmitter
	{
		// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0xAF8890", Offset = "0xAF7A90", VA = "0x180AF8890", Slot = "5")]
		public override void Play(EVOLineType lineType)
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0xAF87F0", Offset = "0xAF79F0", VA = "0x180AF87F0")]
		private void PlayChatter()
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0xAF89F0", Offset = "0xAF7BF0", VA = "0x180AF89F0")]
		public PoliceChatterVO()
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0xAF8970", Offset = "0xAF7B70", VA = "0x180AF8970")]
		[CompilerGenerated]
		private IEnumerator <PlayChatter>g__Play|5_0()
		{
			return null;
		}

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController StartBeep;

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController StartEndBeep;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController Static;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine chatterRoutine;
	}
}
