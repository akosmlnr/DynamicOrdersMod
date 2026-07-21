using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public TrashData(TrashItemData[] trash, TrashGeneratorData[] generators)
		{
		}

		// Token: 0x04001779 RID: 6009
		[Token(Token = "0x4001779")]
		[FieldOffset(Offset = "0x28")]
		public TrashItemData[] Items;

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0x30")]
		public TrashGeneratorData[] Generators;
	}
}
