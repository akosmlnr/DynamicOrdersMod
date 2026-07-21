using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AeLa.EasyFeedback;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C3F RID: 3135
	[Token(Token = "0x2000C3F")]
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x9CD380", Offset = "0x9CC580", VA = "0x1809CD380", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x9CE590", Offset = "0x9CD790", VA = "0x1809CE590")]
		private void Update()
		{
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x9CD720", Offset = "0x9CC920", VA = "0x1809CD720")]
		public void PrepScreenshot()
		{
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
		private void OnScreenshotToggle(bool value)
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
		private void OnSaveFileToggle(bool value)
		{
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x9CD950", Offset = "0x9CCB50", VA = "0x1809CD950")]
		public void SetFormData(string title)
		{
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x9CD7F0", Offset = "0x9CC9F0", VA = "0x1809CD7F0")]
		public void SetCategory(string categoryName)
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x9CDA30", Offset = "0x9CCC30", VA = "0x1809CDA30", Slot = "5")]
		public override void Submit()
		{
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x9CD5B0", Offset = "0x9CC7B0", VA = "0x1809CD5B0", Slot = "6")]
		protected override string GetTextToAppendToTitle()
		{
			return null;
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x9CD530", Offset = "0x9CC730", VA = "0x1809CD530")]
		private void Clear()
		{
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x9CD780", Offset = "0x9CC980", VA = "0x1809CD780")]
		private IEnumerator ScreenshotAndOpenForm()
		{
			return null;
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x9CE640", Offset = "0x9CD840", VA = "0x1809CE640")]
		public FeedbackForm()
		{
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x9CE520", Offset = "0x9CD720", VA = "0x1809CE520")]
		[CompilerGenerated]
		private IEnumerator <Submit>g__Wait|14_0()
		{
			return null;
		}

		// Token: 0x04003E38 RID: 15928
		[Token(Token = "0x4003E38")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04003E39 RID: 15929
		[Token(Token = "0x4003E39")]
		[FieldOffset(Offset = "0xA0")]
		public Toggle ScreenshotToggle;

		// Token: 0x04003E3A RID: 15930
		[Token(Token = "0x4003E3A")]
		[FieldOffset(Offset = "0xA8")]
		public Toggle SaveFileToggle;

		// Token: 0x04003E3B RID: 15931
		[Token(Token = "0x4003E3B")]
		[FieldOffset(Offset = "0xB0")]
		public TMP_InputField SummaryField;

		// Token: 0x04003E3C RID: 15932
		[Token(Token = "0x4003E3C")]
		[FieldOffset(Offset = "0xB8")]
		public TMP_InputField DescriptionField;

		// Token: 0x04003E3D RID: 15933
		[Token(Token = "0x4003E3D")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform Cog;

		// Token: 0x04003E3E RID: 15934
		[Token(Token = "0x4003E3E")]
		[FieldOffset(Offset = "0xC8")]
		public TMP_Dropdown CategoryDropdown;
	}
}
