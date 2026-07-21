using System;
using Il2CppDummyDll;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	[Serializable]
	public class SystemTrigger
	{
		// Token: 0x060014D9 RID: 5337 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x5ACFB0", Offset = "0x5AC1B0", VA = "0x1805ACFB0")]
		public bool Trigger()
		{
			return default(bool);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public SystemTrigger()
		{
		}

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x10")]
		public Conditions Conditions;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0x18")]
		[Header("True")]
		public VariableSetter[] onEvaluateTrueVariableSetters;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0x20")]
		public QuestStateSetter[] onEvaluateTrueQuestSetters;

		// Token: 0x040012D0 RID: 4816
		[Token(Token = "0x40012D0")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onEvaluateTrue;

		// Token: 0x040012D1 RID: 4817
		[Token(Token = "0x40012D1")]
		[FieldOffset(Offset = "0x30")]
		[Header("False")]
		public VariableSetter[] onEvaluateFalseVariableSetters;

		// Token: 0x040012D2 RID: 4818
		[Token(Token = "0x40012D2")]
		[FieldOffset(Offset = "0x38")]
		public QuestStateSetter[] onEvaluateFalseQuestSetters;

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onEvaluateFalse;
	}
}
