using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	[Serializable]
	public class SlotFilter
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x6CCDA0", Offset = "0x6CBFA0", VA = "0x1806CCDA0")]
		public SlotFilter()
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x6CCBC0", Offset = "0x6CBDC0", VA = "0x1806CCBC0")]
		public bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x6CCD30", Offset = "0x6CBF30", VA = "0x1806CCD30")]
		public bool IsDefault()
		{
			return default(bool);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x6CCAA0", Offset = "0x6CBCA0", VA = "0x1806CCAA0")]
		public SlotFilter Clone()
		{
			return null;
		}

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x10")]
		public SlotFilter.EType Type;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x18")]
		public List<string> ItemIDs;

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x20")]
		public List<EQuality> AllowedQualities;

		// Token: 0x0200063D RID: 1597
		[Token(Token = "0x200063D")]
		public enum EType
		{
			// Token: 0x04001E99 RID: 7833
			[Token(Token = "0x4001E99")]
			None,
			// Token: 0x04001E9A RID: 7834
			[Token(Token = "0x4001E9A")]
			Whitelist,
			// Token: 0x04001E9B RID: 7835
			[Token(Token = "0x4001E9B")]
			Blacklist
		}
	}
}
