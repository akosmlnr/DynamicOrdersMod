using System;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000962 RID: 2402
	[Token(Token = "0x2000962")]
	public class Equippable_SurfaceItem : Equippable
	{
		// Token: 0x06004047 RID: 16455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x858830", Offset = "0x857A30", VA = "0x180858830", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x8587A0", Offset = "0x8579A0", VA = "0x1808587A0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x851D80", Offset = "0x850F80", VA = "0x180851D80")]
		public Equippable_SurfaceItem()
		{
		}

		// Token: 0x04002EFA RID: 12026
		[Token(Token = "0x4002EFA")]
		[FieldOffset(Offset = "0x30")]
		protected bool isBuilding;
	}
}
