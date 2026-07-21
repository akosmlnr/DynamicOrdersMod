using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Skating;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x000107E8 File Offset: 0x0000E9E8
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DA")]
		public bool IsCrouched
		{
			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037DC")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x170008DB")]
		public bool IsSeated
		{
			[Token(Token = "0x60037DD")]
			[Address(RVA = "0x7E4C10", Offset = "0x7E3E10", VA = "0x1807E4C10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DC")]
		public float TimeSinceSitEnd
		{
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60037DF")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DD")]
		public AvatarSeat CurrentSeat
		{
			[Token(Token = "0x60037E0")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x00010830 File Offset: 0x0000EA30
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DE")]
		public bool StandUpAnimationPlaying
		{
			[Token(Token = "0x60037E2")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037E3")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x00010848 File Offset: 0x0000EA48
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DF")]
		public bool IsAvatarCulled
		{
			[Token(Token = "0x60037E4")]
			[Address(RVA = "0x4CBF70", Offset = "0x4CB170", VA = "0x1804CBF70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037E5")]
			[Address(RVA = "0x509170", Offset = "0x508370", VA = "0x180509170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x7E1CD0", Offset = "0x7E0ED0", VA = "0x1807E1CD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x7E4280", Offset = "0x7E3480", VA = "0x1807E4280")]
		private void Start()
		{
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x7E4960", Offset = "0x7E3B60", VA = "0x1807E4960")]
		private void Update()
		{
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x7E24A0", Offset = "0x7E16A0", VA = "0x1807E24A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x7E4510", Offset = "0x7E3710", VA = "0x1807E4510")]
		private void UpdateAnimationActive()
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x7E3220", Offset = "0x7E2420", VA = "0x1807E3220")]
		public void SetDirection(float dir)
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x7E38A0", Offset = "0x7E2AA0", VA = "0x1807E38A0")]
		public void SetStrafe(float strafe)
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x7E3920", Offset = "0x7E2B20", VA = "0x1807E3920")]
		public void SetTimeAirborne(float airbone)
		{
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public void SetCrouched(bool crouched)
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x7E32A0", Offset = "0x7E24A0", VA = "0x1807E32A0")]
		public void SetGrounded(bool grounded)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x7E2430", Offset = "0x7E1630", VA = "0x1807E2430")]
		public void Jump()
		{
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x7E2FF0", Offset = "0x7E21F0", VA = "0x1807E2FF0")]
		public void SetAnimationEnabled(bool enabled)
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x7E2EB0", Offset = "0x7E20B0", VA = "0x1807E2EB0")]
		public void ResetAnimatorState()
		{
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x7E2130", Offset = "0x7E1330", VA = "0x1807E2130")]
		public void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x7E24B0", Offset = "0x7E16B0", VA = "0x1807E24B0")]
		public void PlayStandUpAnimation()
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x7E2B00", Offset = "0x7E1D00", VA = "0x1807E2B00")]
		protected void RagdollChange(bool wasRagdolled, bool ragdoll, bool playStandUpAnim)
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x7E16A0", Offset = "0x7E08A0", VA = "0x1807E16A0")]
		private void AlignPositionToHips()
		{
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x7E3A70", Offset = "0x7E2C70", VA = "0x1807E3A70")]
		private bool ShouldGetUpFromBack()
		{
			return default(bool);
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x7E2960", Offset = "0x7E1B60", VA = "0x1807E2960")]
		private void PopulateBoneTransforms(BoneTransform[] boneTransforms)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x7E2700", Offset = "0x7E1900", VA = "0x1807E2700")]
		private void PopulateAnimationStartBoneTransforms(string clipName, BoneTransform[] boneTransforms)
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x7E1BA0", Offset = "0x7E0DA0", VA = "0x1807E1BA0")]
		private void ApplyBoneTransforms(BoneTransform[] boneTransforms)
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x7E39A0", Offset = "0x7E2BA0", VA = "0x1807E39A0")]
		public void SetTrigger(string trigger)
		{
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x7E2F80", Offset = "0x7E2180", VA = "0x1807E2F80")]
		public void ResetTrigger(string trigger)
		{
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0")]
		public void SetBool(string id, bool value)
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x7E3320", Offset = "0x7E2520", VA = "0x1807E3320")]
		public void SetSeat(AvatarSeat seat)
		{
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x7E3D00", Offset = "0x7E2F00", VA = "0x1807E3D00")]
		public void SkateboardMounted(Skateboard board)
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x7E3B20", Offset = "0x7E2D20", VA = "0x1807E3B20")]
		public void SkateboardDismounted()
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x7E4240", Offset = "0x7E3440", VA = "0x1807E4240")]
		private void SkateboardPush()
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x7E4BF0", Offset = "0x7E3DF0", VA = "0x1807E4BF0")]
		public AvatarAnimation()
		{
		}

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		public const bool ImpostorsEnabled = true;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		public const float AnimationRangeSqr = 2500f;

		// Token: 0x040028C6 RID: 10438
		[Token(Token = "0x40028C6")]
		public const float FrustrumCullMinDist = 225f;

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		public const float RunningAnimationSpeed = 8f;

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		public const float MaxBoneOffset = 0.01f;

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		public const float MaxBoneOffsetSqr = 0.0001f;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x0")]
		public static Vector3 SITTING_OFFSET;

		// Token: 0x040028CB RID: 10443
		[Token(Token = "0x40028CB")]
		public const float SEAT_TIME = 0.5f;

		// Token: 0x040028CC RID: 10444
		[Token(Token = "0x40028CC")]
		private const string StandUpFromBackClipName = "Stand up from back";

		// Token: 0x040028CD RID: 10445
		[Token(Token = "0x40028CD")]
		private const string StandUpFromFrontClipName = "Stand up from front";

		// Token: 0x040028D3 RID: 10451
		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x32")]
		public bool DEBUG_MODE;

		// Token: 0x040028D4 RID: 10452
		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Animator animator;

		// Token: 0x040028D5 RID: 10453
		[Token(Token = "0x40028D5")]
		[FieldOffset(Offset = "0x40")]
		public Transform HipBone;

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x48")]
		public Transform[] Bones;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x50")]
		protected Avatar avatar;

		// Token: 0x040028D8 RID: 10456
		[Token(Token = "0x40028D8")]
		[FieldOffset(Offset = "0x58")]
		public Transform LeftHandContainer;

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		[FieldOffset(Offset = "0x60")]
		public Transform RightHandContainer;

		// Token: 0x040028DA RID: 10458
		[Token(Token = "0x40028DA")]
		[FieldOffset(Offset = "0x68")]
		public Transform RightHandAlignmentPoint;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x70")]
		public Transform LeftHandAlignmentPoint;

		// Token: 0x040028DC RID: 10460
		[Token(Token = "0x40028DC")]
		[FieldOffset(Offset = "0x78")]
		public AvatarIKController IKController;

		// Token: 0x040028DD RID: 10461
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x80")]
		public AvatarFootstepDetector FootstepDetector;

		// Token: 0x040028DE RID: 10462
		[Token(Token = "0x40028DE")]
		[FieldOffset(Offset = "0x88")]
		[Header("Settings")]
		public LayerMask GroundingMask;

		// Token: 0x040028DF RID: 10463
		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x8C")]
		public bool AllowCulling;

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent onStandupStart;

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onStandupDone;

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onHeavyFlinch;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0xA8")]
		private BoneTransform[] standUpFromBackBoneTransforms;

		// Token: 0x040028E4 RID: 10468
		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0xB0")]
		private BoneTransform[] standUpFromFrontBoneTransforms;

		// Token: 0x040028E5 RID: 10469
		[Token(Token = "0x40028E5")]
		[FieldOffset(Offset = "0xB8")]
		private BoneTransform[] ragdollBoneTransforms;

		// Token: 0x040028E6 RID: 10470
		[Token(Token = "0x40028E6")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine standUpRoutine;

		// Token: 0x040028E7 RID: 10471
		[Token(Token = "0x40028E7")]
		[FieldOffset(Offset = "0xC8")]
		private Coroutine seatRoutine;

		// Token: 0x040028E8 RID: 10472
		[Token(Token = "0x40028E8")]
		[FieldOffset(Offset = "0xD0")]
		private Skateboard activeSkateboard;

		// Token: 0x040028E9 RID: 10473
		[Token(Token = "0x40028E9")]
		[FieldOffset(Offset = "0xD8")]
		private bool animationEnabled;

		// Token: 0x040028EA RID: 10474
		[Token(Token = "0x40028EA")]
		[FieldOffset(Offset = "0xE0")]
		private BoneTransform[] _lastFrameBoneTransforms;

		// Token: 0x02000821 RID: 2081
		[Token(Token = "0x2000821")]
		public enum EFlinchType
		{
			// Token: 0x040028EC RID: 10476
			[Token(Token = "0x40028EC")]
			Light,
			// Token: 0x040028ED RID: 10477
			[Token(Token = "0x40028ED")]
			Heavy
		}

		// Token: 0x02000822 RID: 2082
		[Token(Token = "0x2000822")]
		public enum EFlinchDirection
		{
			// Token: 0x040028EF RID: 10479
			[Token(Token = "0x40028EF")]
			Forward,
			// Token: 0x040028F0 RID: 10480
			[Token(Token = "0x40028F0")]
			Backward,
			// Token: 0x040028F1 RID: 10481
			[Token(Token = "0x40028F1")]
			Left,
			// Token: 0x040028F2 RID: 10482
			[Token(Token = "0x40028F2")]
			Right
		}
	}
}
