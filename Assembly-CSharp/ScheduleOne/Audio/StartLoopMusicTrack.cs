using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BE7 RID: 3047
	[Token(Token = "0x2000BE7")]
	public class StartLoopMusicTrack : MusicTrack
	{
		// Token: 0x06005A28 RID: 23080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x9B1940", Offset = "0x9B0B40", VA = "0x1809B1940", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x9B6190", Offset = "0x9B5390", VA = "0x1809B6190")]
		private void Start()
		{
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x9B6230", Offset = "0x9B5430", VA = "0x1809B6230", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x9B6080", Offset = "0x9B5280", VA = "0x1809B6080", Slot = "5")]
		public override void Play()
		{
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x9B1D60", Offset = "0x9B0F60", VA = "0x1809B1D60")]
		public StartLoopMusicTrack()
		{
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x9B61C0", Offset = "0x9B53C0", VA = "0x1809B61C0")]
		[CompilerGenerated]
		private IEnumerator <Play>g__WaitForStart|4_0()
		{
			return null;
		}

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController LoopSound;
	}
}
