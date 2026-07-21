using System;
using Il2CppDummyDll;
using ScheduleOne.GameTime;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000463 RID: 1123
	[Token(Token = "0x2000463")]
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x604240", Offset = "0x603440", VA = "0x180604240")]
		public GameDateTimeData(int _elapsedDays, int _time)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x604280", Offset = "0x603480", VA = "0x180604280")]
		public GameDateTimeData(GameDateTime gameDateTime)
		{
		}

		// Token: 0x04001661 RID: 5729
		[Token(Token = "0x4001661")]
		[FieldOffset(Offset = "0x28")]
		public int ElapsedDays;

		// Token: 0x04001662 RID: 5730
		[Token(Token = "0x4001662")]
		[FieldOffset(Offset = "0x2C")]
		public int Time;
	}
}
