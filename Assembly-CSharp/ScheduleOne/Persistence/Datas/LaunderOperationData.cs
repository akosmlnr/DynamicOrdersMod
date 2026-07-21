using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06001ACC RID: 6860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x606800", Offset = "0x605A00", VA = "0x180606800")]
		public LaunderOperationData(float amount, int minutesSinceStarted)
		{
		}

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x28")]
		public float Amount;

		// Token: 0x04001683 RID: 5763
		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0x2C")]
		public int MinutesSinceStarted;
	}
}
