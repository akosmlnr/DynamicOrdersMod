using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	[Serializable]
	public struct CoordinateTilePair
	{
		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x8")]
		public Tile tile;
	}
}
