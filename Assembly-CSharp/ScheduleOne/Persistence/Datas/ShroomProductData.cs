using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	[Serializable]
	public class ShroomProductData : ProductData
	{
		// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x603280", Offset = "0x602480", VA = "0x180603280")]
		public ShroomProductData(string name, string id, EDrugType drugType, string[] properties, ShroomAppearanceSettings appearanceSettings)
		{
		}

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x48")]
		public ShroomAppearanceSettings AppearanceSettings;
	}
}
