using System;
using Il2CppDummyDll;

namespace ScheduleOne.Economy
{
	// Token: 0x020006BD RID: 1725
	[Token(Token = "0x20006BD")]
	public struct DealWindowInfo
	{
		// Token: 0x06002D85 RID: 11653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x53E580", Offset = "0x53D780", VA = "0x18053E580")]
		public DealWindowInfo(int startTime, int endTime)
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x7206C0", Offset = "0x71F8C0", VA = "0x1807206C0")]
		public static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			return default(DealWindowInfo);
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x7207B0", Offset = "0x71F9B0", VA = "0x1807207B0")]
		public static EDealWindow GetWindow(int time)
		{
			return EDealWindow.Morning;
		}

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		public const int WINDOW_DURATION_MINS = 360;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		public const int WINDOW_COUNT = 4;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x0")]
		public int StartTime;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x4")]
		public int EndTime;

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DealWindowInfo Morning;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DealWindowInfo Afternoon;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DealWindowInfo Night;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DealWindowInfo LateNight;
	}
}
