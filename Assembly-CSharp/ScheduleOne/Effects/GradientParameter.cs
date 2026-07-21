using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	[Serializable]
	public class GradientParameter
	{
		// Token: 0x0600570D RID: 22285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570D")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public GradientParameter()
		{
		}

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x10")]
		public string Variable;

		// Token: 0x04003A23 RID: 14883
		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0x18")]
		public Gradient Value;
	}
}
