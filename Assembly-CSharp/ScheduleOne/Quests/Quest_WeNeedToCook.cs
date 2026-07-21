using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x5AA7D0", Offset = "0x5A99D0", VA = "0x1805AA7D0", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x5AA880", Offset = "0x5A9A80", VA = "0x1805AA880")]
		public Quest_WeNeedToCook()
		{
		}

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x138")]
		public Quest[] PrerequisiteQuests;

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x140")]
		public Supplier MethSupplier;
	}
}
