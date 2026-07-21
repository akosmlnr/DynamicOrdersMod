using System;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	public class Equippable_BuildableItem : Equippable
	{
		// Token: 0x06003FE5 RID: 16357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x851CE0", Offset = "0x850EE0", VA = "0x180851CE0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x851C50", Offset = "0x850E50", VA = "0x180851C50", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x851D80", Offset = "0x850F80", VA = "0x180851D80")]
		public Equippable_BuildableItem()
		{
		}

		// Token: 0x04002E8F RID: 11919
		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x30")]
		protected bool isBuilding;
	}
}
