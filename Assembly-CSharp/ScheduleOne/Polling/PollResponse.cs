using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	[Serializable]
	public class PollResponse
	{
		// Token: 0x06001667 RID: 5735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x59EA20", Offset = "0x59DC20", VA = "0x18059EA20")]
		public PollData GetActive()
		{
			return null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x59EAB0", Offset = "0x59DCB0", VA = "0x18059EAB0")]
		public PollData GetConfirmed()
		{
			return null;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PollResponse()
		{
		}

		// Token: 0x040013A8 RID: 5032
		[Token(Token = "0x40013A8")]
		[FieldOffset(Offset = "0x10")]
		public PollData[] polls;

		// Token: 0x040013A9 RID: 5033
		[Token(Token = "0x40013A9")]
		[FieldOffset(Offset = "0x18")]
		public int active;

		// Token: 0x040013AA RID: 5034
		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x1C")]
		public int confirmed;
	}
}
