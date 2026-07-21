using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	public class ItemLoader
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000504")]
		public virtual string ItemType
		{
			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x605730", Offset = "0x604930", VA = "0x180605730", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x605630", Offset = "0x604830", VA = "0x180605630")]
		public ItemLoader()
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x605470", Offset = "0x604670", VA = "0x180605470", Slot = "5")]
		public virtual ItemInstance LoadItem(string itemString)
		{
			return null;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B4D")]
		protected T LoadData<T>(string itemString) where T : ItemData
		{
			return null;
		}
	}
}
