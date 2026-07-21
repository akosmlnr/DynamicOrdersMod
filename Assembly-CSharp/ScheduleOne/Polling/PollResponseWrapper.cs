using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	[Serializable]
	public class PollResponseWrapper
	{
		// Token: 0x0600166C RID: 5740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PollResponseWrapper()
		{
		}

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x10")]
		public bool success;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x18")]
		public PollResponse data;
	}
}
