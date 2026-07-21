using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x060026AC RID: 9900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x6C42B0", Offset = "0x6C34B0", VA = "0x1806C42B0")]
		public ItemFilter_PackagedProduct()
		{
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x6C4190", Offset = "0x6C3390", VA = "0x1806C4190", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
