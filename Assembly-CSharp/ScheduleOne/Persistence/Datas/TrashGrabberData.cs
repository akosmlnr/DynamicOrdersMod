using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x604180", Offset = "0x603380", VA = "0x180604180")]
		public TrashGrabberData(string iD, int quantity, TrashContentData content)
		{
		}

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x38")]
		public TrashContentData Content;
	}
}
