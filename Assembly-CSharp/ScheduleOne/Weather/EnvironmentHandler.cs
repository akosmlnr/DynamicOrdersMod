using System;
using Il2CppDummyDll;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B97 RID: 2967
	[Token(Token = "0x2000B97")]
	public static class EnvironmentHandler
	{
		// Token: 0x06005832 RID: 22578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005832")]
		[Address(RVA = "0x9965E0", Offset = "0x9957E0", VA = "0x1809965E0")]
		public static void RaiseWeatherChange(WeatherConditions newConditions)
		{
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005833")]
		[Address(RVA = "0x996640", Offset = "0x995840", VA = "0x180996640")]
		public static void RegisterWeatherEntity(IWeatherEntity entity)
		{
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x996940", Offset = "0x995B40", VA = "0x180996940")]
		public static void UnregisterWeatherEntity(IWeatherEntity entity)
		{
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005835")]
		[Address(RVA = "0x996860", Offset = "0x995A60", VA = "0x180996860")]
		public static void SubscribeToWeatherChange(WeatherChangeHandler handler)
		{
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005836")]
		[Address(RVA = "0x996B60", Offset = "0x995D60", VA = "0x180996B60")]
		public static void UnsubscribeFromWeatherChange(WeatherChangeHandler handler)
		{
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x9966A0", Offset = "0x9958A0", VA = "0x1809966A0")]
		public static void SubscribeToOnRegisterWeatherEntity(WeatherEntityHandler handler)
		{
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x9969A0", Offset = "0x995BA0", VA = "0x1809969A0")]
		public static void UnsubscribeFromOnRegisterWeatherEntity(WeatherEntityHandler handler)
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005839")]
		[Address(RVA = "0x996780", Offset = "0x995980", VA = "0x180996780")]
		public static void SubscribeToOnUnregisterWeatherEntity(WeatherEntityHandler handler)
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583A")]
		[Address(RVA = "0x996A80", Offset = "0x995C80", VA = "0x180996A80")]
		public static void UnsubscribeFromOnUnregisterWeatherEntity(WeatherEntityHandler handler)
		{
		}

		// Token: 0x04003A99 RID: 15001
		[Token(Token = "0x4003A99")]
		[FieldOffset(Offset = "0x0")]
		private static WeatherChangeHandler _onWeatherChange;

		// Token: 0x04003A9A RID: 15002
		[Token(Token = "0x4003A9A")]
		[FieldOffset(Offset = "0x8")]
		private static WeatherEntityHandler _onRegisterWeatherEntity;

		// Token: 0x04003A9B RID: 15003
		[Token(Token = "0x4003A9B")]
		[FieldOffset(Offset = "0x10")]
		private static WeatherEntityHandler _onUnregisterWeatherEntity;
	}
}
