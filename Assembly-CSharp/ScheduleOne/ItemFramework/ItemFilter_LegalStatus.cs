using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Items.Framework;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x060026A8 RID: 9896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x447010", Offset = "0x446210", VA = "0x180447010")]
		public ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus)
		{
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x6C4060", Offset = "0x6C3260", VA = "0x1806C4060", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x10")]
		public ELegalStatus RequiredLegalStatus;
	}
}
