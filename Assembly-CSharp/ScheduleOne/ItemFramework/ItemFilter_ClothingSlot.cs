using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Clothing;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200061D RID: 1565
	[Token(Token = "0x200061D")]
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x0000C870 File Offset: 0x0000AA70
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BB")]
		public EClothingSlot SlotType
		{
			[Token(Token = "0x600269F")]
			[Address(RVA = "0x43D220", Offset = "0x43C420", VA = "0x18043D220")]
			[CompilerGenerated]
			get
			{
				return EClothingSlot.Feet;
			}
			[Token(Token = "0x60026A0")]
			[Address(RVA = "0x48AD80", Offset = "0x489F80", VA = "0x18048AD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x447010", Offset = "0x446210", VA = "0x180447010")]
		public ItemFilter_ClothingSlot(EClothingSlot slot)
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x6C3BD0", Offset = "0x6C2DD0", VA = "0x1806C3BD0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
