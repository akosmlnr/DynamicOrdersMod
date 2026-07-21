using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	public class NPCData : SaveData
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public NPCData(string id)
		{
		}

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x28")]
		public string ID;
	}
}
