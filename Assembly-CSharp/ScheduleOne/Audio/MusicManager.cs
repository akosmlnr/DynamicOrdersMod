using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	public class MusicManager : PersistentSingleton<MusicManager>
	{
		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x17000D10")]
		public bool IsAnyTrackPlaying
		{
			[Token(Token = "0x60059F5")]
			[Address(RVA = "0x9AEC40", Offset = "0x9ADE40", VA = "0x1809AEC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x9AE000", Offset = "0x9AD200", VA = "0x1809AE000", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x9AE3C0", Offset = "0x9AD5C0", VA = "0x1809AE3C0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x9AE200", Offset = "0x9AD400", VA = "0x1809AE200")]
		public void SetMusicDistorted(bool distorted, float transition = 5f)
		{
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x9AE230", Offset = "0x9AD430", VA = "0x1809AE230")]
		public void SetTrackEnabled(string trackName, bool enabled)
		{
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x9AE770", Offset = "0x9AD970", VA = "0x1809AE770")]
		public bool TryGetTrack(string trackName, out MusicTrack track)
		{
			return default(bool);
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x9AE5E0", Offset = "0x9AD7E0", VA = "0x1809AE5E0")]
		public void StopTrack(string trackName)
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x9AE4C0", Offset = "0x9AD6C0", VA = "0x1809AE4C0")]
		public void StopAndDisableTracks()
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		private void UpdateTracks()
		{
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x9AEBB0", Offset = "0x9ADDB0", VA = "0x1809AEBB0")]
		public MusicManager()
		{
		}

		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		private const float TrackUpdateInterval = 0.2f;

		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("DefaultSnapshot")]
		[SerializeField]
		private AudioMixerSnapshot _defaultSnapshot;

		// Token: 0x04003C33 RID: 15411
		[Token(Token = "0x4003C33")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("DistortedSnapshot")]
		[SerializeField]
		private AudioMixerSnapshot _distortedSnapshot;

		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		[FieldOffset(Offset = "0x38")]
		private List<MusicTrack> _tracks;

		// Token: 0x04003C35 RID: 15413
		[Token(Token = "0x4003C35")]
		[FieldOffset(Offset = "0x40")]
		private MusicTrack _currentTrack;
	}
}
