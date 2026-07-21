using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000706 RID: 1798
	[Token(Token = "0x2000706")]
	[Serializable]
	public class DialogueEvent
	{
		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueEvent()
		{
		}

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x10")]
		public DialogueContainer Dialogue;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent onDialogueEnded;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x20")]
		public DialogueNodeEvent[] NodeEvents;
	}
}
