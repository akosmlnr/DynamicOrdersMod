using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public struct ExtensionFilter
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x43D6B0", Offset = "0x43C8B0", VA = "0x18043D6B0")]
		public ExtensionFilter(string filterName, params string[] filterExtensions)
		{
		}

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x0")]
		public string Name;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x8")]
		public string[] Extensions;
	}
}
