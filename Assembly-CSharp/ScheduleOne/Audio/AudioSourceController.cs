using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD2 RID: 3026
	[Token(Token = "0x2000BD2")]
	[RequireComponent(typeof(AudioSource))]
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[Token(Token = "0x17000D04")]
		public bool IsPlaying
		{
			[Token(Token = "0x60059A9")]
			[Address(RVA = "0x9AA810", Offset = "0x9A9A10", VA = "0x1809AA810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x00016BD8 File Offset: 0x00014DD8
		[Token(Token = "0x17000D05")]
		public float Time
		{
			[Token(Token = "0x60059AA")]
			[Address(RVA = "0x9AA890", Offset = "0x9A9A90", VA = "0x1809AA890")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060059AB RID: 22955 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D06")]
		public AudioClip Clip
		{
			[Token(Token = "0x60059AB")]
			[Address(RVA = "0x9AA790", Offset = "0x9A9990", VA = "0x1809AA790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D07")]
		public string Id
		{
			[Token(Token = "0x60059AC")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060059AD RID: 22957 RVA: 0x00016BF0 File Offset: 0x00014DF0
		// (set) Token: 0x060059AE RID: 22958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D08")]
		public float VolumeMultiplier
		{
			[Token(Token = "0x60059AD")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60059AE")]
			[Address(RVA = "0x9AA930", Offset = "0x9A9B30", VA = "0x1809AA930")]
			set
			{
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x00016C08 File Offset: 0x00014E08
		// (set) Token: 0x060059B0 RID: 22960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D09")]
		public float PitchMultiplier
		{
			[Token(Token = "0x60059AF")]
			[Address(RVA = "0x4CBFA0", Offset = "0x4CB1A0", VA = "0x1804CBFA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60059B0")]
			[Address(RVA = "0x9AA920", Offset = "0x9A9B20", VA = "0x1809AA920")]
			set
			{
			}
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x9A94B0", Offset = "0x9A86B0", VA = "0x1809A94B0")]
		private void Awake()
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x9A9D90", Offset = "0x9A8F90", VA = "0x1809A9D90")]
		private void OnEnable()
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x9A9A10", Offset = "0x9A8C10", VA = "0x1809A9A10")]
		private void OnDisable()
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x9A9000", Offset = "0x9A8200", VA = "0x1809A9000")]
		private void ApplyMixer()
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x9AA120", Offset = "0x9A9320", VA = "0x1809AA120")]
		private void OnPause()
		{
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x9AA140", Offset = "0x9A9340", VA = "0x1809AA140")]
		private void OnUnpause()
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x9AA410", Offset = "0x9A9610", VA = "0x1809AA410")]
		public void SetBaseVolume(float baseVolume)
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x9A92A0", Offset = "0x9A84A0", VA = "0x1809A92A0")]
		protected void ApplyVolume()
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x9AA400", Offset = "0x9A9600", VA = "0x1809AA400")]
		public void SetBasePitch(float basePitch)
		{
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x9A91E0", Offset = "0x9A83E0", VA = "0x1809A91E0")]
		private void ApplyPitch()
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x9AA2E0", Offset = "0x9A94E0", VA = "0x1809AA2E0", Slot = "4")]
		public virtual void Play()
		{
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BC")]
		[Address(RVA = "0x9AA250", Offset = "0x9A9450", VA = "0x1809AA250", Slot = "5")]
		public virtual void PlayOneShot()
		{
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x9AA170", Offset = "0x9A9370", VA = "0x1809AA170")]
		public void PlayOneShotDelayed(float delay)
		{
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x9A9680", Offset = "0x9A8880", VA = "0x1809A9680")]
		public void DuplicateAndPlayOneShot()
		{
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0x9A96A0", Offset = "0x9A88A0", VA = "0x1809A96A0", Slot = "6")]
		public virtual void DuplicateAndPlayOneShot(Transform parent)
		{
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x9A95F0", Offset = "0x9A87F0", VA = "0x1809A95F0")]
		protected void Delay(float delay, Action callback)
		{
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0x9A9570", Offset = "0x9A8770", VA = "0x1809A9570")]
		protected IEnumerator DelayIE(float delay, Action callback)
		{
			return null;
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C2")]
		[Address(RVA = "0x9A8F20", Offset = "0x9A8120", VA = "0x1809A8F20")]
		public void ApplyAudioSettings(AudioSettingsWrapper settings)
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x9A9910", Offset = "0x9A8B10", VA = "0x1809A9910")]
		public AudioSettingsWrapper ExtractAudioSettings()
		{
			return null;
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x9AA5E0", Offset = "0x9A97E0", VA = "0x1809AA5E0")]
		public void SetTime(float time)
		{
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x9AA420", Offset = "0x9A9620", VA = "0x1809AA420")]
		public void SetClip(AudioClip clip)
		{
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x9AA500", Offset = "0x9A9700", VA = "0x1809AA500")]
		public void SetLoop(bool loop)
		{
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x9AA6C0", Offset = "0x9A98C0", VA = "0x1809AA6C0")]
		public void Stop()
		{
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x9AA740", Offset = "0x9A9940", VA = "0x1809AA740")]
		public AudioSourceController()
		{
		}

		// Token: 0x04003BF2 RID: 15346
		[Token(Token = "0x4003BF2")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		private string _id;

		// Token: 0x04003BF3 RID: 15347
		[Token(Token = "0x4003BF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("AudioType")]
		private EAudioType _audioType;

		// Token: 0x04003BF4 RID: 15348
		[Token(Token = "0x4003BF4")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("DefaultVolume")]
		[SerializeField]
		[Header("Volume")]
		[Range(0f, 1f)]
		private float _defaultBaseVolume;

		// Token: 0x04003BF5 RID: 15349
		[Token(Token = "0x4003BF5")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 2f)]
		[SerializeField]
		[FormerlySerializedAs("VolumeMultiplier")]
		private float _volumeMultiplier;

		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		[FieldOffset(Offset = "0x34")]
		[Range(0.1f, 3f)]
		[Header("Pitch")]
		[SerializeField]
		private float _defaultBasePitch;

		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 2f)]
		[FormerlySerializedAs("PitchMultiplier")]
		[SerializeField]
		private float _pitchMultiplier;

		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[FormerlySerializedAs("RandomizePitch")]
		private bool _randomizePitch;

		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Conditional("_randomizePitch", false)]
		[FormerlySerializedAs("MinPitch")]
		private float _minRandomPitch;

		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[FormerlySerializedAs("MaxPitch")]
		[Conditional("_randomizePitch", false)]
		private float _maxRandomPitch;

		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		[FieldOffset(Offset = "0x48")]
		[Conditional("_lowPassFilter", false)]
		[SerializeField]
		[FormerlySerializedAs("LowPassFilter")]
		private AudioLowPassFilter _lowPassFilter;

		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		[FieldOffset(Offset = "0x50")]
		protected AudioSource _audioSource;

		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		[FieldOffset(Offset = "0x58")]
		protected float _baseVolume;

		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		[FieldOffset(Offset = "0x5C")]
		protected float _basePitch;
	}
}
