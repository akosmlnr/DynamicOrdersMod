using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Input
{
	// Token: 0x02000DC8 RID: 3528
	[Token(Token = "0x2000DC8")]
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		// Token: 0x06006558 RID: 25944 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006558")]
		[Address(RVA = "0xA798C0", Offset = "0xA78AC0", VA = "0x180A798C0")]
		public PromptImage GetPromptImage(string controlPath, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00018C78 File Offset: 0x00016E78
		[Token(Token = "0x6006559")]
		[Address(RVA = "0xA79C60", Offset = "0xA78E60", VA = "0x180A79C60")]
		private bool IsControlPathMouseRelated(string controlPath)
		{
			return default(bool);
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00018C90 File Offset: 0x00016E90
		[Token(Token = "0x600655A")]
		[Address(RVA = "0xA79CF0", Offset = "0xA78EF0", VA = "0x180A79CF0")]
		private bool IsControlPathWideKey(string controlPath)
		{
			return default(bool);
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x00018CA8 File Offset: 0x00016EA8
		[Token(Token = "0x600655B")]
		[Address(RVA = "0xA79C10", Offset = "0xA78E10", VA = "0x180A79C10")]
		private bool IsControlPathExtraWideKey(string controlPath)
		{
			return default(bool);
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600655C")]
		[Address(RVA = "0xA78210", Offset = "0xA77410", VA = "0x180A78210")]
		public string GetDisplayNameForControlPath(string controlPath)
		{
			return null;
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655D")]
		[Address(RVA = "0xA79F00", Offset = "0xA79100", VA = "0x180A79F00")]
		public InputPromptsManager()
		{
		}

		// Token: 0x04004725 RID: 18213
		[Token(Token = "0x4004725")]
		[FieldOffset(Offset = "0x28")]
		[Header("Input Prompt Prefabs")]
		public GameObject KeyPromptPrefab;

		// Token: 0x04004726 RID: 18214
		[Token(Token = "0x4004726")]
		[FieldOffset(Offset = "0x30")]
		public GameObject WideKeyPromptPrefab;

		// Token: 0x04004727 RID: 18215
		[Token(Token = "0x4004727")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ExtraWideKeyPromptPrefab;

		// Token: 0x04004728 RID: 18216
		[Token(Token = "0x4004728")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LeftClickPromptPrefab;

		// Token: 0x04004729 RID: 18217
		[Token(Token = "0x4004729")]
		[FieldOffset(Offset = "0x48")]
		public GameObject MiddleClickPromptPrefab;

		// Token: 0x0400472A RID: 18218
		[Token(Token = "0x400472A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RightClickPromptPrefab;
	}
}
