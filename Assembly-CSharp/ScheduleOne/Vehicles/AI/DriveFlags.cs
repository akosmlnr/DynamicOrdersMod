using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	[Serializable]
	public class DriveFlags
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001062")]
		[Address(RVA = "0xB005D0", Offset = "0xAFF7D0", VA = "0x180B005D0")]
		public void ResetFlags()
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001063")]
		[Address(RVA = "0xB00610", Offset = "0xAFF810", VA = "0x180B00610")]
		public DriveFlags()
		{
		}

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0x10")]
		public bool OverrideSpeed;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x14")]
		public float OverriddenSpeed;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x18")]
		public float OverriddenReverseSpeed;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedLimitMultiplier;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x20")]
		public bool IgnoreTrafficLights;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x21")]
		public bool UseRoads;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x22")]
		public bool StuckDetection;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x24")]
		public DriveFlags.EObstacleMode ObstacleMode;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoBrakeAtDestination;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x29")]
		public bool TurnBasedSpeedReduction;

		// Token: 0x020002B7 RID: 695
		[Token(Token = "0x20002B7")]
		public enum EObstacleMode
		{
			// Token: 0x04000EC3 RID: 3779
			[Token(Token = "0x4000EC3")]
			Default,
			// Token: 0x04000EC4 RID: 3780
			[Token(Token = "0x4000EC4")]
			IgnoreAll,
			// Token: 0x04000EC5 RID: 3781
			[Token(Token = "0x4000EC5")]
			IgnoreOnlySquishy
		}
	}
}
