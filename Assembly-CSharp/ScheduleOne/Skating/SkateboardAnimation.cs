using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x170003F0")]
		public float CurrentCrouchShift
		{
			[Token(Token = "0x6001327")]
			[Address(RVA = "0x58ECA0", Offset = "0x58DEA0", VA = "0x18058ECA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x58D2A0", Offset = "0x58C4A0", VA = "0x18058D2A0")]
		private void Awake()
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x58EBC0", Offset = "0x58DDC0", VA = "0x18058EBC0")]
		private void Update()
		{
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x58DA50", Offset = "0x58CC50", VA = "0x18058DA50")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x58E4D0", Offset = "0x58D6D0", VA = "0x18058E4D0")]
		private void UpdateIKBlend()
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x58E0B0", Offset = "0x58D2B0", VA = "0x18058E0B0")]
		private void UpdateBodyAlignment()
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x58DB30", Offset = "0x58CD30", VA = "0x18058DB30")]
		private void UpdateArmLift()
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x58E8B0", Offset = "0x58DAB0", VA = "0x18058E8B0")]
		private void UpdatePelvisRotation()
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x58DB20", Offset = "0x58CD20", VA = "0x18058DB20")]
		public void SetArmLift(float lift)
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x58DA80", Offset = "0x58CC80", VA = "0x18058DA80")]
		private void OnPushStart()
		{
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x58EBD0", Offset = "0x58DDD0", VA = "0x18058EBD0")]
		public SkateboardAnimation()
		{
		}

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float JumpCrouchAmount;

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x24")]
		public float CrouchSpeed;

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x28")]
		public float ArmLiftRate;

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x2C")]
		public float PelvisMaxRotation;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x30")]
		public float HandsMaxRotation;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x34")]
		public float PelvisOffsetBlend;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x38")]
		public float VerticalMomentumMultiplier;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x3C")]
		public float VerticalMomentumOffsetClamp;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x40")]
		public float MomentumMoveSpeed;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x44")]
		public float IKBlendChangeRate;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x48")]
		public float PushAnimationDuration;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x4C")]
		public float PushAnimationSpeed;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x50")]
		public AnimationClip PushAnim;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x58")]
		[Header("References")]
		public SkateboardAnimation.AlignmentSet PelvisContainerAlignment;

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x60")]
		public SkateboardAnimation.AlignmentSet PelvisAlignment;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x68")]
		public SkateboardAnimation.AlignmentSet SpineContainerAlignment;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x70")]
		public SkateboardAnimation.AlignmentSet SpineAlignment;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x78")]
		public Transform SpineAlignment_Hunched;

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x80")]
		public SkateboardAnimation.AlignmentSet LeftFootAlignment;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x88")]
		public SkateboardAnimation.AlignmentSet RightFootAlignment;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x90")]
		public SkateboardAnimation.AlignmentSet LeftLegBendTarget;

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x98")]
		public SkateboardAnimation.AlignmentSet RightLegBendTarget;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0xA0")]
		public SkateboardAnimation.AlignmentSet LeftHandAlignment;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0xA8")]
		public SkateboardAnimation.AlignmentSet RightHandAlignment;

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0xB0")]
		public Transform AvatarFaceTarget;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0xB8")]
		public Transform HandContainer;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0xC0")]
		public Animation IKAnimation;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Arm Lift")]
		public SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0xD0")]
		public SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0xD8")]
		public SkateboardAnimation.AlignmentSet RightHandLoweredAlignment;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0xE0")]
		public SkateboardAnimation.AlignmentSet RightHandRaisedAlignment;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0xE8")]
		private Skateboard board;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0xF0")]
		private float currentCrouchShift;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0xF4")]
		private float targetArmLift;

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0xF8")]
		private float currentArmLift;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0xFC")]
		private Quaternion pelvisDefaultRotation;

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x10C")]
		private Vector3 pelvisDefaultPosition;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 spineDefaultPosition;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x124")]
		private float currentMomentumOffset;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x128")]
		private float ikBlend;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x130")]
		private List<SkateboardAnimation.AlignmentSet> alignmentSets;

		// Token: 0x02000320 RID: 800
		[Token(Token = "0x2000320")]
		[Serializable]
		public class AlignmentSet
		{
			// Token: 0x06001333 RID: 4915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001333")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public AlignmentSet()
			{
			}

			// Token: 0x040011AD RID: 4525
			[Token(Token = "0x40011AD")]
			[FieldOffset(Offset = "0x10")]
			public Transform Transform;

			// Token: 0x040011AE RID: 4526
			[Token(Token = "0x40011AE")]
			[FieldOffset(Offset = "0x18")]
			public Transform Default;

			// Token: 0x040011AF RID: 4527
			[Token(Token = "0x40011AF")]
			[FieldOffset(Offset = "0x20")]
			public Transform Animated;
		}
	}
}
