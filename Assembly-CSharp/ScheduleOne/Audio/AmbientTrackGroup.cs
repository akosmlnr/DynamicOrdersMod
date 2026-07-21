using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x2000BCF")]
	public class AmbientTrackGroup : MonoBehaviour
	{
		// Token: 0x0600598C RID: 22924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598C")]
		[Address(RVA = "0x9A7460", Offset = "0x9A6660", VA = "0x1809A7460")]
		private void Awake()
		{
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598D")]
		[Address(RVA = "0x9A7800", Offset = "0x9A6A00", VA = "0x1809A7800")]
		[Button]
		public void ForcePlay()
		{
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598E")]
		[Address(RVA = "0x9A7980", Offset = "0x9A6B80", VA = "0x1809A7980")]
		public void Stop()
		{
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598F")]
		[Address(RVA = "0x9A7A10", Offset = "0x9A6C10", VA = "0x1809A7A10")]
		private void Update()
		{
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00016B60 File Offset: 0x00014D60
		[Token(Token = "0x6005990")]
		[Address(RVA = "0x9A7580", Offset = "0x9A6780", VA = "0x1809A7580", Slot = "4")]
		protected virtual bool CanPlayNow()
		{
			return default(bool);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005991")]
		[Address(RVA = "0x9A7FC0", Offset = "0x9A71C0", VA = "0x1809A7FC0")]
		public AmbientTrackGroup()
		{
		}

		// Token: 0x04003BD1 RID: 15313
		[Token(Token = "0x4003BD1")]
		private const float AmbientTrackCooldown = 540f;

		// Token: 0x04003BD2 RID: 15314
		[Token(Token = "0x4003BD2")]
		[FieldOffset(Offset = "0x0")]
		private static float TimeOnLastAmbientTrackStart;

		// Token: 0x04003BD3 RID: 15315
		[Token(Token = "0x4003BD3")]
		[FieldOffset(Offset = "0x8")]
		private static AmbientTrackGroup LastPlayedTrackGroup;

		// Token: 0x04003BD4 RID: 15316
		[Token(Token = "0x4003BD4")]
		[FieldOffset(Offset = "0x10")]
		private static bool IsAnyTrackGroupQueued;

		// Token: 0x04003BD5 RID: 15317
		[Token(Token = "0x4003BD5")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("Tracks")]
		[SerializeField]
		private List<MusicTrack> _trackList;

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("MinTime")]
		[SerializeField]
		private int _windowStartTime;

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("MaxTime")]
		[SerializeField]
		private int _windowEndTime;

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("Chance")]
		[Range(0f, 1f)]
		private float _chanceToPlay;

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		[FieldOffset(Offset = "0x34")]
		private int _startTime;

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		[FieldOffset(Offset = "0x38")]
		private bool _playTrack;

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		[FieldOffset(Offset = "0x39")]
		private bool _trackRandomized;
	}
}
