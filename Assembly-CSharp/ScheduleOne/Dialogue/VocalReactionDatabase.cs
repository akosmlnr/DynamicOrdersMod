using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000727 RID: 1831
	[Token(Token = "0x2000727")]
	[Serializable]
	public class VocalReactionDatabase
	{
		// Token: 0x06002FEE RID: 12270 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x76BFC0", Offset = "0x76B1C0", VA = "0x18076BFC0")]
		public VocalReactionDatabase.Entry GetEntry(string key)
		{
			return null;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x76C120", Offset = "0x76B320", VA = "0x18076C120")]
		public VocalReactionDatabase()
		{
		}

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x10")]
		public List<VocalReactionDatabase.Entry> Entries;

		// Token: 0x02000728 RID: 1832
		[Token(Token = "0x2000728")]
		[Serializable]
		public class Entry
		{
			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170007D9")]
			public string name
			{
				[Token(Token = "0x6002FF0")]
				[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002FF1 RID: 12273 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6002FF1")]
			[Address(RVA = "0x766070", Offset = "0x765270", VA = "0x180766070")]
			public string GetRandomReaction()
			{
				return null;
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF2")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Entry()
			{
			}

			// Token: 0x0400235F RID: 9055
			[Token(Token = "0x400235F")]
			[FieldOffset(Offset = "0x10")]
			public string Key;

			// Token: 0x04002360 RID: 9056
			[Token(Token = "0x4002360")]
			[FieldOffset(Offset = "0x18")]
			public string[] Reactions;
		}
	}
}
