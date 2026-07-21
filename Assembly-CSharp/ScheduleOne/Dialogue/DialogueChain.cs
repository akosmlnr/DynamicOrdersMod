using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	[Serializable]
	public class DialogueChain
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F5D")]
		[Address(RVA = "0x7375F0", Offset = "0x7367F0", VA = "0x1807375F0")]
		public MessageChain GetMessageChain()
		{
			return null;
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5E")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueChain()
		{
		}

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x10")]
		[TextArea(1, 10)]
		public string[] Lines;
	}
}
