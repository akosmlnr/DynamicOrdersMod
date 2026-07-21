using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[Serializable]
	public class VariableCollectionData : SaveData
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public VariableCollectionData(VariableData[] variables)
		{
		}

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x28")]
		public VariableData[] Variables;
	}
}
