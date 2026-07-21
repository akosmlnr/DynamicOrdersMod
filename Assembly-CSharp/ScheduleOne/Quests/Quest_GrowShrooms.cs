using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.Quests
{
	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000343")]
	public class Quest_GrowShrooms : Quest
	{
		// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x5A7960", Offset = "0x5A6B60", VA = "0x1805A7960", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x5A7A80", Offset = "0x5A6C80", VA = "0x1805A7A80")]
		private void SupplierUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x5A7AC0", Offset = "0x5A6CC0", VA = "0x1805A7AC0")]
		public Quest_GrowShrooms()
		{
		}

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x138")]
		public Supplier ShroomSupplier;
	}
}
