using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class IDs : ItemFilter
	{
		// Token: 0x06002699 RID: 9881 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x6BF8A0", Offset = "0x6BEAA0", VA = "0x1806BF8A0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x6BF910", Offset = "0x6BEB10", VA = "0x1806BF910")]
		public IDs()
		{
		}

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x10")]
		public List<string> AcceptedIDs;
	}
}
