using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DEE RID: 3566
	[Token(Token = "0x2000DEE")]
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x06006640 RID: 26176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006640")]
		[Address(RVA = "0xA8F6C0", Offset = "0xA8E8C0", VA = "0x180A8F6C0", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006641")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ClothingItemUI()
		{
		}

		// Token: 0x0400481D RID: 18461
		[Token(Token = "0x400481D")]
		[FieldOffset(Offset = "0x48")]
		public Image ClothingTypeIcon;
	}
}
