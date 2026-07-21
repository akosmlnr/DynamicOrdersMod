using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BB6 RID: 2998
	[Token(Token = "0x2000BB6")]
	[Serializable]
	public class WeatherConditions
	{
		// Token: 0x06005921 RID: 22817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x9BB630", Offset = "0x9BA830", VA = "0x1809BB630")]
		public void Set(WeatherConditions conditions)
		{
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005922")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public WeatherConditions()
		{
		}

		// Token: 0x04003B6F RID: 15215
		[Token(Token = "0x4003B6F")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float Sunny;

		// Token: 0x04003B70 RID: 15216
		[Token(Token = "0x4003B70")]
		[FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float Cloudy;

		// Token: 0x04003B71 RID: 15217
		[Token(Token = "0x4003B71")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float Rainy;

		// Token: 0x04003B72 RID: 15218
		[Token(Token = "0x4003B72")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float Stormy;

		// Token: 0x04003B73 RID: 15219
		[Token(Token = "0x4003B73")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float Snowy;

		// Token: 0x04003B74 RID: 15220
		[Token(Token = "0x4003B74")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float Foggy;

		// Token: 0x04003B75 RID: 15221
		[Token(Token = "0x4003B75")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float Windy;

		// Token: 0x04003B76 RID: 15222
		[Token(Token = "0x4003B76")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float Hail;

		// Token: 0x04003B77 RID: 15223
		[Token(Token = "0x4003B77")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float Sleet;
	}
}
