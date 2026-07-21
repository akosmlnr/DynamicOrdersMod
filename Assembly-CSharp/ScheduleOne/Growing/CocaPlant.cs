using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	public class CocaPlant : Plant
	{
		// Token: 0x06003A6E RID: 14958 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x7F8A00", Offset = "0x7F7C00", VA = "0x1807F8A00", Slot = "9")]
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x7F8AF0", Offset = "0x7F7CF0", VA = "0x1807F8AF0")]
		public CocaPlant()
		{
		}

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0xA8")]
		public PlantHarvestable Harvestable;
	}
}
