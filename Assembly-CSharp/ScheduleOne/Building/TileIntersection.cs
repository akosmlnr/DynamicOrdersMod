using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Building
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class TileIntersection
	{
		// Token: 0x060034D4 RID: 13524 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x79E8A0", Offset = "0x79DAA0", VA = "0x18079E8A0")]
		public static bool operator ==(TileIntersection a, TileIntersection b)
		{
			return default(bool);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x79E980", Offset = "0x79DB80", VA = "0x18079E980")]
		public static bool operator !=(TileIntersection a, TileIntersection b)
		{
			return default(bool);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public TileIntersection()
		{
		}

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x10")]
		public FootprintTile footprint;

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x18")]
		public Tile tile;
	}
}
