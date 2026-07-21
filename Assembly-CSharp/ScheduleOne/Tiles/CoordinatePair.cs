using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	public class CoordinatePair
	{
		// Token: 0x06001262 RID: 4706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
		public CoordinatePair(Coordinate _c1, Coordinate _c2)
		{
		}

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x10")]
		public Coordinate coord1;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x18")]
		public Coordinate coord2;
	}
}
