using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Economy
{
	// Token: 0x020006C2 RID: 1730
	[Token(Token = "0x20006C2")]
	public static class StandardsMethod
	{
		// Token: 0x06002D92 RID: 11666 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x72F4E0", Offset = "0x72E6E0", VA = "0x18072F4E0")]
		public static string GetName(this ECustomerStandard property)
		{
			return null;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x72F4A0", Offset = "0x72E6A0", VA = "0x18072F4A0")]
		public static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			return EQuality.Trash;
		}
	}
}
