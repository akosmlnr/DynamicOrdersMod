using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x06002FC7 RID: 12231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x765820", Offset = "0x764A20", VA = "0x180765820")]
		public DialogueModule Get(EDialogueModule moduleType)
		{
			return null;
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x7659B0", Offset = "0x764BB0", VA = "0x1807659B0")]
		public DialogueManager()
		{
		}

		// Token: 0x04002334 RID: 9012
		[Token(Token = "0x4002334")]
		[FieldOffset(Offset = "0x28")]
		public DialogueDatabase DefaultDatabase;

		// Token: 0x04002335 RID: 9013
		[Token(Token = "0x4002335")]
		[FieldOffset(Offset = "0x30")]
		public List<DialogueModule> DefaultModules;
	}
}
