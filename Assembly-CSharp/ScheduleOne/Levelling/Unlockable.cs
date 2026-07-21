using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	public class Unlockable
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x688BA0", Offset = "0x687DA0", VA = "0x180688BA0")]
		public Unlockable(FullRank rank, string title, Sprite icon)
		{
		}

		// Token: 0x04001B15 RID: 6933
		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x10")]
		public FullRank Rank;

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x20")]
		public Sprite Icon;
	}
}
