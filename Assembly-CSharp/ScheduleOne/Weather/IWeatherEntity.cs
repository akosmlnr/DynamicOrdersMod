using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	public interface IWeatherEntity
	{
		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600588E RID: 22670
		// (set) Token: 0x0600588F RID: 22671
		[Token(Token = "0x17000CC8")]
		string WeatherVolume
		{
			[Token(Token = "0x600588E")]
			get;
			[Token(Token = "0x600588F")]
			set;
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06005890 RID: 22672
		[Token(Token = "0x17000CC9")]
		Transform Transform
		{
			[Token(Token = "0x6005890")]
			get;
		}

		// Token: 0x06005891 RID: 22673
		[Token(Token = "0x6005891")]
		void OnWeatherChange(WeatherConditions newConditions);

		// Token: 0x06005892 RID: 22674
		[Token(Token = "0x6005892")]
		void OnUpdateWeatherEntity();

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06005893 RID: 22675
		// (set) Token: 0x06005894 RID: 22676
		[Token(Token = "0x17000CCA")]
		bool IsUnderCover
		{
			[Token(Token = "0x6005893")]
			get;
			[Token(Token = "0x6005894")]
			set;
		}
	}
}
