using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x616B60", Offset = "0x615D60", VA = "0x180616B60")]
		public QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, QuestEntryData[] entries)
		{
		}

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x0400174C RID: 5964
		[Token(Token = "0x400174C")]
		[FieldOffset(Offset = "0x30")]
		public EQuestState State;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x34")]
		public bool IsTracked;

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x38")]
		public string Title;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x40")]
		public string Description;

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x48")]
		public bool Expires;

		// Token: 0x04001751 RID: 5969
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x50")]
		public GameDateTimeData ExpiryDate;

		// Token: 0x04001752 RID: 5970
		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0x58")]
		public QuestEntryData[] Entries;
	}
}
