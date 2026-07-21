using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x5A83E0", Offset = "0x5A75E0", VA = "0x1805A83E0", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x5A8400", Offset = "0x5A7600", VA = "0x1805A8400")]
		public Quest_SecuringSupplies()
		{
		}

		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		[FieldOffset(Offset = "0x138")]
		public Supplier Supplier;
	}
}
