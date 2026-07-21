using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.UI.Input
{
	// Token: 0x02000DC6 RID: 3526
	[Token(Token = "0x2000DC6")]
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E6F")]
		private InputPromptsManager manager
		{
			[Token(Token = "0x6006550")]
			[Address(RVA = "0xA78140", Offset = "0xA77340", VA = "0x180A78140")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006551")]
		[Address(RVA = "0xA77560", Offset = "0xA76760", VA = "0x180A77560")]
		private void OnEnable()
		{
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006552")]
		[Address(RVA = "0x814FC0", Offset = "0x8141C0", VA = "0x180814FC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006553")]
		[Address(RVA = "0xA775A0", Offset = "0xA767A0", VA = "0x180A775A0")]
		private void RefreshPromptImages()
		{
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006554")]
		[Address(RVA = "0xA77EC0", Offset = "0xA770C0", VA = "0x180A77EC0")]
		public void SetLabel(string label)
		{
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006555")]
		[Address(RVA = "0xA77F10", Offset = "0xA77110", VA = "0x180A77F10")]
		private void UpdateShade()
		{
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006556")]
		[Address(RVA = "0xA78040", Offset = "0xA77240", VA = "0x180A78040")]
		public InputPrompt()
		{
		}

		// Token: 0x04004714 RID: 18196
		[Token(Token = "0x4004714")]
		[FieldOffset(Offset = "0x0")]
		public static float Spacing;

		// Token: 0x04004715 RID: 18197
		[Token(Token = "0x4004715")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public List<InputActionReference> Actions;

		// Token: 0x04004716 RID: 18198
		[Token(Token = "0x4004716")]
		[FieldOffset(Offset = "0x28")]
		public string Label;

		// Token: 0x04004717 RID: 18199
		[Token(Token = "0x4004717")]
		[FieldOffset(Offset = "0x30")]
		public InputPrompt.EInputPromptAlignment Alignment;

		// Token: 0x04004718 RID: 18200
		[Token(Token = "0x4004718")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04004719 RID: 18201
		[Token(Token = "0x4004719")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform ImagesContainer;

		// Token: 0x0400471A RID: 18202
		[Token(Token = "0x400471A")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI LabelComponent;

		// Token: 0x0400471B RID: 18203
		[Token(Token = "0x400471B")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform Shade;

		// Token: 0x0400471C RID: 18204
		[Token(Token = "0x400471C")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public bool OverridePromptImageColor;

		// Token: 0x0400471D RID: 18205
		[Token(Token = "0x400471D")]
		[FieldOffset(Offset = "0x5C")]
		public Color PromptImageColor;

		// Token: 0x0400471E RID: 18206
		[Token(Token = "0x400471E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<PromptImage> promptImages;

		// Token: 0x0400471F RID: 18207
		[Token(Token = "0x400471F")]
		[FieldOffset(Offset = "0x78")]
		private List<InputActionReference> displayedActions;

		// Token: 0x04004720 RID: 18208
		[Token(Token = "0x4004720")]
		[FieldOffset(Offset = "0x80")]
		private InputPrompt.EInputPromptAlignment AppliedAlignment;

		// Token: 0x02000DC7 RID: 3527
		[Token(Token = "0x2000DC7")]
		public enum EInputPromptAlignment
		{
			// Token: 0x04004722 RID: 18210
			[Token(Token = "0x4004722")]
			Left,
			// Token: 0x04004723 RID: 18211
			[Token(Token = "0x4004723")]
			Middle,
			// Token: 0x04004724 RID: 18212
			[Token(Token = "0x4004724")]
			Right
		}
	}
}
