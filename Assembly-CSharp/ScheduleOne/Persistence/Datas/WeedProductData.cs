using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	[Serializable]
	public class WeedProductData : ProductData
	{
		// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x603280", Offset = "0x602480", VA = "0x180603280")]
		public WeedProductData(string name, string id, EDrugType drugType, string[] properties, WeedAppearanceSettings appearanceSettings)
		{
		}

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x48")]
		public WeedAppearanceSettings AppearanceSettings;
	}
}
