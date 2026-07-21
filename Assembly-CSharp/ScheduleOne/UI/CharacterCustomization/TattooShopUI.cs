using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000DDD")]
	public class TattooShopUI : CharacterCustomizationUI
	{
		// Token: 0x060065E8 RID: 26088 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0xA9D8D0", Offset = "0xA9CAD0", VA = "0x180A9D8D0", Slot = "5")]
		public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return default(bool);
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0xA9DB80", Offset = "0xA9CD80", VA = "0x180A9DB80", Slot = "6")]
		public override void OptionSelected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0xA9DA40", Offset = "0xA9CC40", VA = "0x180A9DA40", Slot = "7")]
		public override void OptionDeselected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0xA8F670", Offset = "0xA8E870", VA = "0x180A8F670")]
		public TattooShopUI()
		{
		}
	}
}
