using System;
using Il2CppDummyDll;
using ScheduleOne.Map;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	[Serializable]
	public class CartelRegionalActivityData
	{
		// Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x5E8B90", Offset = "0x5E7D90", VA = "0x1805E8B90")]
		public CartelRegionalActivityData(EMapRegion region, int currentActivityIndex, int hoursUntilNextActivity)
		{
		}

		// Token: 0x040015AD RID: 5549
		[Token(Token = "0x40015AD")]
		[FieldOffset(Offset = "0x10")]
		public EMapRegion Region;

		// Token: 0x040015AE RID: 5550
		[Token(Token = "0x40015AE")]
		[FieldOffset(Offset = "0x14")]
		public int CurrentActivityIndex;

		// Token: 0x040015AF RID: 5551
		[Token(Token = "0x40015AF")]
		[FieldOffset(Offset = "0x18")]
		public int HoursUntilNextActivity;
	}
}
