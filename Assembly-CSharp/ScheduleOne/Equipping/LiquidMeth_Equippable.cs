using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003FBF RID: 16319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x85DEC0", Offset = "0x85D0C0", VA = "0x18085DEC0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x858100", Offset = "0x857300", VA = "0x180858100")]
		public LiquidMeth_Equippable()
		{
		}

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x60")]
		public LiquidMethVisuals Visuals;
	}
}
