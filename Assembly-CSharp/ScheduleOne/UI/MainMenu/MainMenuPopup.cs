using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x2000DB8")]
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x06006510 RID: 25872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006510")]
		[Address(RVA = "0xA7A370", Offset = "0xA79570", VA = "0x180A7A370")]
		public void Open(MainMenuPopup.Data data)
		{
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006511")]
		[Address(RVA = "0xA7A230", Offset = "0xA79430", VA = "0x180A7A230")]
		public void Open(string title, string description, bool isBad)
		{
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006512")]
		[Address(RVA = "0xA7A4C0", Offset = "0xA796C0", VA = "0x180A7A4C0")]
		public MainMenuPopup()
		{
		}

		// Token: 0x040046E0 RID: 18144
		[Token(Token = "0x40046E0")]
		[FieldOffset(Offset = "0x28")]
		public MainMenuScreen Screen;

		// Token: 0x040046E1 RID: 18145
		[Token(Token = "0x40046E1")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Title;

		// Token: 0x040046E2 RID: 18146
		[Token(Token = "0x40046E2")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI Description;

		// Token: 0x02000DB9 RID: 3513
		[Token(Token = "0x2000DB9")]
		public class Data
		{
			// Token: 0x06006513 RID: 25875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006513")]
			[Address(RVA = "0xA71870", Offset = "0xA70A70", VA = "0x180A71870")]
			public Data(string title, string description, bool isBad)
			{
			}

			// Token: 0x040046E3 RID: 18147
			[Token(Token = "0x40046E3")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x040046E4 RID: 18148
			[Token(Token = "0x40046E4")]
			[FieldOffset(Offset = "0x18")]
			public string Description;

			// Token: 0x040046E5 RID: 18149
			[Token(Token = "0x40046E5")]
			[FieldOffset(Offset = "0x20")]
			public bool IsBad;
		}
	}
}
