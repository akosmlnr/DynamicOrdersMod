using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	[Serializable]
	public class QuestWindowConfig
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x5A4770", Offset = "0x5A3970", VA = "0x1805A4770")]
		public QuestWindowConfig()
		{
		}

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x10")]
		public bool IsEnabled;

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x14")]
		public int WindowStartTime;

		// Token: 0x040012CA RID: 4810
		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0x18")]
		public int WindowEndTime;
	}
}
