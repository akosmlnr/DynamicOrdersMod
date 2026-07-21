using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public static class Version
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013E")]
		public static string CurrentAsString
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x7BD620", Offset = "0x7BC820", VA = "0x1807BD620")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x7BD530", Offset = "0x7BC730", VA = "0x1807BD530")]
		private static string GetVersionAsString(int version)
		{
			return null;
		}

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		public const int Current = 20100;
	}
}
