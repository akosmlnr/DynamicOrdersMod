using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x06001AC2 RID: 6850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x605420", Offset = "0x604620", VA = "0x180605420")]
		public ItemData(string iD, int quantity)
		{
		}

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x28")]
		public string ID;

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x30")]
		public int Quantity;
	}
}
