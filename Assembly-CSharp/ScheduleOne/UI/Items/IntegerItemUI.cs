using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DF6 RID: 3574
	[Token(Token = "0x2000DF6")]
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x0600667A RID: 26234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667A")]
		[Address(RVA = "0xA94A50", Offset = "0xA93C50", VA = "0x180A94A50", Slot = "4")]
		public override void Setup(ItemInstance item)
		{
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667B")]
		[Address(RVA = "0xA94B30", Offset = "0xA93D30", VA = "0x180A94B30", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public IntegerItemUI()
		{
		}

		// Token: 0x04004849 RID: 18505
		[Token(Token = "0x4004849")]
		[FieldOffset(Offset = "0x48")]
		public Text ValueLabel;

		// Token: 0x0400484A RID: 18506
		[Token(Token = "0x400484A")]
		[FieldOffset(Offset = "0x50")]
		protected IntegerItemInstance integerItemInstance;
	}
}
