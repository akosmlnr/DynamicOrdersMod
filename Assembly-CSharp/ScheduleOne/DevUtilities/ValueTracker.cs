using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	public class ValueTracker
	{
		// Token: 0x060049BE RID: 18878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x917660", Offset = "0x916860", VA = "0x180917660")]
		public ValueTracker(float HistoryDuration)
		{
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x916FE0", Offset = "0x9161E0", VA = "0x180916FE0")]
		public void Destroy()
		{
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x9175A0", Offset = "0x9167A0", VA = "0x1809175A0")]
		public void Update()
		{
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C1")]
		[Address(RVA = "0x9174A0", Offset = "0x9166A0", VA = "0x1809174A0")]
		public void SubmitValue(float value)
		{
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x60049C2")]
		[Address(RVA = "0x917400", Offset = "0x916600", VA = "0x180917400")]
		public float RecordedHistoryLength()
		{
			return 0f;
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x9172B0", Offset = "0x9164B0", VA = "0x1809172B0")]
		public float GetLowestValue()
		{
			return 0f;
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x917130", Offset = "0x916330", VA = "0x180917130")]
		public float GetAverageValue()
		{
			return 0f;
		}

		// Token: 0x0400341A RID: 13338
		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x10")]
		private float historyDuration;

		// Token: 0x0400341B RID: 13339
		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x18")]
		private List<ValueTracker.Value> valueHistory;

		// Token: 0x02000A1B RID: 2587
		[Token(Token = "0x2000A1B")]
		public class Value
		{
			// Token: 0x060049C5 RID: 18885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049C5")]
			[Address(RVA = "0x917810", Offset = "0x916A10", VA = "0x180917810")]
			public Value(float val, float time)
			{
			}

			// Token: 0x0400341C RID: 13340
			[Token(Token = "0x400341C")]
			[FieldOffset(Offset = "0x10")]
			public float val;

			// Token: 0x0400341D RID: 13341
			[Token(Token = "0x400341D")]
			[FieldOffset(Offset = "0x14")]
			public float time;
		}
	}
}
