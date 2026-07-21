using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	public class WeedLoader : ItemLoader
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700050B")]
		public override string ItemType
		{
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0x61D540", Offset = "0x61C740", VA = "0x18061D540", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public WeedLoader()
		{
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x61D270", Offset = "0x61C470", VA = "0x18061D270", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
