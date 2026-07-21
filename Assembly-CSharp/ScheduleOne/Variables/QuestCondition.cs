using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Variables
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	[Serializable]
	public class QuestCondition
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x6001100")]
		[Address(RVA = "0xB03D20", Offset = "0xB02F20", VA = "0x180B03D20")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001101")]
		[Address(RVA = "0xB03EF0", Offset = "0xB030F0", VA = "0x180B03EF0")]
		public QuestCondition()
		{
		}

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x10")]
		public bool CheckQuestState;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x18")]
		public string QuestName;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x20")]
		public EQuestState QuestState;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x24")]
		public bool CheckQuestEntryState;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x28")]
		public int QuestEntryIndex;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x2C")]
		public EQuestState QuestEntryState;
	}
}
