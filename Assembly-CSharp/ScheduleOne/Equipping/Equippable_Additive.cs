using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000952 RID: 2386
	[Token(Token = "0x2000952")]
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x851480", Offset = "0x850680", VA = "0x180851480", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x8515B0", Offset = "0x8507B0", VA = "0x1808515B0", Slot = "10")]
		protected override void StartPourTask(GrowContainer growContainer)
		{
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x851400", Offset = "0x850600", VA = "0x180851400", Slot = "11")]
		protected override bool CanPour(GrowContainer pot, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x851620", Offset = "0x850820", VA = "0x180851620")]
		public Equippable_Additive()
		{
		}

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x70")]
		private AdditiveDefinition additiveDef;
	}
}
