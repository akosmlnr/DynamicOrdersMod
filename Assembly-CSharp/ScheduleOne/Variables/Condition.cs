using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	[Serializable]
	public class Condition
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0xB001B0", Offset = "0xAFF3B0", VA = "0x180B001B0")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0xB002E0", Offset = "0xAFF4E0", VA = "0x180B002E0")]
		public Condition()
		{
		}

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x10")]
		public string VariableName;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x18")]
		public Condition.EConditionType Operator;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x20")]
		public string Value;

		// Token: 0x020002DB RID: 731
		[Token(Token = "0x20002DB")]
		public enum EConditionType
		{
			// Token: 0x04000F9B RID: 3995
			[Token(Token = "0x4000F9B")]
			GreaterThan,
			// Token: 0x04000F9C RID: 3996
			[Token(Token = "0x4000F9C")]
			LessThan,
			// Token: 0x04000F9D RID: 3997
			[Token(Token = "0x4000F9D")]
			EqualTo,
			// Token: 0x04000F9E RID: 3998
			[Token(Token = "0x4000F9E")]
			NotEqualTo,
			// Token: 0x04000F9F RID: 3999
			[Token(Token = "0x4000F9F")]
			GreaterThanOrEqualTo,
			// Token: 0x04000FA0 RID: 4000
			[Token(Token = "0x4000FA0")]
			LessThanOrEqualTo
		}
	}
}
