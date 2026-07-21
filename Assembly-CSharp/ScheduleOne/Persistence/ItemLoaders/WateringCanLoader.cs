using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public class WateringCanLoader : ItemLoader
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700050A")]
		public override string ItemType
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x61D1F0", Offset = "0x61C3F0", VA = "0x18061D1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public WateringCanLoader()
		{
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x61D020", Offset = "0x61C220", VA = "0x18061D020", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
