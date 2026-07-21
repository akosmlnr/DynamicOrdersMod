using System;
using Il2CppDummyDll;
using ScheduleOne.GameTime;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x61D6A0", Offset = "0x61C8A0", VA = "0x18061D6A0")]
		public WorldStorageEntityData(Guid guid, ItemSet contents, GameDateTime lastContentChangeTime)
		{
		}

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0x30")]
		public ItemSet Contents;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0x38")]
		public GameDateTime LastContentChangeTime;
	}
}
