using System;
using Il2CppDummyDll;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B94 RID: 2964
	[Token(Token = "0x2000B94")]
	[Serializable]
	public struct DayNightPhaseTimes
	{
		// Token: 0x04003A93 RID: 14995
		[Token(Token = "0x4003A93")]
		[FieldOffset(Offset = "0x0")]
		public int MinDawnHour;

		// Token: 0x04003A94 RID: 14996
		[Token(Token = "0x4003A94")]
		[FieldOffset(Offset = "0x4")]
		public int SunRiseHour;

		// Token: 0x04003A95 RID: 14997
		[Token(Token = "0x4003A95")]
		[FieldOffset(Offset = "0x8")]
		public int MaxDawnHour;

		// Token: 0x04003A96 RID: 14998
		[Token(Token = "0x4003A96")]
		[FieldOffset(Offset = "0xC")]
		public int MinDuskHour;

		// Token: 0x04003A97 RID: 14999
		[Token(Token = "0x4003A97")]
		[FieldOffset(Offset = "0x10")]
		public int SunSetHour;

		// Token: 0x04003A98 RID: 15000
		[Token(Token = "0x4003A98")]
		[FieldOffset(Offset = "0x14")]
		public int MaxDuskHour;
	}
}
