using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	public class IntegerItemLoader : ItemLoader
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000503")]
		public override string ItemType
		{
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x6053A0", Offset = "0x6045A0", VA = "0x1806053A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public IntegerItemLoader()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x6051D0", Offset = "0x6043D0", VA = "0x1806051D0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
