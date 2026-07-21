using System;
using Il2CppDummyDll;
using ScheduleOne.ExtendedComponents;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DC2 RID: 3522
	[Token(Token = "0x2000DC2")]
	public class SetupScreen : MainMenuScreen
	{
		// Token: 0x0600653D RID: 25917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653D")]
		[Address(RVA = "0xA82FE0", Offset = "0xA821E0", VA = "0x180A82FE0", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653E")]
		[Address(RVA = "0xA829D0", Offset = "0xA81BD0", VA = "0x180A829D0")]
		public void Initialize(int index)
		{
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653F")]
		[Address(RVA = "0xA830C0", Offset = "0xA822C0", VA = "0x180A830C0")]
		private void Update()
		{
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006540")]
		[Address(RVA = "0xA82A10", Offset = "0xA81C10", VA = "0x180A82A10")]
		public void StartGame()
		{
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x00018C60 File Offset: 0x00016E60
		[Token(Token = "0x6006541")]
		[Address(RVA = "0xA829E0", Offset = "0xA81BE0", VA = "0x180A829E0")]
		private bool IsInputValid()
		{
			return default(bool);
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006542")]
		[Address(RVA = "0xA82550", Offset = "0xA81750", VA = "0x180A82550")]
		private void ClearFolderContents(string folderPath)
		{
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006543")]
		[Address(RVA = "0xA82670", Offset = "0xA81870", VA = "0x180A82670")]
		private void CopyDefaultSaveToFolder(string folderPath)
		{
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006544")]
		[Address(RVA = "0xA82860", Offset = "0xA81A60", VA = "0x180A82860")]
		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006545")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SetupScreen()
		{
		}

		// Token: 0x04004706 RID: 18182
		[Token(Token = "0x4004706")]
		public const string DEFAULT_SAVE_PATH = "DefaultSave";

		// Token: 0x04004707 RID: 18183
		[Token(Token = "0x4004707")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public GameInputField InputField;

		// Token: 0x04004708 RID: 18184
		[Token(Token = "0x4004708")]
		[FieldOffset(Offset = "0x68")]
		public Button StartButton;

		// Token: 0x04004709 RID: 18185
		[Token(Token = "0x4004709")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform SkipIntroContainer;

		// Token: 0x0400470A RID: 18186
		[Token(Token = "0x400470A")]
		[FieldOffset(Offset = "0x78")]
		public Toggle SkipIntroToggle;

		// Token: 0x0400470B RID: 18187
		[Token(Token = "0x400470B")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform NotHostWarning;

		// Token: 0x0400470C RID: 18188
		[Token(Token = "0x400470C")]
		[FieldOffset(Offset = "0x88")]
		private int slotIndex;
	}
}
