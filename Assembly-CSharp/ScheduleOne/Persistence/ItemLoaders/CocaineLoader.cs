using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class CocaineLoader : ItemLoader
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000502")]
		public override string ItemType
		{
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0x603200", Offset = "0x602400", VA = "0x180603200", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public CocaineLoader()
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x602F30", Offset = "0x602130", VA = "0x180602F30", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
