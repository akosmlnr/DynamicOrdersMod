using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using TMPro;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class TrashGrabberItemUI : ItemUI
	{
		// Token: 0x060066D4 RID: 26324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D4")]
		[Address(RVA = "0xA9DCD0", Offset = "0xA9CED0", VA = "0x180A9DCD0", Slot = "4")]
		public override void Setup(ItemInstance item)
		{
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D5")]
		[Address(RVA = "0xA9DDB0", Offset = "0xA9CFB0", VA = "0x180A9DDB0", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D6")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TrashGrabberItemUI()
		{
		}

		// Token: 0x04004892 RID: 18578
		[Token(Token = "0x4004892")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI ValueLabel;

		// Token: 0x04004893 RID: 18579
		[Token(Token = "0x4004893")]
		[FieldOffset(Offset = "0x50")]
		protected TrashGrabberInstance trashGrabberInstance;
	}
}
