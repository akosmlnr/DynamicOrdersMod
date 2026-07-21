using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	[Serializable]
	public struct CoordinateStorageTilePair
	{
		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x8")]
		public StorageTile tile;
	}
}
