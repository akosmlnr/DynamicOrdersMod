using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	public class UIPopupSelector : UIOption
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0xADAE40", Offset = "0xADA040", VA = "0x180ADAE40")]
		public int GetOptionCount()
		{
			return 0;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0xADAC50", Offset = "0xAD9E50", VA = "0x180ADAC50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0xADAE60", Offset = "0xADA060", VA = "0x180ADAE60")]
		private void OpenPopup()
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0xADADA0", Offset = "0xAD9FA0", VA = "0x180ADADA0")]
		private void ClosePopup(int selectedIndex)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0xADB210", Offset = "0xADA410", VA = "0x180ADB210")]
		public void SetCurrentOptionWithoutNotify(int index)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0xADB420", Offset = "0xADA620", VA = "0x180ADB420")]
		private void UpdateCurrentOptionText()
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0xADAA00", Offset = "0xAD9C00", VA = "0x180ADAA00")]
		public void AddOption(UIPopupScreen_ContextMenu.ContextMenuOption option)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0xADAB40", Offset = "0xAD9D40", VA = "0x180ADAB40")]
		public void AddOptions(UIPopupScreen_ContextMenu.ContextMenuOption[] newOptions)
		{
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0xADAD50", Offset = "0xAD9F50", VA = "0x180ADAD50")]
		public void ClearOptions()
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0xADAD10", Offset = "0xAD9F10", VA = "0x180ADAD10")]
		private void ClampCurrentIndex()
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0xADB220", Offset = "0xADA420", VA = "0x180ADB220")]
		public void SetOptions(UIPopupScreen_ContextMenu.ContextMenuOption[] newOptions, int defaultIndex = 0)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0xADB4E0", Offset = "0xADA6E0", VA = "0x180ADB4E0")]
		public UIPopupSelector()
		{
		}

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI currentOptionNameText;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent<UIPopupScreen_ContextMenu.ContextMenuOption> OnChanged;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x50")]
		private UIPopupScreen_ContextMenu.ContextMenuOption[] options;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x58")]
		private int currentIndex;
	}
}
