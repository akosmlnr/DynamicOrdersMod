using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000E04 RID: 3588
	[Token(Token = "0x2000E04")]
	public class WaterContainerUI : ItemUI
	{
		// Token: 0x060066D7 RID: 26327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0xA9FAD0", Offset = "0xA9ECD0", VA = "0x180A9FAD0", Slot = "4")]
		public override void Setup(ItemInstance item)
		{
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0xA9FBB0", Offset = "0xA9EDB0", VA = "0x180A9FBB0", Slot = "8")]
		public override void UpdateUI()
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WaterContainerUI()
		{
		}

		// Token: 0x04004894 RID: 18580
		[Token(Token = "0x4004894")]
		[FieldOffset(Offset = "0x48")]
		protected WaterContainerInstance wcInstance;

		// Token: 0x04004895 RID: 18581
		[Token(Token = "0x4004895")]
		[FieldOffset(Offset = "0x50")]
		public Text AmountLabel;
	}
}
