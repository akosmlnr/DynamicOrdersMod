using System;
using Il2CppDummyDll;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BF0 RID: 3056
	[Token(Token = "0x2000BF0")]
	[RequireComponent(typeof(AudioSourceController))]
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06005A4F RID: 23119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0x9B5DA0", Offset = "0x9B4FA0", VA = "0x1809B5DA0")]
		private void Awake()
		{
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A50")]
		[Address(RVA = "0x9B5DF0", Offset = "0x9B4FF0", VA = "0x1809B5DF0")]
		private void Update()
		{
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A51")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SpottedTremolo()
		{
		}

		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		private const float MinVolume = 0f;

		// Token: 0x04003C61 RID: 15457
		[Token(Token = "0x4003C61")]
		private const float MaxVolume = 1f;

		// Token: 0x04003C62 RID: 15458
		[Token(Token = "0x4003C62")]
		private const float MinPitch = 1.2f;

		// Token: 0x04003C63 RID: 15459
		[Token(Token = "0x4003C63")]
		private const float MaxPitch = 1.3f;

		// Token: 0x04003C64 RID: 15460
		[Token(Token = "0x4003C64")]
		private const float SmoothTime = 0.25f;

		// Token: 0x04003C65 RID: 15461
		[Token(Token = "0x4003C65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("PlayerVisibility")]
		private EntityVisibility _visibilityComponent;

		// Token: 0x04003C66 RID: 15462
		[Token(Token = "0x4003C66")]
		[FieldOffset(Offset = "0x28")]
		private AudioSourceController _audio;

		// Token: 0x04003C67 RID: 15463
		[Token(Token = "0x4003C67")]
		[FieldOffset(Offset = "0x30")]
		private float _targetIntensity;

		// Token: 0x04003C68 RID: 15464
		[Token(Token = "0x4003C68")]
		[FieldOffset(Offset = "0x34")]
		private float _smoothedIntensity;
	}
}
