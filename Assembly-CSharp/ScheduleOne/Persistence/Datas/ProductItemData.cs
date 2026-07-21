using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000476 RID: 1142
	[Token(Token = "0x2000476")]
	[Serializable]
	public class ProductItemData : QualityItemData
	{
		// Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x602EC0", Offset = "0x6020C0", VA = "0x180602EC0")]
		public ProductItemData(string iD, int quantity, string quality, string packagingID)
		{
		}

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x40")]
		public string PackagingID;
	}
}
