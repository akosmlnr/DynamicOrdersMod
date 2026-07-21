using System;
using Il2CppDummyDll;
using ScheduleOne.Product;

namespace ScheduleOne.Packaging
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	public class FilledPackaging_Equippable : Product_Equippable
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x7FAB80", Offset = "0x7F9D80", VA = "0x1807FAB80", Slot = "9")]
		protected override void ApplyProductVisuals(ProductItemInstance product)
		{
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x7FABB0", Offset = "0x7F9DB0", VA = "0x1807FABB0")]
		public FilledPackaging_Equippable()
		{
		}

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0xA0")]
		public MultiTypeVisualsSetter MultiTypeVisuals;
	}
}
