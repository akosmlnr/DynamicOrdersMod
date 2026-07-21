using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000E02 RID: 3586
	[Token(Token = "0x2000E02")]
	public class QualityItemUI : ItemUI
	{
		// Token: 0x060066D1 RID: 26321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D1")]
		[Address(RVA = "0xA9C010", Offset = "0xA9B210", VA = "0x180A9C010", Slot = "4")]
		public override void Setup(ItemInstance item)
		{
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0xA9C0F0", Offset = "0xA9B2F0", VA = "0x180A9C0F0", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D3")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public QualityItemUI()
		{
		}

		// Token: 0x04004890 RID: 18576
		[Token(Token = "0x4004890")]
		[FieldOffset(Offset = "0x48")]
		public Image QualityIcon;

		// Token: 0x04004891 RID: 18577
		[Token(Token = "0x4004891")]
		[FieldOffset(Offset = "0x50")]
		protected QualityItemInstance qualityItemInstance;
	}
}
