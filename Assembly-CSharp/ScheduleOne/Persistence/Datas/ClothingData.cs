using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x06001ABF RID: 6847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x602C10", Offset = "0x601E10", VA = "0x180602C10")]
		public ClothingData(string iD, int quantity, EClothingColor color)
		{
		}

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0x38")]
		public EClothingColor Color;
	}
}
