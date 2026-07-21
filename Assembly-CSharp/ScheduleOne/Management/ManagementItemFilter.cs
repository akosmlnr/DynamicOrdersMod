using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	public class ManagementItemFilter
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0000B430 File Offset: 0x00009630
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CA")]
		public ManagementItemFilter.EMode Mode
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0x43D220", Offset = "0x43C420", VA = "0x18043D220")]
			[CompilerGenerated]
			get
			{
				return ManagementItemFilter.EMode.Whitelist;
			}
			[Token(Token = "0x600208C")]
			[Address(RVA = "0x48AD80", Offset = "0x489F80", VA = "0x18048AD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CB")]
		public List<ItemDefinition> Items
		{
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x67A470", Offset = "0x679670", VA = "0x18067A470")]
		public ManagementItemFilter(ManagementItemFilter.EMode mode)
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x48AD80", Offset = "0x489F80", VA = "0x18048AD80")]
		public void SetMode(ManagementItemFilter.EMode mode)
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x67A150", Offset = "0x679350", VA = "0x18067A150")]
		public void AddItem(ItemDefinition item)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x67A410", Offset = "0x679610", VA = "0x18067A410")]
		public void RemoveItem(ItemDefinition item)
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x67A200", Offset = "0x679400", VA = "0x18067A200")]
		public bool Contains(ItemDefinition item)
		{
			return default(bool);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x67A260", Offset = "0x679460", VA = "0x18067A260")]
		public bool DoesItemMeetFilter(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x67A310", Offset = "0x679510", VA = "0x18067A310")]
		public string GetDescription()
		{
			return null;
		}

		// Token: 0x0200058F RID: 1423
		[Token(Token = "0x200058F")]
		public enum EMode
		{
			// Token: 0x04001A76 RID: 6774
			[Token(Token = "0x4001A76")]
			Whitelist,
			// Token: 0x04001A77 RID: 6775
			[Token(Token = "0x4001A77")]
			Blacklist
		}
	}
}
