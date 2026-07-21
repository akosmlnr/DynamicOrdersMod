using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public class ThomasData : NPCData
	{
		// Token: 0x06001B3D RID: 6973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x619E10", Offset = "0x619010", VA = "0x180619E10")]
		public ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent)
		{
		}

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x30")]
		public bool MeetingReminderSent;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x31")]
		public bool HandoverReminderSent;
	}
}
