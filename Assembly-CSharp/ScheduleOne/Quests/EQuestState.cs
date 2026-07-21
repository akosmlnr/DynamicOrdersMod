using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	public enum EQuestState
	{
		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		Inactive,
		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		Active,
		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		Completed,
		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		Failed,
		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		Expired,
		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		Cancelled
	}
}
