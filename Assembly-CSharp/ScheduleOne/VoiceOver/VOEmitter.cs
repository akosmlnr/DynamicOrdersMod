using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	[RequireComponent(typeof(AudioSourceController))]
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0xAFC5D0", Offset = "0xAFB7D0", VA = "0x180AFC5D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0xAFC620", Offset = "0xAFB820", VA = "0x180AFC620", Slot = "5")]
		public virtual void Play(EVOLineType lineType)
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
		public void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0xAFC9F0", Offset = "0xAFBBF0", VA = "0x180AFC9F0")]
		public void SetDatabase(VODatabase database, bool writeDefault = true)
		{
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0xAFC9D0", Offset = "0xAFBBD0", VA = "0x180AFC9D0")]
		public void ResetDatabase()
		{
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0xAF89F0", Offset = "0xAF7BF0", VA = "0x180AF89F0")]
		public VOEmitter()
		{
		}

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		public const float PitchVariation = 0.05f;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VODatabase Database;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.5f, 2f)]
		public float PitchMultiplier;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x2C")]
		private float runtimePitchMultiplier;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x30")]
		protected AudioSourceController audioSourceController;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x38")]
		private VODatabase defaultVODatabase;
	}
}
