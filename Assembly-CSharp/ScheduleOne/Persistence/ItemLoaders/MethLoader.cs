using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E9 RID: 1257
	[Token(Token = "0x20004E9")]
	public class MethLoader : ItemLoader
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000505")]
		public override string ItemType
		{
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x613360", Offset = "0x612560", VA = "0x180613360", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public MethLoader()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x613090", Offset = "0x612290", VA = "0x180613090", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
