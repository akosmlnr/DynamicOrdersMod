using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x613550", Offset = "0x612750", VA = "0x180613550")]
		public MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum)
		{
		}

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		[FieldOffset(Offset = "0x28")]
		public float OnlineBalance;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		[FieldOffset(Offset = "0x2C")]
		public float Networth;

		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x30")]
		public float LifetimeEarnings;

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x34")]
		public float WeeklyDepositSum;
	}
}
