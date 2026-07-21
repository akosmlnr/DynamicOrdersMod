using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000CC6")]
	public static class UnitsUtility
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0xA1D320", Offset = "0xA1C520", VA = "0x180A1D320")]
		public static string FormatShortDistance(float meters, UnitsUtility.ERoundingType roundingType = UnitsUtility.ERoundingType.Nearest, int decimalPoints = 0)
		{
			return null;
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0xA1D450", Offset = "0xA1C650", VA = "0x180A1D450")]
		public static string FormatSpeed(float metersPerSecond, UnitsUtility.ERoundingType roundingType = UnitsUtility.ERoundingType.Nearest, int decimalPoints = 1)
		{
			return null;
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0xA1D610", Offset = "0xA1C810", VA = "0x180A1D610")]
		private static float RoundValue(float value, UnitsUtility.ERoundingType roundingType, int decimalPoints)
		{
			return 0f;
		}

		// Token: 0x02000CC7 RID: 3271
		[Token(Token = "0x2000CC7")]
		public enum ERoundingType
		{
			// Token: 0x040041B7 RID: 16823
			[Token(Token = "0x40041B7")]
			None,
			// Token: 0x040041B8 RID: 16824
			[Token(Token = "0x40041B8")]
			Nearest,
			// Token: 0x040041B9 RID: 16825
			[Token(Token = "0x40041B9")]
			Up,
			// Token: 0x040041BA RID: 16826
			[Token(Token = "0x40041BA")]
			Down
		}
	}
}
