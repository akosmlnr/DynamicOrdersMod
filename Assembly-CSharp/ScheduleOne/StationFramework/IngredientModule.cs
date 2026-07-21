using System;
using Il2CppDummyDll;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	public class IngredientModule : ItemModule
	{
		// Token: 0x06003CA4 RID: 15524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x816950", Offset = "0x815B50", VA = "0x180816950", Slot = "4")]
		public override void ActivateModule(StationItem item)
		{
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public IngredientModule()
		{
		}

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x30")]
		public IngredientPiece[] Pieces;
	}
}
