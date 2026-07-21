using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DED RID: 3565
	[Token(Token = "0x2000DED")]
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x0600663C RID: 26172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600663C")]
		[Address(RVA = "0xA9B2A0", Offset = "0xA9A4A0", VA = "0x180A9B2A0", Slot = "4")]
		public override void Setup(ItemInstance item)
		{
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600663D")]
		[Address(RVA = "0xA9B380", Offset = "0xA9A580", VA = "0x180A9B380", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600663E")]
		[Address(RVA = "0xA9B250", Offset = "0xA9A450", VA = "0x180A9B250")]
		public void SetDisplayedBalance(float balance)
		{
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600663F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemUI_Cash()
		{
		}

		// Token: 0x0400481B RID: 18459
		[Token(Token = "0x400481B")]
		[FieldOffset(Offset = "0x48")]
		protected CashInstance cashInstance;

		// Token: 0x0400481C RID: 18460
		[Token(Token = "0x400481C")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI AmountLabel;
	}
}
