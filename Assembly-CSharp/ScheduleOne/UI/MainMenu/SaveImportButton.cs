using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DC1 RID: 3521
	[Token(Token = "0x2000DC1")]
	[RequireComponent(typeof(Button))]
	public class SaveImportButton : MonoBehaviour
	{
		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E6E")]
		public static string TempImportPath
		{
			[Token(Token = "0x6006537")]
			[Address(RVA = "0xA819C0", Offset = "0xA80BC0", VA = "0x180A819C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006538")]
		[Address(RVA = "0xA81330", Offset = "0xA80530", VA = "0x180A81330")]
		private void Awake()
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006539")]
		[Address(RVA = "0xA813E0", Offset = "0xA805E0", VA = "0x180A813E0")]
		private void Clicked()
		{
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653A")]
		[Address(RVA = "0xA818E0", Offset = "0xA80AE0", VA = "0x180A818E0")]
		public static void UnzipSaveFile(string zipFilePath, string destinationFolderPath)
		{
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600653B")]
		[Address(RVA = "0xA81770", Offset = "0xA80970", VA = "0x180A81770")]
		public static string ShowOpenFileDialog()
		{
			return null;
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SaveImportButton()
		{
		}

		// Token: 0x04004703 RID: 18179
		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0x20")]
		public ImportScreen ImportScreen;

		// Token: 0x04004704 RID: 18180
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0x28")]
		public MainMenuScreen ParentScreen;

		// Token: 0x04004705 RID: 18181
		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x30")]
		public int SaveSlotIndex;
	}
}
