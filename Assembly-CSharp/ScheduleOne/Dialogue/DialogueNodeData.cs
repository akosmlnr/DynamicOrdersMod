using System;
using Il2CppDummyDll;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	[Serializable]
	public class DialogueNodeData
	{
		// Token: 0x06002FEB RID: 12267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x765DE0", Offset = "0x764FE0", VA = "0x180765DE0")]
		public DialogueNodeData GetCopy()
		{
			return null;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueNodeData()
		{
		}

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x18")]
		public string DialogueText;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x20")]
		public string DialogueNodeLabel;

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 Position;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		[FieldOffset(Offset = "0x30")]
		public DialogueChoiceData[] choices;

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x38")]
		public EVOLineType VoiceLine;
	}
}
