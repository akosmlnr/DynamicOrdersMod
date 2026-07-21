using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x06002FCB RID: 12235 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x765B00", Offset = "0x764D00", VA = "0x180765B00")]
		public Entry GetEntry(string key)
		{
			return default(Entry);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x765A40", Offset = "0x764C40", VA = "0x180765A40")]
		public DialogueChain GetChain(string key)
		{
			return null;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x765CF0", Offset = "0x764EF0", VA = "0x180765CF0")]
		public bool HasChain(string key)
		{
			return default(bool);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x765C00", Offset = "0x764E00", VA = "0x180765C00")]
		public string GetLine(string key)
		{
			return null;
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x765D20", Offset = "0x764F20", VA = "0x180765D20")]
		public bool HasLine(string key)
		{
			return default(bool);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x765D60", Offset = "0x764F60", VA = "0x180765D60")]
		public DialogueModule()
		{
		}

		// Token: 0x04002337 RID: 9015
		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x20")]
		public EDialogueModule ModuleType;

		// Token: 0x04002338 RID: 9016
		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x28")]
		public List<Entry> Entries;
	}
}
