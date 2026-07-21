using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000BF9 RID: 3065
	[Token(Token = "0x2000BF9")]
	[CreateAssetMenu(fileName = "SkateboardOverrideData", menuName = "ScriptableObjects/Skateboard/Skateboard Override Data")]
	public class SkateboardOverrideData : ScriptableObject
	{
		// Token: 0x06005A84 RID: 23172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public SkateboardOverrideData()
		{
		}

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x18")]
		public SkateboardSettings Settings;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x20")]
		public SkateboardOverrideData.OverrideCategory Categories;

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x24")]
		public SkateboardOverrideData.TurningOverrides TurningFlags;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x28")]
		public SkateboardOverrideData.GeneralOverrides GeneralFlags;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x2C")]
		public SkateboardOverrideData.FrictionOverrides FrictionFlags;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x30")]
		public SkateboardOverrideData.JumpOverrides JumpFlags;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0x34")]
		public SkateboardOverrideData.HoverOverrides HoverFlags;

		// Token: 0x04003CB6 RID: 15542
		[Token(Token = "0x4003CB6")]
		[FieldOffset(Offset = "0x38")]
		public SkateboardOverrideData.PushingOverrides PushingFlags;

		// Token: 0x04003CB7 RID: 15543
		[Token(Token = "0x4003CB7")]
		[FieldOffset(Offset = "0x3C")]
		public SkateboardOverrideData.AirMovementOverrides AirMovementFlags;

		// Token: 0x02000BFA RID: 3066
		[Token(Token = "0x2000BFA")]
		[Flags]
		public enum OverrideCategory
		{
			// Token: 0x04003CB9 RID: 15545
			[Token(Token = "0x4003CB9")]
			None = 0,
			// Token: 0x04003CBA RID: 15546
			[Token(Token = "0x4003CBA")]
			Turning = 1,
			// Token: 0x04003CBB RID: 15547
			[Token(Token = "0x4003CBB")]
			General = 2,
			// Token: 0x04003CBC RID: 15548
			[Token(Token = "0x4003CBC")]
			Friction = 4,
			// Token: 0x04003CBD RID: 15549
			[Token(Token = "0x4003CBD")]
			Jump = 8,
			// Token: 0x04003CBE RID: 15550
			[Token(Token = "0x4003CBE")]
			Hover = 16,
			// Token: 0x04003CBF RID: 15551
			[Token(Token = "0x4003CBF")]
			Pushing = 32,
			// Token: 0x04003CC0 RID: 15552
			[Token(Token = "0x4003CC0")]
			AirMovement = 64
		}

		// Token: 0x02000BFB RID: 3067
		[Token(Token = "0x2000BFB")]
		[Flags]
		public enum TurningOverrides
		{
			// Token: 0x04003CC2 RID: 15554
			[Token(Token = "0x4003CC2")]
			None = 0,
			// Token: 0x04003CC3 RID: 15555
			[Token(Token = "0x4003CC3")]
			TurnForce = 1,
			// Token: 0x04003CC4 RID: 15556
			[Token(Token = "0x4003CC4")]
			TurnChangeRate = 2,
			// Token: 0x04003CC5 RID: 15557
			[Token(Token = "0x4003CC5")]
			TurnReturnToRestRate = 4,
			// Token: 0x04003CC6 RID: 15558
			[Token(Token = "0x4003CC6")]
			TurnSpeedBoost = 8
		}

		// Token: 0x02000BFC RID: 3068
		[Token(Token = "0x2000BFC")]
		[Flags]
		public enum GeneralOverrides
		{
			// Token: 0x04003CC8 RID: 15560
			[Token(Token = "0x4003CC8")]
			None = 0,
			// Token: 0x04003CC9 RID: 15561
			[Token(Token = "0x4003CC9")]
			Gravity = 1,
			// Token: 0x04003CCA RID: 15562
			[Token(Token = "0x4003CCA")]
			BrakeForce = 2,
			// Token: 0x04003CCB RID: 15563
			[Token(Token = "0x4003CCB")]
			ReverseTopSpeed_Kmh = 4,
			// Token: 0x04003CCC RID: 15564
			[Token(Token = "0x4003CCC")]
			RotationClampForce = 8
		}

		// Token: 0x02000BFD RID: 3069
		[Token(Token = "0x2000BFD")]
		[Flags]
		public enum FrictionOverrides
		{
			// Token: 0x04003CCE RID: 15566
			[Token(Token = "0x4003CCE")]
			None = 0,
			// Token: 0x04003CCF RID: 15567
			[Token(Token = "0x4003CCF")]
			LongitudinalFrictionMultiplier = 1,
			// Token: 0x04003CD0 RID: 15568
			[Token(Token = "0x4003CD0")]
			LateralFrictionForceMultiplier = 2
		}

		// Token: 0x02000BFE RID: 3070
		[Token(Token = "0x2000BFE")]
		[Flags]
		public enum JumpOverrides
		{
			// Token: 0x04003CD2 RID: 15570
			[Token(Token = "0x4003CD2")]
			None = 0,
			// Token: 0x04003CD3 RID: 15571
			[Token(Token = "0x4003CD3")]
			JumpForce = 1,
			// Token: 0x04003CD4 RID: 15572
			[Token(Token = "0x4003CD4")]
			JumpDuration_Min = 2,
			// Token: 0x04003CD5 RID: 15573
			[Token(Token = "0x4003CD5")]
			JumpDuration_Max = 4,
			// Token: 0x04003CD6 RID: 15574
			[Token(Token = "0x4003CD6")]
			JumpForwardBoost = 8
		}

		// Token: 0x02000BFF RID: 3071
		[Token(Token = "0x2000BFF")]
		[Flags]
		public enum HoverOverrides
		{
			// Token: 0x04003CD8 RID: 15576
			[Token(Token = "0x4003CD8")]
			None = 0,
			// Token: 0x04003CD9 RID: 15577
			[Token(Token = "0x4003CD9")]
			HoverForce = 1,
			// Token: 0x04003CDA RID: 15578
			[Token(Token = "0x4003CDA")]
			HoverRayLength = 2,
			// Token: 0x04003CDB RID: 15579
			[Token(Token = "0x4003CDB")]
			HoverHeight = 4,
			// Token: 0x04003CDC RID: 15580
			[Token(Token = "0x4003CDC")]
			Hover_P = 8,
			// Token: 0x04003CDD RID: 15581
			[Token(Token = "0x4003CDD")]
			Hover_I = 16,
			// Token: 0x04003CDE RID: 15582
			[Token(Token = "0x4003CDE")]
			Hover_D = 32
		}

		// Token: 0x02000C00 RID: 3072
		[Token(Token = "0x2000C00")]
		[Flags]
		public enum PushingOverrides
		{
			// Token: 0x04003CE0 RID: 15584
			[Token(Token = "0x4003CE0")]
			None = 0,
			// Token: 0x04003CE1 RID: 15585
			[Token(Token = "0x4003CE1")]
			TopSpeed_Kmh = 1,
			// Token: 0x04003CE2 RID: 15586
			[Token(Token = "0x4003CE2")]
			PushForceMultiplier = 2,
			// Token: 0x04003CE3 RID: 15587
			[Token(Token = "0x4003CE3")]
			PushForceDuration = 4,
			// Token: 0x04003CE4 RID: 15588
			[Token(Token = "0x4003CE4")]
			PushDelay = 8
		}

		// Token: 0x02000C01 RID: 3073
		[Token(Token = "0x2000C01")]
		[Flags]
		public enum AirMovementOverrides
		{
			// Token: 0x04003CE6 RID: 15590
			[Token(Token = "0x4003CE6")]
			None = 0,
			// Token: 0x04003CE7 RID: 15591
			[Token(Token = "0x4003CE7")]
			AirMovementForce = 1,
			// Token: 0x04003CE8 RID: 15592
			[Token(Token = "0x4003CE8")]
			AirMovementJumpReductionDuration = 2
		}
	}
}
