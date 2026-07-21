using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	public class TrashGrabberLoader : ItemLoader
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000509")]
		public override string ItemType
		{
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0x61B290", Offset = "0x61A490", VA = "0x18061B290", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x6028A0", Offset = "0x601AA0", VA = "0x1806028A0")]
		public TrashGrabberLoader()
		{
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x61B0B0", Offset = "0x61A2B0", VA = "0x18061B0B0", Slot = "5")]
		public override ItemInstance LoadItem(string itemString)
		{
			return null;
		}
	}
}
