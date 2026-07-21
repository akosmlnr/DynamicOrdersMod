using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	public class NPCCollectionData : SaveData
	{
		// Token: 0x06001AED RID: 6893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public NPCCollectionData(DynamicSaveData[] npcs)
		{
		}

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x28")]
		public DynamicSaveData[] NPCs;
	}
}
