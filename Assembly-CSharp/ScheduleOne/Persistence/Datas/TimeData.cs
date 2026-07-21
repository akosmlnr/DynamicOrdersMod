using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x619E70", Offset = "0x619070", VA = "0x180619E70")]
		public TimeData(int timeOfDay, int elapsedDays, int playtime)
		{
		}

		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x28")]
		public int TimeOfDay;

		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0x2C")]
		public int ElapsedDays;

		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0x30")]
		public int Playtime;
	}
}
