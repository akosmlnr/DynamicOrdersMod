using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x060066CC RID: 26316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066CC")]
		[Address(RVA = "0xA9B8E0", Offset = "0xA9AAE0", VA = "0x180A9B8E0", Slot = "4")]
		public override void Initialize(ItemInstance instance)
		{
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0xA9B940", Offset = "0xA9AB40", VA = "0x180A9B940", Slot = "5")]
		public override void Initialize(ItemDefinition definition)
		{
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066CE")]
		[Address(RVA = "0xA9BD10", Offset = "0xA9AF10", VA = "0x180A9BD10")]
		public ProductItemInfoContent()
		{
		}

		// Token: 0x0400488D RID: 18573
		[Token(Token = "0x400488D")]
		[FieldOffset(Offset = "0x48")]
		public List<TextMeshProUGUI> PropertyLabels;
	}
}
