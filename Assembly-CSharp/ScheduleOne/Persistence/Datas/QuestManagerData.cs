using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	public class QuestManagerData : SaveData
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x6021D0", Offset = "0x6013D0", VA = "0x1806021D0")]
		public QuestManagerData(QuestData[] quests, ContractData[] contracts, DeaddropQuestData[] deaddropQuests)
		{
		}

		// Token: 0x04001755 RID: 5973
		[Token(Token = "0x4001755")]
		[FieldOffset(Offset = "0x28")]
		public QuestData[] Quests;

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		[FieldOffset(Offset = "0x30")]
		public ContractData[] Contracts;

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x38")]
		public DeaddropQuestData[] DeaddropQuests;
	}
}
