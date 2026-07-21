using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x06002E44 RID: 11844 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x7373C0", Offset = "0x7365C0", VA = "0x1807373C0", Slot = "8")]
		protected override bool IsKnockValid(out string message)
		{
			return default(bool);
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x7375D0", Offset = "0x7367D0", VA = "0x1807375D0")]
		public DealerStaticDoor()
		{
		}

		// Token: 0x0400223E RID: 8766
		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x60")]
		public Dealer Dealer;
	}
}
