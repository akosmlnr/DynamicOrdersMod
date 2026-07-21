using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public class ProductItemLoader : ItemLoader
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000506")]
		public override string ItemType
		{
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0x616670", Offset = "0x615870", VA = "0x180616670", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public ProductItemLoader()
		{
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x6163A0", Offset = "0x6155A0", VA = "0x1806163A0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
