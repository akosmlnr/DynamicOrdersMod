using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	public class FinalizeLabOven : Task
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		public LabOven Oven
		{
			[Token(Token = "0x60016F9")]
			[Address(RVA = "0x4B47C0", Offset = "0x4B39C0", VA = "0x1804B47C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016FA")]
			[Address(RVA = "0x4B5340", Offset = "0x4B4540", VA = "0x1804B5340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x5B6E80", Offset = "0x5B6080", VA = "0x1805B6E80")]
		public FinalizeLabOven(LabOven oven)
		{
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x5B6E40", Offset = "0x5B6040", VA = "0x1805B6E40", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x5B69E0", Offset = "0x5B5BE0", VA = "0x1805B69E0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x5B6970", Offset = "0x5B5B70", VA = "0x1805B6970")]
		private IEnumerator StartSequence()
		{
			return null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x5B6220", Offset = "0x5B5420", VA = "0x1805B6220")]
		public void Collision(Collision col)
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x5B6680", Offset = "0x5B5880", VA = "0x1805B6680")]
		private void Shatter()
		{
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001701")]
		[Address(RVA = "0x5B6DD0", Offset = "0x5B5FD0", VA = "0x1805B6DD0")]
		[CompilerGenerated]
		private IEnumerator <Shatter>g__Routine|17_0()
		{
			return null;
		}

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1f;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0xA0")]
		public float SMASH_VELOCITY_THRESHOLD;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0xA4")]
		public float SMASH_COOLDOWN;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		public const int REQUIRED_IMPACTS = 3;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine startSequence;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0xB8")]
		private LabOvenHammer hammer;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0xC0")]
		private int impactCount;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0xC4")]
		private float timeSinceLastImpact;
	}
}
