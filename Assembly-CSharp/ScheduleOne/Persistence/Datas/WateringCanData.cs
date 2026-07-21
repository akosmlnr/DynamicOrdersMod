using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06001ACA RID: 6858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x602660", Offset = "0x601860", VA = "0x180602660")]
		public WateringCanData(string iD, int quantity, float currentFillLevel)
		{
		}

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x38")]
		public float CurrentFillAmount;
	}
}
