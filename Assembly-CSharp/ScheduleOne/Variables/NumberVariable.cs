using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	public class NumberVariable : Variable<float>
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0xB02690", Offset = "0xB01890", VA = "0x180B02690")]
		public NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value)
		{
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0xB02640", Offset = "0xB01840", VA = "0x180B02640", Slot = "8")]
		public override bool TryDeserialize(string valueString, out float value)
		{
			return default(bool);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0xB02460", Offset = "0xB01660", VA = "0x180B02460", Slot = "7")]
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}
	}
}
