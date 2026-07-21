using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x200047E")]
	public class LawData : SaveData
	{
		// Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x606840", Offset = "0x605A40", VA = "0x180606840")]
		public LawData(float internalLawIntensity)
		{
		}

		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0x28")]
		public float InternalLawIntensity;
	}
}
