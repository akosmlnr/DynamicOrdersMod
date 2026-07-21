using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BF1 RID: 3057
	[Token(Token = "0x2000BF1")]
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x06005A52 RID: 23122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x9B6380", Offset = "0x9B5580", VA = "0x1809B6380")]
		public void StartAudio()
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x9B6510", Offset = "0x9B5710", VA = "0x1809B6510")]
		public void StopAudio()
		{
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x9B6310", Offset = "0x9B5510", VA = "0x1809B6310")]
		private IEnumerator StartAudioRoutine()
		{
			return null;
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x9B64A0", Offset = "0x9B56A0", VA = "0x1809B64A0")]
		private IEnumerator StopAudioRoutine()
		{
			return null;
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0x9B6610", Offset = "0x9B5810", VA = "0x1809B6610")]
		private void TryStartAudio()
		{
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A58")]
		[Address(RVA = "0x9B6720", Offset = "0x9B5920", VA = "0x1809B6720")]
		private void TryStopAudio()
		{
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A59")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StartLoopStopAudio()
		{
		}

		// Token: 0x04003C69 RID: 15465
		[Token(Token = "0x4003C69")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("FadeLoopIn")]
		[SerializeField]
		private bool _fadeLoopIn;

		// Token: 0x04003C6A RID: 15466
		[Token(Token = "0x4003C6A")]
		[FieldOffset(Offset = "0x21")]
		[FormerlySerializedAs("FadeLoopOut")]
		[SerializeField]
		private bool _fadeLoopOut;

		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("StartSound")]
		[SerializeField]
		private AudioSourceController _startSound;

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("LoopSound")]
		[SerializeField]
		private AudioSourceController _loopSound;

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("StopSound")]
		[SerializeField]
		private AudioSourceController _stopSound;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _audioRoutine;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x48")]
		private bool _isRunning;
	}
}
