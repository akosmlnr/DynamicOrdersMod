using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	[Serializable]
	public class PollData
	{
		// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PollData()
		{
		}

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x10")]
		public int pollId;

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x18")]
		public string question;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x20")]
		public string[] answers;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x28")]
		public string[] answerDescriptions;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x30")]
		public int winnerIndex;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x38")]
		public string confirmationMessage;
	}
}
