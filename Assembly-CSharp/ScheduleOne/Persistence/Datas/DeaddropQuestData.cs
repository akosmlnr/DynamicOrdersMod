using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x6035D0", Offset = "0x6027D0", VA = "0x1806035D0")]
		public DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string deaddropGUID)
		{
		}

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		[FieldOffset(Offset = "0x60")]
		public string DeaddropGUID;
	}
}
