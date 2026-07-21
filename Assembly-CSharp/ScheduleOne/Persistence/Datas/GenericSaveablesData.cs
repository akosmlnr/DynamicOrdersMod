using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000464 RID: 1124
	[Token(Token = "0x2000464")]
	[Serializable]
	public class GenericSaveablesData : SaveData
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public GenericSaveablesData(GenericSaveData[] saveables)
		{
		}

		// Token: 0x04001663 RID: 5731
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x28")]
		public GenericSaveData[] Saveables;
	}
}
