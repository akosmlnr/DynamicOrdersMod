using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000705 RID: 1797
	[Token(Token = "0x2000705")]
	[Serializable]
	public struct Entry
	{
		// Token: 0x06002F69 RID: 12137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x74BC60", Offset = "0x74AE60", VA = "0x18074BC60")]
		public DialogueChain GetRandomChain()
		{
			return null;
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x74BCC0", Offset = "0x74AEC0", VA = "0x18074BCC0")]
		public string GetRandomLine()
		{
			return null;
		}

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x0")]
		public string Key;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x8")]
		public DialogueChain[] Chains;
	}
}
