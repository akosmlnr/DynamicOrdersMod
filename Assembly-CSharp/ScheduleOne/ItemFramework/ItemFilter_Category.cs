using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core.Items.Framework;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200061C RID: 1564
	[Token(Token = "0x200061C")]
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x6C3B30", Offset = "0x6C2D30", VA = "0x1806C3B30")]
		public ItemFilter_Category(List<EItemCategory> acceptedCategories)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x6C3AB0", Offset = "0x6C2CB0", VA = "0x1806C3AB0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x10")]
		public List<EItemCategory> AcceptedCategories;
	}
}
