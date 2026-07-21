using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x00013AA0 File Offset: 0x00011CA0
		// (set) Token: 0x060048B4 RID: 18612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5C")]
		public Vector3 Acceleration
		{
			[Token(Token = "0x60048B3")]
			[Address(RVA = "0x4D86C0", Offset = "0x4D78C0", VA = "0x1804D86C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60048B4")]
			[Address(RVA = "0x4D87C0", Offset = "0x4D79C0", VA = "0x1804D87C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x8F0D90", Offset = "0x8EFF90", VA = "0x1808F0D90")]
		private void Start()
		{
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x8F0AF0", Offset = "0x8EFCF0", VA = "0x1808F0AF0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x8F0F60", Offset = "0x8F0160", VA = "0x1808F0F60")]
		public AverageAcceleration()
		{
		}

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody Rb;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[FieldOffset(Offset = "0x38")]
		public float TimeWindow;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[FieldOffset(Offset = "0x40")]
		private Vector3[] accelerations;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[FieldOffset(Offset = "0x48")]
		private int currentIndex;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 prevVelocity;
	}
}
