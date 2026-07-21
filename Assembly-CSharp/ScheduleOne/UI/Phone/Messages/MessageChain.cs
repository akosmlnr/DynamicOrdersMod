using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D51 RID: 3409
	[Token(Token = "0x2000D51")]
	[Serializable]
	public class MessageChain
	{
		// Token: 0x060062F5 RID: 25333 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60062F5")]
		[Address(RVA = "0xA63800", Offset = "0xA62A00", VA = "0x180A63800")]
		public static MessageChain Combine(MessageChain a, MessageChain b)
		{
			return null;
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F6")]
		[Address(RVA = "0xA63920", Offset = "0xA62B20", VA = "0x180A63920")]
		public MessageChain()
		{
		}

		// Token: 0x040044F7 RID: 17655
		[Token(Token = "0x40044F7")]
		[FieldOffset(Offset = "0x10")]
		[TextArea(2, 10)]
		public List<string> Messages;

		// Token: 0x040044F8 RID: 17656
		[Token(Token = "0x40044F8")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int id;
	}
}
