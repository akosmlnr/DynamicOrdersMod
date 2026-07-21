using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Vehicles.Sound
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037C")]
		public LandVehicle Vehicle
		{
			[Token(Token = "0x6001042")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001043")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001044")]
		[Address(RVA = "0xB16940", Offset = "0xB15B40", VA = "0x180B16940", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001045")]
		[Address(RVA = "0xB16C80", Offset = "0xB15E80", VA = "0x180B16C80")]
		private void EngineStart()
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0xB16E10", Offset = "0xB16010", VA = "0x180B16E10")]
		private void HandbrakeApplied()
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001047")]
		[Address(RVA = "0xB17110", Offset = "0xB16310", VA = "0x180B17110")]
		private void StartUpdateVolume()
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001048")]
		[Address(RVA = "0xB17490", Offset = "0xB16690", VA = "0x180B17490")]
		private void UpdateIdle(bool engineRunning)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001049")]
		[Address(RVA = "0xB172E0", Offset = "0xB164E0", VA = "0x180B172E0")]
		private void UpdateEngineLoop(bool engineRunning, float normalizedspeed)
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104A")]
		[Address(RVA = "0xB16E60", Offset = "0xB16060", VA = "0x180B16E60")]
		private void OnCollision(Collision collision)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x7B4090", Offset = "0x7B3290", VA = "0x1807B4090")]
		public VehicleSound()
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600104C")]
		[Address(RVA = "0xB17270", Offset = "0xB16470", VA = "0x180B17270")]
		[CompilerGenerated]
		private IEnumerator <StartUpdateVolume>g__Routine|27_0()
		{
			return null;
		}

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		public const float AUDIO_LERP_SPEED = 2f;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		public const float MinCollisionMomentum = 4000f;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		public const float MaxCollisionMomentum = 25000f;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		public const float MinCollisionVolume = 0.2f;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		public const float MaxCollisionVolume = 0.8f;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		public const float MinCollisionPitch = 0.6f;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		public const float MaxCollisionPitch = 1.1f;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x20")]
		public float EngineVolumeMultiplier;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x24")]
		public float EnginePitchMultiplier;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AudioSourceController EngineStartSource;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController EngineIdleSource;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController EngineLoopSource;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController HandbrakeSource;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController ImpactSound;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x50")]
		[Header("Engine Loop Settings")]
		public AnimationCurve EngineLoopPitchCurve;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve EngineLoopVolumeCurve;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x68")]
		private float lastCollisionTime;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x6C")]
		private float lastCollisionMomentum;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine volumeRoutine;
	}
}
