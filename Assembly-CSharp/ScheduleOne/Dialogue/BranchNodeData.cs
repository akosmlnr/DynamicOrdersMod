using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200071C RID: 1820
	[Token(Token = "0x200071C")]
	[Serializable]
	public class BranchNodeData
	{
		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public BranchNodeData()
		{
		}

		// Token: 0x04002343 RID: 9027
		[Token(Token = "0x4002343")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04002344 RID: 9028
		[Token(Token = "0x4002344")]
		[FieldOffset(Offset = "0x18")]
		public string BranchLabel;

		// Token: 0x04002345 RID: 9029
		[Token(Token = "0x4002345")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04002346 RID: 9030
		[Token(Token = "0x4002346")]
		[FieldOffset(Offset = "0x28")]
		public BranchOptionData[] options;
	}
}
