using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	[Serializable]
	public class ShopData : SaveData
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public ShopData(string shopCode, StringIntPair[] itemStockQuantities)
		{
		}

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x28")]
		public string ShopCode;

		// Token: 0x04001768 RID: 5992
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x30")]
		public StringIntPair[] ItemStockQuantities;
	}
}
