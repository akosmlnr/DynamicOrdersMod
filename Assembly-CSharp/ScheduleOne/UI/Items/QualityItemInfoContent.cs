using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x060066CF RID: 26319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0xA9BD90", Offset = "0xA9AF90", VA = "0x180A9BD90", Slot = "4")]
		public override void Initialize(ItemInstance instance)
		{
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0xA94E10", Offset = "0xA94010", VA = "0x180A94E10")]
		public QualityItemInfoContent()
		{
		}

		// Token: 0x0400488E RID: 18574
		[Token(Token = "0x400488E")]
		[FieldOffset(Offset = "0x38")]
		public Image Star;

		// Token: 0x0400488F RID: 18575
		[Token(Token = "0x400488F")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI QualityLabel;
	}
}
