using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06001ABE RID: 6846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x602660", Offset = "0x601860", VA = "0x180602660")]
		public CashData(string iD, int quantity, float cashBalance)
		{
		}

		// Token: 0x04001676 RID: 5750
		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0x38")]
		public float CashBalance;
	}
}
