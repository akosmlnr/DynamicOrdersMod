using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	[Serializable]
	public class MethProductData : ProductData
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x603280", Offset = "0x602480", VA = "0x180603280")]
		public MethProductData(string name, string id, EDrugType drugType, string[] properties, MethAppearanceSettings appearanceSettings)
		{
		}

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x48")]
		public MethAppearanceSettings AppearanceSettings;
	}
}
