using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000726 RID: 1830
	[Token(Token = "0x2000726")]
	[Serializable]
	public class NodeLinkData
	{
		// Token: 0x06002FED RID: 12269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public NodeLinkData()
		{
		}

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x10")]
		public string BaseDialogueOrBranchNodeGuid;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x18")]
		public string BaseChoiceOrOptionGUID;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x20")]
		public string TargetNodeGuid;
	}
}
