using System;
using Il2CppDummyDll;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	[Serializable]
	public class NumericParameter
	{
		// Token: 0x0600570C RID: 22284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570C")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public NumericParameter()
		{
		}

		// Token: 0x04003A20 RID: 14880
		[Token(Token = "0x4003A20")]
		[FieldOffset(Offset = "0x10")]
		public string Variable;

		// Token: 0x04003A21 RID: 14881
		[Token(Token = "0x4003A21")]
		[FieldOffset(Offset = "0x18")]
		public float Value;
	}
}
