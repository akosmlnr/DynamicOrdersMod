using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BE3 RID: 3043
	[Token(Token = "0x2000BE3")]
	[RequireComponent(typeof(AudioSourceController))]
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x00016D28 File Offset: 0x00014F28
		// (set) Token: 0x06005A0A RID: 23050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D11")]
		public bool IsPlaying
		{
			[Token(Token = "0x6005A09")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A0A")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D12")]
		public string TrackName
		{
			[Token(Token = "0x6005A0B")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x00016D40 File Offset: 0x00014F40
		[Token(Token = "0x17000D13")]
		public int Priority
		{
			[Token(Token = "0x6005A0C")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x9AEF30", Offset = "0x9AE130", VA = "0x1809AEF30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x9AEF90", Offset = "0x9AE190", VA = "0x1809AEF90")]
		private void OnValidate()
		{
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x876340", Offset = "0x875540", VA = "0x180876340")]
		public void Enable()
		{
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x81E560", Offset = "0x81D760", VA = "0x18081E560")]
		public void Disable()
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x9AF050", Offset = "0x9AE250", VA = "0x1809AF050", Slot = "5")]
		public virtual void Play()
		{
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x79FFB0", Offset = "0x79F1B0", VA = "0x18079FFB0", Slot = "6")]
		public virtual void Stop()
		{
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x9AF080", Offset = "0x9AE280", VA = "0x1809AF080", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x9AF1C0", Offset = "0x9AE3C0", VA = "0x1809AF1C0")]
		public MusicTrack()
		{
		}

		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		[FieldOffset(Offset = "0x21")]
		public bool Enabled;

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("TrackName")]
		private string _trackName;

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("Priority")]
		private int _priority;

		// Token: 0x04003C3D RID: 15421
		[Token(Token = "0x4003C3D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[FormerlySerializedAs("VolumeMultiplier")]
		protected float _volumeMultiplier;

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("FadeInTime")]
		[SerializeField]
		protected float _fadeInTime;

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[FormerlySerializedAs("FadeOutTime")]
		protected float _fadeOutTime;

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("AutoFadeOut")]
		[SerializeField]
		protected bool _autoFadeOut;

		// Token: 0x04003C41 RID: 15425
		[Token(Token = "0x4003C41")]
		[FieldOffset(Offset = "0x48")]
		protected AudioSourceController _audioSource;

		// Token: 0x04003C42 RID: 15426
		[Token(Token = "0x4003C42")]
		[FieldOffset(Offset = "0x50")]
		protected float _fadeVolumeMultiplier;
	}
}
