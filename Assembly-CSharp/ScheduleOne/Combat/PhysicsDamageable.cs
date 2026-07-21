using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E2C RID: 3628
	[Token(Token = "0x2000E2C")]
	public class PhysicsDamageable : MonoBehaviour, IDamageable
	{
		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06006804 RID: 26628 RVA: 0x00019530 File Offset: 0x00017730
		// (set) Token: 0x06006805 RID: 26629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EC3")]
		public Vector3 averageVelocity
		{
			[Token(Token = "0x6006804")]
			[Address(RVA = "0xAB2540", Offset = "0xAB1740", VA = "0x180AB2540")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6006805")]
			[Address(RVA = "0xAB2560", Offset = "0xAB1760", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006806")]
		[Address(RVA = "0xAB21D0", Offset = "0xAB13D0", VA = "0x180AB21D0")]
		public void OnValidate()
		{
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006807")]
		[Address(RVA = "0xAB2420", Offset = "0xAB1620", VA = "0x180AB2420", Slot = "7")]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006808")]
		[Address(RVA = "0xAB2260", Offset = "0xAB1460", VA = "0x180AB2260", Slot = "8")]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006809")]
		[Address(RVA = "0xAB2440", Offset = "0xAB1640", VA = "0x180AB2440")]
		public PhysicsDamageable()
		{
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600680A")]
		[Address(RVA = "0x668390", Offset = "0x667590", VA = "0x180668390", Slot = "4")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x04004989 RID: 18825
		[Token(Token = "0x4004989")]
		public const int VELOCITY_HISTORY_LENGTH = 4;

		// Token: 0x0400498A RID: 18826
		[Token(Token = "0x400498A")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rb;

		// Token: 0x0400498B RID: 18827
		[Token(Token = "0x400498B")]
		[FieldOffset(Offset = "0x28")]
		public float ForceMultiplier;

		// Token: 0x0400498C RID: 18828
		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0x30")]
		private List<int> impactHistory;

		// Token: 0x0400498D RID: 18829
		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x38")]
		public Action<Impact> onImpacted;

		// Token: 0x0400498F RID: 18831
		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x50")]
		private List<Vector3> velocityHistory;
	}
}
