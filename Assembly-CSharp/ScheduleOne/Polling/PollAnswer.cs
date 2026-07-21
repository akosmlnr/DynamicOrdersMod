using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	[Serializable]
	public class PollAnswer
	{
		// Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x59D8E0", Offset = "0x59CAE0", VA = "0x18059D8E0")]
		public PollAnswer(int _pollId, int _answer, string _ticket)
		{
		}

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x10")]
		public int pollId;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x14")]
		public int answer;

		// Token: 0x04001380 RID: 4992
		[Token(Token = "0x4001380")]
		[FieldOffset(Offset = "0x18")]
		public string ticket;
	}
}
