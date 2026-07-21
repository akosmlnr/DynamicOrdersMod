using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000BF8 RID: 3064
	[Token(Token = "0x2000BF8")]
	[Serializable]
	public class SkateboardSettings
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x00016FC8 File Offset: 0x000151C8
		[Token(Token = "0x17000D1C")]
		public float TopSpeed_Ms
		{
			[Token(Token = "0x6005A80")]
			[Address(RVA = "0x9B5630", Offset = "0x9B4830", VA = "0x1809B5630")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x9B50B0", Offset = "0x9B42B0", VA = "0x1809B50B0")]
		public SkateboardSettings Clone()
		{
			return null;
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x9B4890", Offset = "0x9B3A90", VA = "0x1809B4890")]
		public SkateboardSettings Blend(SkateboardSettings other, float blendFactor)
		{
			return null;
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x9B5540", Offset = "0x9B4740", VA = "0x1809B5540")]
		public SkateboardSettings()
		{
		}

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x10")]
		public float TurnForce;

		// Token: 0x04003C8C RID: 15500
		[Token(Token = "0x4003C8C")]
		[FieldOffset(Offset = "0x14")]
		public float TurnChangeRate;

		// Token: 0x04003C8D RID: 15501
		[Token(Token = "0x4003C8D")]
		[FieldOffset(Offset = "0x18")]
		public float TurnReturnToRestRate;

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x1C")]
		public float TurnSpeedBoost;

		// Token: 0x04003C8F RID: 15503
		[Token(Token = "0x4003C8F")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve TurnForceMap;

		// Token: 0x04003C90 RID: 15504
		[Token(Token = "0x4003C90")]
		[FieldOffset(Offset = "0x28")]
		public float Gravity;

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x2C")]
		public float BrakeForce;

		// Token: 0x04003C92 RID: 15506
		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x30")]
		public float ReverseTopSpeed_Kmh;

		// Token: 0x04003C93 RID: 15507
		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x34")]
		public float RotationClampForce;

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x38")]
		public bool FrictionEnabled;

		// Token: 0x04003C95 RID: 15509
		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve LongitudinalFrictionCurve;

		// Token: 0x04003C96 RID: 15510
		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x48")]
		public float LongitudinalFrictionMultiplier;

		// Token: 0x04003C97 RID: 15511
		[Token(Token = "0x4003C97")]
		[FieldOffset(Offset = "0x4C")]
		public float LateralFrictionForceMultiplier;

		// Token: 0x04003C98 RID: 15512
		[Token(Token = "0x4003C98")]
		[FieldOffset(Offset = "0x50")]
		public float JumpForce;

		// Token: 0x04003C99 RID: 15513
		[Token(Token = "0x4003C99")]
		[FieldOffset(Offset = "0x54")]
		public float JumpDuration_Min;

		// Token: 0x04003C9A RID: 15514
		[Token(Token = "0x4003C9A")]
		[FieldOffset(Offset = "0x58")]
		public float JumpDuration_Max;

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve FrontAxleJumpCurve;

		// Token: 0x04003C9C RID: 15516
		[Token(Token = "0x4003C9C")]
		[FieldOffset(Offset = "0x68")]
		public AnimationCurve RearAxleJumpCurve;

		// Token: 0x04003C9D RID: 15517
		[Token(Token = "0x4003C9D")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve JumpForwardForceCurve;

		// Token: 0x04003C9E RID: 15518
		[Token(Token = "0x4003C9E")]
		[FieldOffset(Offset = "0x78")]
		public float JumpForwardBoost;

		// Token: 0x04003C9F RID: 15519
		[Token(Token = "0x4003C9F")]
		[FieldOffset(Offset = "0x7C")]
		public float HoverForce;

		// Token: 0x04003CA0 RID: 15520
		[Token(Token = "0x4003CA0")]
		[FieldOffset(Offset = "0x80")]
		public float HoverRayLength;

		// Token: 0x04003CA1 RID: 15521
		[Token(Token = "0x4003CA1")]
		[FieldOffset(Offset = "0x84")]
		public float HoverHeight;

		// Token: 0x04003CA2 RID: 15522
		[Token(Token = "0x4003CA2")]
		[FieldOffset(Offset = "0x88")]
		public float Hover_P;

		// Token: 0x04003CA3 RID: 15523
		[Token(Token = "0x4003CA3")]
		[FieldOffset(Offset = "0x8C")]
		public float Hover_I;

		// Token: 0x04003CA4 RID: 15524
		[Token(Token = "0x4003CA4")]
		[FieldOffset(Offset = "0x90")]
		public float Hover_D;

		// Token: 0x04003CA5 RID: 15525
		[Token(Token = "0x4003CA5")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Top speed in m/s")]
		public float TopSpeed_Kmh;

		// Token: 0x04003CA6 RID: 15526
		[Token(Token = "0x4003CA6")]
		[FieldOffset(Offset = "0x98")]
		public float PushForceMultiplier;

		// Token: 0x04003CA7 RID: 15527
		[Token(Token = "0x4003CA7")]
		[FieldOffset(Offset = "0xA0")]
		public AnimationCurve PushForceMultiplierMap;

		// Token: 0x04003CA8 RID: 15528
		[Token(Token = "0x4003CA8")]
		[FieldOffset(Offset = "0xA8")]
		public float PushForceDuration;

		// Token: 0x04003CA9 RID: 15529
		[Token(Token = "0x4003CA9")]
		[FieldOffset(Offset = "0xAC")]
		public float PushDelay;

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[FieldOffset(Offset = "0xB0")]
		public AnimationCurve PushForceCurve;

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[FieldOffset(Offset = "0xB8")]
		public bool AirMovementEnabled;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0xBC")]
		public float AirMovementForce;

		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0xC0")]
		public float AirMovementJumpReductionDuration;

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationCurve AirMovementJumpReductionCurve;
	}
}
