using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2000888")]
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x060039CF RID: 14799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CF")]
		[Address(RVA = "0x80D050", Offset = "0x80C250", VA = "0x18080D050")]
		private void OnEnable()
		{
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D0")]
		[Address(RVA = "0x80D0D0", Offset = "0x80C2D0", VA = "0x18080D0D0")]
		private void Update()
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x80D000", Offset = "0x80C200", VA = "0x18080D000")]
		private void Execute()
		{
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D2")]
		[Address(RVA = "0x80D130", Offset = "0x80C330", VA = "0x18080D130")]
		public RandomIntervalEvent()
		{
		}

		// Token: 0x04002A8C RID: 10892
		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x20")]
		public float MinInterval;

		// Token: 0x04002A8D RID: 10893
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x24")]
		public float MaxInterval;

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x28")]
		public bool ExecuteOnEnable;

		// Token: 0x04002A8F RID: 10895
		[Token(Token = "0x4002A8F")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnInterval;

		// Token: 0x04002A90 RID: 10896
		[Token(Token = "0x4002A90")]
		[FieldOffset(Offset = "0x38")]
		private float nextInterval;
	}
}
