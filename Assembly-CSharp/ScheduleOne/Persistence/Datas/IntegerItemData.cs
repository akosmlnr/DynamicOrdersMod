using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x602C10", Offset = "0x601E10", VA = "0x180602C10")]
		public IntegerItemData(string iD, int quantity, int value)
		{
		}

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0x38")]
		public int Value;
	}
}
