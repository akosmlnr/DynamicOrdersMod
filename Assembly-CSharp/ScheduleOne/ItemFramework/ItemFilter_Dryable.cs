using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200061E RID: 1566
	[Token(Token = "0x200061E")]
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ItemFilter_Dryable()
		{
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x6C3D00", Offset = "0x6C2F00", VA = "0x1806C3D00", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x6C3D20", Offset = "0x6C2F20", VA = "0x1806C3D20")]
		public static bool IsItemDryable(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
