using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x6C3FC0", Offset = "0x6C31C0", VA = "0x1806C3FC0")]
		public ItemFilter_ID(List<string> ids)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x6C3F10", Offset = "0x6C3110", VA = "0x1806C3F10", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x10")]
		public bool IsWhitelist;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x18")]
		public List<string> IDs;
	}
}
