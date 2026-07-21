using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	[Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x06001AFA RID: 6906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x6024C0", Offset = "0x6016C0", VA = "0x1806024C0")]
		public BuildableItemData(Guid guid, ItemInstance item, int loadOrder)
		{
		}

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x30")]
		public string ItemString;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0x38")]
		public int LoadOrder;
	}
}
