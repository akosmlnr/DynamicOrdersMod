using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	[Serializable]
	public struct CoordinateStorageFootprintTilePair
	{
		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x8")]
		public FootprintTile tile;
	}
}
