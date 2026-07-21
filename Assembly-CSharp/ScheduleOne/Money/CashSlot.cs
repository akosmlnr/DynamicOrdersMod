using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Money
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	public class CashSlot : HotbarSlot
	{
		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x6202A0", Offset = "0x61F4A0", VA = "0x1806202A0", Slot = "7")]
		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "13")]
		public override bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x620330", Offset = "0x61F530", VA = "0x180620330")]
		public CashSlot()
		{
		}

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		public const float MAX_CASH_PER_SLOT = 1000f;
	}
}
