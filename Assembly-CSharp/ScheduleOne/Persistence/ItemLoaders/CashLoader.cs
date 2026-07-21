using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	public class CashLoader : ItemLoader
	{
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000500")]
		public override string ItemType
		{
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x6028B0", Offset = "0x601AB0", VA = "0x1806028B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public CashLoader()
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x6026C0", Offset = "0x6018C0", VA = "0x1806026C0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
