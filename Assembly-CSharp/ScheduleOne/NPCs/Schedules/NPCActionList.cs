using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	public class NPCActionList
	{
		// Token: 0x06005616 RID: 22038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005616")]
		[Address(RVA = "0x9788D0", Offset = "0x977AD0", VA = "0x1809788D0")]
		public NPCActionList()
		{
		}

		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		[FieldOffset(Offset = "0x10")]
		public List<NPCAction> actionList;
	}
}
