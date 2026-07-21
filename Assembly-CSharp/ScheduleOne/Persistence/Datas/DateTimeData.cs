using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	[Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x603520", Offset = "0x602720", VA = "0x180603520")]
		public DateTimeData(DateTime date)
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x6034D0", Offset = "0x6026D0", VA = "0x1806034D0")]
		public DateTime GetDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x0400164D RID: 5709
		[Token(Token = "0x400164D")]
		[FieldOffset(Offset = "0x28")]
		public int Year;

		// Token: 0x0400164E RID: 5710
		[Token(Token = "0x400164E")]
		[FieldOffset(Offset = "0x2C")]
		public int Month;

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x30")]
		public int Day;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x34")]
		public int Hour;

		// Token: 0x04001651 RID: 5713
		[Token(Token = "0x4001651")]
		[FieldOffset(Offset = "0x38")]
		public int Minute;

		// Token: 0x04001652 RID: 5714
		[Token(Token = "0x4001652")]
		[FieldOffset(Offset = "0x3C")]
		public int Second;
	}
}
