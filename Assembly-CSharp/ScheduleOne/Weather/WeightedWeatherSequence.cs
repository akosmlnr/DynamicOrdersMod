using System;
using Il2CppDummyDll;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	[Serializable]
	public class WeightedWeatherSequence
	{
		// Token: 0x0600595A RID: 22874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600595A")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public WeightedWeatherSequence()
		{
		}

		// Token: 0x04003BA9 RID: 15273
		[Token(Token = "0x4003BA9")]
		[FieldOffset(Offset = "0x10")]
		public WeatherSequence Sequence;

		// Token: 0x04003BAA RID: 15274
		[Token(Token = "0x4003BAA")]
		[FieldOffset(Offset = "0x18")]
		public float Weight;
	}
}
