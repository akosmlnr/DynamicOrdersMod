using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	[Serializable]
	public class QualityFieldData
	{
		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x447010", Offset = "0x446210", VA = "0x180447010")]
		public QualityFieldData(EQuality value)
		{
		}

		// Token: 0x040016AD RID: 5805
		[Token(Token = "0x40016AD")]
		[FieldOffset(Offset = "0x10")]
		public EQuality Value;
	}
}
