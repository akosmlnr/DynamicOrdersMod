using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	[Serializable]
	public class Conditions
	{
		// Token: 0x060010FB RID: 4347 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0xB00360", Offset = "0xAFF560", VA = "0x180B00360")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public Conditions()
		{
		}

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x10")]
		public Conditions.EEvaluationType EvaluationType;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x18")]
		public Condition[] ConditionList;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x20")]
		public QuestCondition[] QuestConditionList;

		// Token: 0x020002DD RID: 733
		[Token(Token = "0x20002DD")]
		public enum EEvaluationType
		{
			// Token: 0x04000FA5 RID: 4005
			[Token(Token = "0x4000FA5")]
			And,
			// Token: 0x04000FA6 RID: 4006
			[Token(Token = "0x4000FA6")]
			Or
		}
	}
}
