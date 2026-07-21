using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	[Serializable]
	public struct CoordinateFootprintTilePair
	{
		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x8")]
		public FootprintTile footprintTile;
	}
}
