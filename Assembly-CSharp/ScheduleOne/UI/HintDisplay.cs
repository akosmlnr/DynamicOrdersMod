using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C52 RID: 3154
	[Token(Token = "0x2000C52")]
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x00017550 File Offset: 0x00015750
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5F")]
		public bool IsOpen
		{
			[Token(Token = "0x6005C5A")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C5B")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x9DC0C0", Offset = "0x9DB2C0", VA = "0x1809DC0C0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x9DC1C0", Offset = "0x9DB3C0", VA = "0x1809DC1C0")]
		public void Update()
		{
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x9DBDD0", Offset = "0x9DAFD0", VA = "0x1809DBDD0")]
		public void ShowHint_10s(string text)
		{
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x9DBDE0", Offset = "0x9DAFE0", VA = "0x1809DBDE0")]
		public void ShowHint_20s(string text)
		{
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x9DC0B0", Offset = "0x9DB2B0", VA = "0x1809DC0B0")]
		public void ShowHint(string text)
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x9DBDF0", Offset = "0x9DAFF0", VA = "0x1809DBDF0")]
		public void ShowHint(string text, float autoCloseTime = 0f)
		{
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x9DB740", Offset = "0x9DA940", VA = "0x1809DB740")]
		public void Hide()
		{
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x9DBC90", Offset = "0x9DAE90", VA = "0x1809DBC90")]
		private void SetAlpha(float alpha)
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x9DB990", Offset = "0x9DAB90", VA = "0x1809DB990")]
		public void QueueHint_10s(string message)
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x9DBA90", Offset = "0x9DAC90", VA = "0x1809DBA90")]
		public void QueueHint_20s(string message)
		{
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x9DBB90", Offset = "0x9DAD90", VA = "0x1809DBB90")]
		public void QueueHint(string message, float time)
		{
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x9DB760", Offset = "0x9DA960", VA = "0x1809DB760")]
		private string ProcessText(string text)
		{
			return null;
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x9DC420", Offset = "0x9DB620", VA = "0x1809DC420")]
		public HintDisplay()
		{
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x9DC140", Offset = "0x9DB340", VA = "0x1809DC140")]
		[CompilerGenerated]
		private IEnumerator <ShowHint>g__AutoClose|22_0(float time)
		{
			return null;
		}

		// Token: 0x04003EA7 RID: 16039
		[Token(Token = "0x4003EA7")]
		public const float FadeTime = 0.3f;

		// Token: 0x04003EA9 RID: 16041
		[Token(Token = "0x4003EA9")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003EAA RID: 16042
		[Token(Token = "0x4003EAA")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI Label;

		// Token: 0x04003EAB RID: 16043
		[Token(Token = "0x4003EAB")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x04003EAC RID: 16044
		[Token(Token = "0x4003EAC")]
		[FieldOffset(Offset = "0x48")]
		public InputPrompt DismissPrompt;

		// Token: 0x04003EAD RID: 16045
		[Token(Token = "0x4003EAD")]
		[FieldOffset(Offset = "0x50")]
		public Animation FlashAnim;

		// Token: 0x04003EAE RID: 16046
		[Token(Token = "0x4003EAE")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public Vector2 Padding;

		// Token: 0x04003EAF RID: 16047
		[Token(Token = "0x4003EAF")]
		[FieldOffset(Offset = "0x60")]
		public Vector2 Offset;

		// Token: 0x04003EB0 RID: 16048
		[Token(Token = "0x4003EB0")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine autoCloseRoutine;

		// Token: 0x04003EB1 RID: 16049
		[Token(Token = "0x4003EB1")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine fadeRoutine;

		// Token: 0x04003EB2 RID: 16050
		[Token(Token = "0x4003EB2")]
		[FieldOffset(Offset = "0x78")]
		private List<HintDisplay.Hint> hintQueue;

		// Token: 0x04003EB3 RID: 16051
		[Token(Token = "0x4003EB3")]
		[FieldOffset(Offset = "0x80")]
		private float timeSinceOpened;

		// Token: 0x02000C53 RID: 3155
		[Token(Token = "0x2000C53")]
		private class Hint
		{
			// Token: 0x06005C6A RID: 23658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C6A")]
			[Address(RVA = "0x6B98C0", Offset = "0x6B8AC0", VA = "0x1806B98C0")]
			public Hint(string text, float duration)
			{
			}

			// Token: 0x04003EB4 RID: 16052
			[Token(Token = "0x4003EB4")]
			[FieldOffset(Offset = "0x10")]
			public string Text;

			// Token: 0x04003EB5 RID: 16053
			[Token(Token = "0x4003EB5")]
			[FieldOffset(Offset = "0x18")]
			public float Duration;
		}
	}
}
