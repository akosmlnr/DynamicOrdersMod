using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	[Serializable]
	public class CocaineProductData : ProductData
	{
		// Token: 0x06001B15 RID: 6933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x603280", Offset = "0x602480", VA = "0x180603280")]
		public CocaineProductData(string name, string id, EDrugType drugType, string[] properties, CocaineAppearanceSettings appearanceSettings)
		{
		}

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x48")]
		public CocaineAppearanceSettings AppearanceSettings;
	}
}
