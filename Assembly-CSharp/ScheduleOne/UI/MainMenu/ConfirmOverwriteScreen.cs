using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DB2 RID: 3506
	[Token(Token = "0x2000DB2")]
	public class ConfirmOverwriteScreen : MainMenuScreen
	{
		// Token: 0x060064F8 RID: 25848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x54A5C0", Offset = "0x5497C0", VA = "0x18054A5C0")]
		public void Initialize(int index)
		{
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0xA715C0", Offset = "0xA707C0", VA = "0x180A715C0")]
		public void Confirm()
		{
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ConfirmOverwriteScreen()
		{
		}

		// Token: 0x040046CC RID: 18124
		[Token(Token = "0x40046CC")]
		[FieldOffset(Offset = "0x60")]
		public SetupScreen SetupScreen;

		// Token: 0x040046CD RID: 18125
		[Token(Token = "0x40046CD")]
		[FieldOffset(Offset = "0x68")]
		private int slotIndex;
	}
}
