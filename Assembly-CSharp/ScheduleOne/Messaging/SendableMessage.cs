using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	public class SendableMessage
	{
		// Token: 0x06001C75 RID: 7285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x62C100", Offset = "0x62B300", VA = "0x18062C100")]
		public SendableMessage(string text, MSGConversation conversation)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x62C0E0", Offset = "0x62B2E0", VA = "0x18062C0E0", Slot = "4")]
		public virtual bool ShouldShow()
		{
			return default(bool);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x62BF00", Offset = "0x62B100", VA = "0x18062BF00", Slot = "5")]
		public virtual bool IsValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x62BF90", Offset = "0x62B190", VA = "0x18062BF90", Slot = "6")]
		public virtual void Send(bool network, int id = -1)
		{
		}

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x18")]
		public SendableMessage.BoolCheck ShouldShowCheck;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x20")]
		public SendableMessage.ValidityCheck IsValidCheck;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x28")]
		public Action onSelected;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x30")]
		public Action onSent;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x38")]
		private MSGConversation conversation;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x40")]
		public bool disableDefaultSendBehaviour;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x48")]
		private List<int> sentIDs;

		// Token: 0x02000517 RID: 1303
		// (Invoke) Token: 0x06001C7A RID: 7290
		[Token(Token = "0x2000517")]
		public delegate bool BoolCheck(SendableMessage message);

		// Token: 0x02000518 RID: 1304
		// (Invoke) Token: 0x06001C7E RID: 7294
		[Token(Token = "0x2000518")]
		public delegate bool ValidityCheck(SendableMessage message, out string invalidReason);
	}
}
