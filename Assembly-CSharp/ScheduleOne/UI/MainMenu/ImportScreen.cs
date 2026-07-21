using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x2000DB6")]
	public class ImportScreen : MainMenuScreen
	{
		// Token: 0x06006508 RID: 25864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006508")]
		[Address(RVA = "0xA770D0", Offset = "0xA762D0", VA = "0x180A770D0")]
		public void Initialize(int _slotToOverwrite, MainMenuScreen previousScreen)
		{
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006509")]
		[Address(RVA = "0xA76BC0", Offset = "0xA75DC0", VA = "0x180A76BC0")]
		public void Cancel()
		{
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650A")]
		[Address(RVA = "0xA76BE0", Offset = "0xA75DE0", VA = "0x180A76BE0")]
		public void Confirm()
		{
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650B")]
		[Address(RVA = "0xA76F60", Offset = "0xA76160", VA = "0x180A76F60")]
		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ImportScreen()
		{
		}

		// Token: 0x040046D7 RID: 18135
		[Token(Token = "0x40046D7")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public GameObject MainContainer;

		// Token: 0x040046D8 RID: 18136
		[Token(Token = "0x40046D8")]
		[FieldOffset(Offset = "0x68")]
		public GameObject FailContainer;

		// Token: 0x040046D9 RID: 18137
		[Token(Token = "0x40046D9")]
		[FieldOffset(Offset = "0x70")]
		public Button ConfirmButton;

		// Token: 0x040046DA RID: 18138
		[Token(Token = "0x40046DA")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI OrganisationNameLabel;

		// Token: 0x040046DB RID: 18139
		[Token(Token = "0x40046DB")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI NetworthLabel;

		// Token: 0x040046DC RID: 18140
		[Token(Token = "0x40046DC")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI VersionLabel;

		// Token: 0x040046DD RID: 18141
		[Token(Token = "0x40046DD")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI WarningLabel;

		// Token: 0x040046DE RID: 18142
		[Token(Token = "0x40046DE")]
		[FieldOffset(Offset = "0x98")]
		private int slotToOverwrite;

		// Token: 0x040046DF RID: 18143
		[Token(Token = "0x40046DF")]
		[FieldOffset(Offset = "0xA0")]
		private SaveInfo saveInfo;
	}
}
