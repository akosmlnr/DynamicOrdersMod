using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	public class ClothingLoader : ItemLoader
	{
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000501")]
		public override string ItemType
		{
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x602E40", Offset = "0x602040", VA = "0x180602E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public ClothingLoader()
		{
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x602C70", Offset = "0x601E70", VA = "0x180602C70", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
