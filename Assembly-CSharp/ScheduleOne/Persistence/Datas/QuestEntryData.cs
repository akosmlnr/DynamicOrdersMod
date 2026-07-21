using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x605420", Offset = "0x604620", VA = "0x180605420")]
		public QuestEntryData(string name, EQuestState state)
		{
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x6034C0", Offset = "0x6026C0", VA = "0x1806034C0")]
		public QuestEntryData()
		{
		}

		// Token: 0x04001753 RID: 5971
		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x28")]
		public string Name;

		// Token: 0x04001754 RID: 5972
		[Token(Token = "0x4001754")]
		[FieldOffset(Offset = "0x30")]
		public EQuestState State;
	}
}
