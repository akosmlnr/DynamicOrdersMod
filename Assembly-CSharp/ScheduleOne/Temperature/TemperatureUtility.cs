using System;
using Il2CppDummyDll;

namespace ScheduleOne.Temperature
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public static class TemperatureUtility
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x170003DD")]
		public static bool TemperatureSystemEnabled
		{
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0xB29F30", Offset = "0xB29130", VA = "0x180B29F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0xB29F10", Offset = "0xB29110", VA = "0x180B29F10")]
		public static float ToFahrenheit(float celsius)
		{
			return 0f;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0xB29BE0", Offset = "0xB28DE0", VA = "0x180B29BE0")]
		public static string FormatCelsiusTemperature(float celsius, int decimalPoints)
		{
			return null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0xB29C80", Offset = "0xB28E80", VA = "0x180B29C80")]
		public static string FormatFahrenheitTemperature(float fahrenheit, int decimalPoints)
		{
			return null;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0xB29D20", Offset = "0xB28F20", VA = "0x180B29D20")]
		public static string FormatTemperatureWithAppropriateUnit(float celsius, int decimalPoints = 1)
		{
			return null;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0xB29EE0", Offset = "0xB290E0", VA = "0x180B29EE0")]
		public static float NormalizeTemperature(float celsius)
		{
			return 0f;
		}
	}
}
