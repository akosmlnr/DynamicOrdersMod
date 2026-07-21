using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000890 RID: 2192
	[Token(Token = "0x2000890")]
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000912")]
		public Transform Target
		{
			[Token(Token = "0x60039E2")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039E3")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x17000913")]
		public virtual Vector3 Velocity
		{
			[Token(Token = "0x60039E4")]
			[Address(RVA = "0x80EEC0", Offset = "0x80E0C0", VA = "0x18080EEC0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x80EA10", Offset = "0x80DC10", VA = "0x18080EA10")]
		private void Start()
		{
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E6")]
		[Address(RVA = "0x80E570", Offset = "0x80D770", VA = "0x18080E570", Slot = "5")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E7")]
		[Address(RVA = "0x80E860", Offset = "0x80DA60", VA = "0x18080E860")]
		public void FlushBuffer()
		{
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E8")]
		[Address(RVA = "0x80EAC0", Offset = "0x80DCC0", VA = "0x18080EAC0")]
		public void ZeroOut(float duration)
		{
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E9")]
		[Address(RVA = "0x80E910", Offset = "0x80DB10", VA = "0x18080E910")]
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x80EBB0", Offset = "0x80DDB0", VA = "0x18080EBB0")]
		public SmoothedVelocityCalculator()
		{
		}

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		private const int sampleCount = 20;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float SampleLength;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x34")]
		public float MaxReasonableVelocity;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x38")]
		private RollingAverage<Vector3> velocityHistory;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastSamplePosition;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x4C")]
		private float timeOnLastSample;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x50")]
		private float timeSinceLastSample;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x54")]
		private bool zeroOut;

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x55")]
		private bool isTargetValid;
	}
}
