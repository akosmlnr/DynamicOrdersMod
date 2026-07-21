using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	[Serializable]
	public class QualityItemData : ItemData
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x604180", Offset = "0x603380", VA = "0x180604180")]
		public QualityItemData(string iD, int quantity, string quality)
		{
		}

		// Token: 0x0400167C RID: 5756
		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x38")]
		public string Quality;
	}
}
