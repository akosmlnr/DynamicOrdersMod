using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	[Serializable]
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x06001B33 RID: 6963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public TrashGeneratorData(string guid, string[] generatedItems)
		{
		}

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x30")]
		public string[] GeneratedItems;
	}
}
