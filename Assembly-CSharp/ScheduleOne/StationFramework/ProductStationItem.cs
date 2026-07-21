using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	public class ProductStationItem : StationItem
	{
		// Token: 0x06003D6C RID: 15724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x84D0B0", Offset = "0x84C2B0", VA = "0x18084D0B0", Slot = "5")]
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x817C60", Offset = "0x816E60", VA = "0x180817C60")]
		public ProductStationItem()
		{
		}

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x38")]
		public ProductVisualsSetter Visuals;
	}
}
