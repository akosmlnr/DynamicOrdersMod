using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x6087A0", Offset = "0x6079A0", VA = "0x1806087A0")]
		public MSGConversationData(int conversationIndex, bool read, TextMessageData[] messageHistory, TextResponseData[] activeResponses, bool isHidden)
		{
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x608710", Offset = "0x607910", VA = "0x180608710")]
		public MSGConversationData()
		{
		}

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x28")]
		public int ConversationIndex;

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x2C")]
		public bool Read;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x30")]
		public TextMessageData[] MessageHistory;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x38")]
		public TextResponseData[] ActiveResponses;

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x40")]
		public bool IsHidden;
	}
}
