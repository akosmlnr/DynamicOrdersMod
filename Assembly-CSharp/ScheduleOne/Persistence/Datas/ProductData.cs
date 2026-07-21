using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x616330", Offset = "0x615530", VA = "0x180616330")]
		public ProductData(string name, string id, EDrugType drugType, string[] properties)
		{
		}

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x28")]
		public string Name;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x30")]
		public string ID;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x38")]
		public EDrugType DrugType;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x40")]
		public string[] Properties;
	}
}
