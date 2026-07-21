using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	[Serializable]
	public class VariableSetter
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001131")]
		[Address(RVA = "0xB32950", Offset = "0xB31B50", VA = "0x180B32950")]
		public void Execute()
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public VariableSetter()
		{
		}

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x10")]
		public string VariableName;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x18")]
		public string NewValue;
	}
}
