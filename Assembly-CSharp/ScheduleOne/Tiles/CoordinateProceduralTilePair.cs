using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	[Serializable]
	public struct CoordinateProceduralTilePair
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003CA")]
		public ProceduralTile tile
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0xB1ACF0", Offset = "0xB19EF0", VA = "0x180B1ACF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x8")]
		public NetworkObject tileParent;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x10")]
		public int tileIndex;
	}
}
