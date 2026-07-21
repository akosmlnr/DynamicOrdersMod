using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20004EB")]
	public class QualityItemLoader : ItemLoader
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000507")]
		public override string ItemType
		{
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x616AE0", Offset = "0x615CE0", VA = "0x180616AE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public QualityItemLoader()
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x6168B0", Offset = "0x615AB0", VA = "0x1806168B0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
