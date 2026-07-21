using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	[Serializable]
	public class CheckpointInstance
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E6")]
		public RoadCheckpoint activeCheckpoint
		{
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x66D450", Offset = "0x66C650", VA = "0x18066D450")]
		public void Evaluate()
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x66D1C0", Offset = "0x66C3C0", VA = "0x18066D1C0")]
		public void EnableCheckpoint()
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x66CFD0", Offset = "0x66C1D0", VA = "0x18066CFD0")]
		private bool DistanceRequirementsMet()
		{
			return default(bool);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x66D640", Offset = "0x66C840", VA = "0x18066D640")]
		private void MinPass()
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x66CDB0", Offset = "0x66BFB0", VA = "0x18066CDB0")]
		public void DisableCheckpoint()
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002173")]
		[Address(RVA = "0x66D6F0", Offset = "0x66C8F0", VA = "0x18066D6F0")]
		public CheckpointInstance()
		{
		}

		// Token: 0x04001B1D RID: 6941
		[Token(Token = "0x4001B1D")]
		public const float MIN_ACTIVATION_DISTANCE = 50f;

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x10")]
		public CheckpointManager.ECheckpointLocation Location;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x14")]
		public int Members;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x18")]
		public int StartTime;

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x1C")]
		public int EndTime;

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x24")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x28")]
		private RoadCheckpoint checkPoint;
	}
}
