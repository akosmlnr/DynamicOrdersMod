using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public class DebugInterface : MonoBehaviour
	{
		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x9F36E0", Offset = "0x9F28E0", VA = "0x1809F36E0")]
		private void Start()
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x9F41E0", Offset = "0x9F33E0", VA = "0x1809F41E0")]
		private void Update()
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x9F2900", Offset = "0x9F1B00", VA = "0x1809F2900")]
		private void OpenConfirmationMenu()
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x9F2D00", Offset = "0x9F1F00", VA = "0x1809F2D00")]
		private void OpenModifyAmountMenu()
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x9F3520", Offset = "0x9F2720", VA = "0x1809F3520")]
		private void SetupGridPanel()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		public void ApplyFilter(int[] filters)
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x9F2860", Offset = "0x9F1A60", VA = "0x1809F2860")]
		private void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DebugInterface()
		{
		}

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x20")]
		public UIScreen MainScreen;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x28")]
		public UIScreen SecondScreen;

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x30")]
		public UIPanel GridPanel;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x38")]
		public Transform GridPanelContainer;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x40")]
		public UISelectable ButtonPrefab;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x48")]
		public UIPanel horizontalPanel;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI DebugText;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x58")]
		public UIHorizontalSelector testHorizontalSelector;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x60")]
		public UIPopupSelector testPopupSelector;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x68")]
		public Sprite testIcon;
	}
}
