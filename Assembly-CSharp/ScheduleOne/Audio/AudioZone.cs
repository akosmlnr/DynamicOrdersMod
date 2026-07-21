using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD4 RID: 3028
	[Token(Token = "0x2000BD4")]
	public class AudioZone : PolygonalZone
	{
		// Token: 0x060059D0 RID: 22992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x9AB4B0", Offset = "0x9AA6B0", VA = "0x1809AB4B0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D1")]
		[Address(RVA = "0x9ABD60", Offset = "0x9AAF60", VA = "0x1809ABD60")]
		private void Start()
		{
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D2")]
		[Address(RVA = "0x9AB760", Offset = "0x9AA960", VA = "0x1809AB760")]
		private void OnUncappedMinPass()
		{
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D3")]
		[Address(RVA = "0x9AC040", Offset = "0x9AB240", VA = "0x1809AC040")]
		private void Update()
		{
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x00016C38 File Offset: 0x00014E38
		[Token(Token = "0x60059D4")]
		[Address(RVA = "0x9AB580", Offset = "0x9AA780", VA = "0x1809AB580")]
		private float GetModifierMultiplier()
		{
			return 0f;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D5")]
		[Address(RVA = "0x9ABA40", Offset = "0x9AAC40", VA = "0x1809ABA40")]
		private void RecalculateCameraDistance()
		{
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D6")]
		[Address(RVA = "0x9AB370", Offset = "0x9AA570", VA = "0x1809AB370")]
		public void AddModifier(IAudioZoneModifier modifier)
		{
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D7")]
		[Address(RVA = "0x9ABCE0", Offset = "0x9AAEE0", VA = "0x1809ABCE0")]
		public void RemoveModifier(IAudioZoneModifier modifier)
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00016C50 File Offset: 0x00014E50
		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x9AB520", Offset = "0x9AA720", VA = "0x1809AB520")]
		private float GetFalloffFactor(float distance)
		{
			return 0f;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0x9AC2F0", Offset = "0x9AB4F0", VA = "0x1809AC2F0")]
		public AudioZone()
		{
		}

		// Token: 0x04003C03 RID: 15363
		[Token(Token = "0x4003C03")]
		private const float VolumeChangeRate = 1f;

		// Token: 0x04003C04 RID: 15364
		[Token(Token = "0x4003C04")]
		private const float UpdateInterval = 0.25f;

		// Token: 0x04003C05 RID: 15365
		[Token(Token = "0x4003C05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("MaxDistance")]
		[Range(1f, 200f)]
		private float _maximumAudibleDistance;

		// Token: 0x04003C06 RID: 15366
		[Token(Token = "0x4003C06")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("Tracks")]
		private List<AudioZoneTrack> _tracks;

		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		[FieldOffset(Offset = "0x58")]
		private float _localCameraDistance;

		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		[FieldOffset(Offset = "0x5C")]
		private float _currentVolume;

		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		[FieldOffset(Offset = "0x60")]
		private List<IAudioZoneModifier> _modifiers;
	}
}
