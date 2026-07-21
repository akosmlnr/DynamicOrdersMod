using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x602570", Offset = "0x601770", VA = "0x180602570")]
		public BusinessData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, DynamicSaveData[] employees, DynamicSaveData[] objects, LaunderOperationData[] launderingOperations)
		{
		}

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[FieldOffset(Offset = "0x58")]
		public LaunderOperationData[] LaunderingOperations;
	}
}
