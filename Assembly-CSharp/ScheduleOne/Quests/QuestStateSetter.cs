using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	[Serializable]
	public class QuestStateSetter
	{
		// Token: 0x060014D1 RID: 5329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x5A45C0", Offset = "0x5A37C0", VA = "0x1805A45C0")]
		public void Execute()
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public QuestStateSetter()
		{
		}

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x10")]
		public string QuestName;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x18")]
		public bool SetQuestState;

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x1C")]
		public QuestManager.EQuestAction QuestState;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x20")]
		public bool SetQuestEntryState;

		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		[FieldOffset(Offset = "0x24")]
		public int QuestEntryIndex;

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0x28")]
		public EQuestState QuestEntryState;
	}
}
