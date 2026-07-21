using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	[Serializable]
	public class DialogueNodeEvent
	{
		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueNodeEvent()
		{
		}

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x10")]
		public string NodeLabel;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent onNodeDisplayed;
	}
}
