using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public class NavigationSettings
	{
		// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001069")]
		[Address(RVA = "0xB00CA0", Offset = "0xAFFEA0", VA = "0x180B00CA0")]
		public NavigationSettings()
		{
		}

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x10")]
		public bool endAtRoad;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x11")]
		public bool ensureProximityToGraph;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x12")]
		public bool teleportToGraphIfCalculationFails;
	}
}
