using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Audio;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06005997 RID: 22935 RVA: 0x00016B78 File Offset: 0x00014D78
		[Token(Token = "0x17000D00")]
		public float MasterVolume
		{
			[Token(Token = "0x6005997")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06005998 RID: 22936 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005999 RID: 22937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D01")]
		public AudioMixerGroup MainGameMixer
		{
			[Token(Token = "0x6005998")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005999")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600599B RID: 22939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D02")]
		public AudioMixerGroup MenuMixer
		{
			[Token(Token = "0x600599A")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600599B")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600599D RID: 22941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D03")]
		public AudioMixerGroup MusicMixer
		{
			[Token(Token = "0x600599C")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600599D")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599E")]
		[Address(RVA = "0x9A8460", Offset = "0x9A7660", VA = "0x1809A8460", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599F")]
		[Address(RVA = "0x9A8B80", Offset = "0x9A7D80", VA = "0x1809A8B80", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x9A8D60", Offset = "0x9A7F60", VA = "0x1809A8D60")]
		private void Update()
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0x9A8830", Offset = "0x9A7A30", VA = "0x1809A8830")]
		public void SetDistorted(bool distorted, float transition = 5f)
		{
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00016B90 File Offset: 0x00014D90
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x9A85A0", Offset = "0x9A77A0", VA = "0x1809A85A0")]
		public float GetVolume(EAudioType audioType, bool scaled = true)
		{
			return 0f;
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A3")]
		[Address(RVA = "0x9A8950", Offset = "0x9A7B50", VA = "0x1809A8950")]
		public void SetMasterVolume(float volume)
		{
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A4")]
		[Address(RVA = "0x9A8A20", Offset = "0x9A7C20", VA = "0x1809A8A20")]
		public void SetVolume(EAudioType type, float volume)
		{
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x9A8860", Offset = "0x9A7A60", VA = "0x1809A8860")]
		private void SetMainMixerVolume(float value)
		{
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x00016BA8 File Offset: 0x00014DA8
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x9A8E50", Offset = "0x9A8050", VA = "0x1809A8E50")]
		private static float ValueToVolume(float value)
		{
			return 0f;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x9A8EA0", Offset = "0x9A80A0", VA = "0x1809A8EA0")]
		public AudioManager()
		{
		}

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		private const float MinGameVolume = 0.0001f;

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		private const float MaxGameVolume = 1f;

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		private const float GameVolumeLerpSpeed = 2f;

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		[FieldOffset(Offset = "0x28")]
		public Action onVolumeSettingsChanged;

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioMixerSnapshot _defaultSnapshot;

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioMixerSnapshot _distortedSnapshot;

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		[FieldOffset(Offset = "0x58")]
		private float _masterVolume;

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		[FieldOffset(Offset = "0x5C")]
		private float _ambientVolume;

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		[FieldOffset(Offset = "0x60")]
		private float _footstepsVolume;

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		[FieldOffset(Offset = "0x64")]
		private float _fxVolume;

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		[FieldOffset(Offset = "0x68")]
		private float _uiVolume;

		// Token: 0x04003BEE RID: 15342
		[Token(Token = "0x4003BEE")]
		[FieldOffset(Offset = "0x6C")]
		private float _musicVolume;

		// Token: 0x04003BEF RID: 15343
		[Token(Token = "0x4003BEF")]
		[FieldOffset(Offset = "0x70")]
		private float _voiceVolume;

		// Token: 0x04003BF0 RID: 15344
		[Token(Token = "0x4003BF0")]
		[FieldOffset(Offset = "0x74")]
		private float _weatherVolume;

		// Token: 0x04003BF1 RID: 15345
		[Token(Token = "0x4003BF1")]
		[FieldOffset(Offset = "0x78")]
		private float _currentMainMixerVolume;
	}
}
