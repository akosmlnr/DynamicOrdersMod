using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BE4 RID: 3044
	[Token(Token = "0x2000BE4")]
	public class PursuitLoopMusicTrack : PursuitMusicTrack
	{
		// Token: 0x06005A15 RID: 23061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x9B1940", Offset = "0x9B0B40", VA = "0x1809B1940", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x9B1AB0", Offset = "0x9B0CB0", VA = "0x1809B1AB0", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x9B1B50", Offset = "0x9B0D50", VA = "0x1809B1B50", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x9B19A0", Offset = "0x9B0BA0", VA = "0x1809B19A0", Slot = "5")]
		public override void Play()
		{
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x9B1D60", Offset = "0x9B0F60", VA = "0x1809B1D60")]
		public PursuitLoopMusicTrack()
		{
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		private IEnumerator <Play>g__WaitForStart|4_0()
		{
			return null;
		}

		// Token: 0x04003C43 RID: 15427
		[Token(Token = "0x4003C43")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController LoopSound;
	}
}
