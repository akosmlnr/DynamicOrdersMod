using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	[Serializable]
	public class NPCFieldData
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public NPCFieldData(string npcGuid)
		{
		}

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		[FieldOffset(Offset = "0x10")]
		public string NPCGuid;
	}
}
