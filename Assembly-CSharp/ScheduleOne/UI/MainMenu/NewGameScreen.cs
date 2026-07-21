using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DBE RID: 3518
	[Token(Token = "0x2000DBE")]
	public class NewGameScreen : MainMenuScreen
	{
		// Token: 0x06006529 RID: 25897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006529")]
		[Address(RVA = "0xA7C6F0", Offset = "0xA7B8F0", VA = "0x180A7C6F0")]
		public void SlotSelected(int slotIndex)
		{
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NewGameScreen()
		{
		}

		// Token: 0x040046FF RID: 18175
		[Token(Token = "0x40046FF")]
		[FieldOffset(Offset = "0x60")]
		public ConfirmOverwriteScreen ConfirmOverwriteScreen;

		// Token: 0x04004700 RID: 18176
		[Token(Token = "0x4004700")]
		[FieldOffset(Offset = "0x68")]
		public SetupScreen SetupScreen;
	}
}
