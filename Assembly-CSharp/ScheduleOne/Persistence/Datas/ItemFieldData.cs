using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	[Serializable]
	public class ItemFieldData
	{
		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public ItemFieldData(string itemID)
		{
		}

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x10")]
		public string ItemID;
	}
}
