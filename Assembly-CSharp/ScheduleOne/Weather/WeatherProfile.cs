using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BC2 RID: 3010
	[Token(Token = "0x2000BC2")]
	[CreateAssetMenu(fileName = "WeatherProfile", menuName = "ScriptableObjects/Weather/Weather Profile")]
	public class WeatherProfile : ScriptableObject
	{
		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CE8")]
		public string Id
		{
			[Token(Token = "0x600594E")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CE9")]
		public WeatherVolume WeatherVolumePrefab
		{
			[Token(Token = "0x600594F")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CEA")]
		public SkySettings SkySettings
		{
			[Token(Token = "0x6005950")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06005951 RID: 22865 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CEB")]
		public WeatherConditions Conditions
		{
			[Token(Token = "0x6005951")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public WeatherProfile()
		{
		}

		// Token: 0x04003B99 RID: 15257
		[Token(Token = "0x4003B99")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _id;

		// Token: 0x04003B9A RID: 15258
		[Token(Token = "0x4003B9A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkySettings _skySettings;

		// Token: 0x04003B9B RID: 15259
		[Token(Token = "0x4003B9B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WeatherVolume _weatherVolumePrefab;

		// Token: 0x04003B9C RID: 15260
		[Token(Token = "0x4003B9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WeatherConditions _conditions;
	}
}
