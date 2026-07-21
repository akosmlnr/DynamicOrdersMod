using System;
using System.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	public class UIPopupScreen_ConfirmationMenu : UIPopupScreen
	{
		// Token: 0x06000C1D RID: 3101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0xAD6FD0", Offset = "0xAD61D0", VA = "0x180AD6FD0", Slot = "9")]
		public override void Close()
		{
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0xAD70A0", Offset = "0xAD62A0", VA = "0x180AD70A0")]
		private void Open()
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0xAD7190", Offset = "0xAD6390", VA = "0x180AD7190", Slot = "8")]
		public override void Open(params object[] args)
		{
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0xAD7610", Offset = "0xAD6810", VA = "0x180AD7610")]
		private IEnumerator RegisterInput(Action onConfirm, Action onCancel)
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0xAD76C0", Offset = "0xAD68C0", VA = "0x180AD76C0")]
		private void SelectPanel(UISelectable selectable)
		{
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0xAD77D0", Offset = "0xAD69D0", VA = "0x180AD77D0")]
		public UIPopupScreen_ConfirmationMenu()
		{
		}

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text titleText;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TMP_Text messageText;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UISelectable confirmButton;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UISelectable cancelButton;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Canvas canvas;
	}
}
