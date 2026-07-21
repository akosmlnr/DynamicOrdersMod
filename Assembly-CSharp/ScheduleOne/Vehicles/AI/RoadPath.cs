using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class RoadPath
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001097")]
		[Address(RVA = "0xB03F60", Offset = "0xB03160", VA = "0x180B03F60")]
		public RoadPath()
		{
		}

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x10")]
		public List<PathPoint> vectorPath;
	}
}
