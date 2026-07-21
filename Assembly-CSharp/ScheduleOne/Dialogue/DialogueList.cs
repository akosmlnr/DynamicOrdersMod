using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	[Serializable]
	public class DialogueList
	{
		// Token: 0x06002F5B RID: 12123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x743C30", Offset = "0x742E30", VA = "0x180743C30")]
		public string GetRandomLine()
		{
			return null;
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueList()
		{
		}

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x10")]
		public string[] Lines;
	}
}
