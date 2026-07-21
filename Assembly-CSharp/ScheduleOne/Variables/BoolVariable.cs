using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F6")]
		[Address(RVA = "0xB00120", Offset = "0xAFF320", VA = "0x180B00120")]
		public BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value)
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x60010F7")]
		[Address(RVA = "0xB00070", Offset = "0xAFF270", VA = "0x180B00070", Slot = "8")]
		public override bool TryDeserialize(string valueString, out bool value)
		{
			return default(bool);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0xAFFF30", Offset = "0xAFF130", VA = "0x180AFFF30", Slot = "7")]
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}
	}
}
