using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BE9 RID: 3049
	[Token(Token = "0x2000BE9")]
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06005A34 RID: 23092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x9B2B90", Offset = "0x9B1D90", VA = "0x1809B2B90", Slot = "4")]
		public override void Play()
		{
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x9B2A50", Offset = "0x9B1C50", VA = "0x1809B2A50", Slot = "5")]
		public override void PlayOneShot()
		{
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A36")]
		[Address(RVA = "0x9AA740", Offset = "0x9A9940", VA = "0x1809AA740")]
		public RandomizedAudioSourceController()
		{
		}

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip[] Clips;
	}
}
