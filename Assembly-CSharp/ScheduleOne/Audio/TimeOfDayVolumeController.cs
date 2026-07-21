using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BF4 RID: 3060
	[Token(Token = "0x2000BF4")]
	[RequireComponent(typeof(AudioSourceController))]
	public class TimeOfDayVolumeController : MonoBehaviour
	{
		// Token: 0x06005A66 RID: 23142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x9B95D0", Offset = "0x9B87D0", VA = "0x1809B95D0")]
		private void Awake()
		{
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x9B9620", Offset = "0x9B8820", VA = "0x1809B9620")]
		private void Update()
		{
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x9B9820", Offset = "0x9B8A20", VA = "0x1809B9820")]
		public TimeOfDayVolumeController()
		{
		}

		// Token: 0x04003C7A RID: 15482
		[Token(Token = "0x4003C7A")]
		private const float MinVolume = 0.3f;

		// Token: 0x04003C7B RID: 15483
		[Token(Token = "0x4003C7B")]
		private const float FadeSpeed = 0.25f;

		// Token: 0x04003C7C RID: 15484
		[Token(Token = "0x4003C7C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("VolumeCurve")]
		private AnimationCurve _timeOfDayVolumeCurve;

		// Token: 0x04003C7D RID: 15485
		[Token(Token = "0x4003C7D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("FadeDuringMusic")]
		private bool _reduceVolumeWhenSoundtrackPlaying;

		// Token: 0x04003C7E RID: 15486
		[Token(Token = "0x4003C7E")]
		[FieldOffset(Offset = "0x30")]
		private AudioSourceController _audioSourceController;

		// Token: 0x04003C7F RID: 15487
		[Token(Token = "0x4003C7F")]
		[FieldOffset(Offset = "0x38")]
		private float _volumeMultiplier;
	}
}
