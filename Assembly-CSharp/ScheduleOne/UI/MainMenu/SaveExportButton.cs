using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DC0 RID: 3520
	[Token(Token = "0x2000DC0")]
	[RequireComponent(typeof(Button))]
	public class SaveExportButton : MonoBehaviour
	{
		// Token: 0x06006532 RID: 25906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006532")]
		[Address(RVA = "0xA80D00", Offset = "0xA7FF00", VA = "0x180A80D00")]
		private void Awake()
		{
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006533")]
		[Address(RVA = "0xA80DB0", Offset = "0xA7FFB0", VA = "0x180A80DB0")]
		private void Clicked()
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006534")]
		[Address(RVA = "0xA81160", Offset = "0xA80360", VA = "0x180A81160")]
		public static string ShowSaveFileDialog(string fileName)
		{
			return null;
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006535")]
		[Address(RVA = "0xA812E0", Offset = "0xA804E0", VA = "0x180A812E0")]
		public static void ZipSaveFolder(string sourceFolderPath, string destinationZipPath)
		{
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SaveExportButton()
		{
		}

		// Token: 0x04004702 RID: 18178
		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0x20")]
		public int SaveSlotIndex;
	}
}
