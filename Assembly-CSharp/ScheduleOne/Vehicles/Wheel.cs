using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.Experimental;
using ScheduleOne.Weather;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public class Wheel : MonoBehaviour
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00007AA0 File Offset: 0x00005CA0
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000377")]
		public bool IsDrifting
		{
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x8F30F0", Offset = "0x8F22F0", VA = "0x1808F30F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x8F3180", Offset = "0x8F2380", VA = "0x1808F3180")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x17000378")]
		public bool IsDrifting_Smoothed
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0xB18FB0", Offset = "0xB181B0", VA = "0x180B18FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00007AD0 File Offset: 0x00005CD0
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		public float DriftTime
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x7ED1F0", Offset = "0x7EC3F0", VA = "0x1807ED1F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001030")]
			[Address(RVA = "0xB18FF0", Offset = "0xB181F0", VA = "0x180B18FF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00007AE8 File Offset: 0x00005CE8
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037A")]
		public float DriftIntensity
		{
			[Token(Token = "0x6001031")]
			[Address(RVA = "0x6A03A0", Offset = "0x69F5A0", VA = "0x1806A03A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001032")]
			[Address(RVA = "0xB18FE0", Offset = "0xB181E0", VA = "0x180B18FE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037B")]
		public bool IsSteerWheel
		{
			[Token(Token = "0x6001033")]
			[Address(RVA = "0xB18FD0", Offset = "0xB181D0", VA = "0x180B18FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001034")]
			[Address(RVA = "0xB19000", Offset = "0xB18200", VA = "0x180B19000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0xB17FD0", Offset = "0xB171D0", VA = "0x180B17FD0")]
		private void Awake()
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001036")]
		[Address(RVA = "0xB18D10", Offset = "0xB17F10", VA = "0x180B18D10", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001037")]
		[Address(RVA = "0xB185D0", Offset = "0xB177D0", VA = "0x180B185D0")]
		public void FixedUpdateWheel()
		{
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001038")]
		[Address(RVA = "0xB183D0", Offset = "0xB175D0", VA = "0x180B183D0")]
		public void FakeWheelRotation()
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001039")]
		[Address(RVA = "0xB180B0", Offset = "0xB172B0", VA = "0x180B180B0")]
		private void CheckDrifting()
		{
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0xB18EC0", Offset = "0xB180C0", VA = "0x180B18EC0")]
		private void UpdateDriftEffects()
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103B")]
		[Address(RVA = "0xB18DD0", Offset = "0xB17FD0", VA = "0x180B18DD0")]
		private void UpdateDriftAudio()
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103C")]
		[Address(RVA = "0xB17C40", Offset = "0xB16E40", VA = "0x180B17C40")]
		private void ApplyFriction()
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103D")]
		[Address(RVA = "0xB18AB0", Offset = "0xB17CB0", VA = "0x180B18AB0", Slot = "5")]
		public virtual void SetPhysicsEnabled(bool enabled)
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x600103E")]
		[Address(RVA = "0xB18890", Offset = "0xB17A90", VA = "0x180B18890")]
		public bool IsWheelGrounded()
		{
			return default(bool);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103F")]
		[Address(RVA = "0xB188E0", Offset = "0xB17AE0", VA = "0x180B188E0")]
		public void OnWeatherChange(WeatherConditions newConditions)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001040")]
		[Address(RVA = "0xB17AC0", Offset = "0xB16CC0", VA = "0x180B17AC0")]
		[Button]
		private void ApplyDefaultWheelModelPosition()
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001041")]
		[Address(RVA = "0xB18F40", Offset = "0xB18140", VA = "0x180B18F40")]
		public Wheel()
		{
		}

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		public const float MIN_SPEED_FOR_DRIFT = 8f;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		public const float WHEEL_ANIMATION_DISTANCE = 40f;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		public const float HandbrakeFowardStiffnessMultiplier_Front = 0.9f;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		public const float HandbrakeSidewayStiffnessMultiplier_Front = 0.7f;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		public const float HandbrakeFowardStiffnessMultiplier_Rear = 0.9f;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		public const float HandbrakeSidewayStiffnessMultiplier_Rear = 0.3f;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG_MODE;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform wheelModel;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x30")]
		public Transform modelContainer;

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x38")]
		public WheelCollider wheelCollider;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x40")]
		public Transform axleConnectionPoint;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x48")]
		public Collider staticCollider;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x50")]
		public ParticleSystem DriftParticles;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x58")]
		[Header("Data")]
		[SerializeField]
		private WheelData _defaultData;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private WheelOverrideData _rainOverrideData;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public bool DriftParticlesEnabled;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x69")]
		[Header("Drift Audio")]
		public bool DriftAudioEnabled;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController DriftAudioSource;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x78")]
		private float defaultForwardStiffness;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x7C")]
		private float defaultSidewaysStiffness;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x90")]
		private LandVehicle vehicle;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 lastFixedUpdatePosition;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0xA8")]
		private WheelHit wheelData;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0xF0")]
		private WheelFrictionCurve forwardCurve;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x104")]
		private WheelFrictionCurve sidewaysCurve;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x118")]
		private VehicleSettings _settings;
	}
}
