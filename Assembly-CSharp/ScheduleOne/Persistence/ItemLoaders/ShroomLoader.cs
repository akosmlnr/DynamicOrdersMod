using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	public class ShroomLoader : ItemLoader
	{
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000508")]
		public override string ItemType
		{
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x6184A0", Offset = "0x6176A0", VA = "0x1806184A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public ShroomLoader()
		{
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x6181D0", Offset = "0x6173D0", VA = "0x1806181D0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
