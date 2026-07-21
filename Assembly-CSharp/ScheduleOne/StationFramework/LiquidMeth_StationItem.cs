using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x817AE0", Offset = "0x816CE0", VA = "0x180817AE0", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x817C60", Offset = "0x816E60", VA = "0x180817C60")]
		public LiquidMeth_StationItem()
		{
		}

		// Token: 0x04002C5E RID: 11358
		[Token(Token = "0x4002C5E")]
		[FieldOffset(Offset = "0x38")]
		public LiquidMethVisuals Visuals;
	}
}
