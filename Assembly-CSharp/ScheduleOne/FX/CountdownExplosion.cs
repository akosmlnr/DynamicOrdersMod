using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x06002B35 RID: 11061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B35")]
		[Address(RVA = "0x6F8660", Offset = "0x6F7860", VA = "0x1806F8660")]
		public void Trigger()
		{
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B36")]
		[Address(RVA = "0x6F85D0", Offset = "0x6F77D0", VA = "0x1806F85D0")]
		public void StopCountdown()
		{
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B37")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CountdownExplosion()
		{
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x6F8760", Offset = "0x6F7960", VA = "0x1806F8760")]
		[CompilerGenerated]
		private IEnumerator <Trigger>g__Routine|5_0()
		{
			return null;
		}

		// Token: 0x04002056 RID: 8278
		[Token(Token = "0x4002056")]
		public const float COUNTDOWN = 30f;

		// Token: 0x04002057 RID: 8279
		[Token(Token = "0x4002057")]
		public const float TICK_SPACING_MAX = 1f;

		// Token: 0x04002058 RID: 8280
		[Token(Token = "0x4002058")]
		public const float TICK_SPACING_MIN = 0.1f;

		// Token: 0x04002059 RID: 8281
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController TickSound;

		// Token: 0x0400205A RID: 8282
		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine countdownRoutine;
	}
}
