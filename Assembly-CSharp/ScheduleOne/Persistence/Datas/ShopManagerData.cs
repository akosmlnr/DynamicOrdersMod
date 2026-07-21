using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	[Serializable]
	public class ShopManagerData : SaveData
	{
		// Token: 0x06001B29 RID: 6953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public ShopManagerData(ShopData[] shops)
		{
		}

		// Token: 0x04001769 RID: 5993
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x28")]
		public ShopData[] Shops;
	}
}
