using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x200071E")]
	[Serializable]
	public class DialogueChoiceData
	{
		// Token: 0x06002FD5 RID: 12245 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x764890", Offset = "0x763A90", VA = "0x180764890")]
		public DialogueChoiceData GetCopy()
		{
			return null;
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x764920", Offset = "0x763B20", VA = "0x180764920")]
		public DialogueChoiceData()
		{
		}

		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0x18")]
		public string ChoiceText;

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x20")]
		public string ChoiceLabel;

		// Token: 0x0400234B RID: 9035
		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0x28")]
		public bool ShowWorldspaceDialogue;
	}
}
