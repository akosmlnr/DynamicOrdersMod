using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C10 RID: 3088
	[Token(Token = "0x2000C10")]
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x00017010 File Offset: 0x00015210
		// (set) Token: 0x06005AAA RID: 23210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1F")]
		public bool isShown
		{
			[Token(Token = "0x6005AA9")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AAA")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x9BFCA0", Offset = "0x9BEEA0", VA = "0x1809BFCA0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0x9BFE10", Offset = "0x9BF010", VA = "0x1809BFE10")]
		public void Open(float fadeTime = 0.5f)
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x9BFD10", Offset = "0x9BEF10", VA = "0x1809BFD10")]
		public void Close(float fadeTime = 0.5f)
		{
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x9BFD80", Offset = "0x9BEF80", VA = "0x1809BFD80")]
		private IEnumerator Fade(float endOpacity, float fadeTime)
		{
			return null;
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x9BFEA0", Offset = "0x9BF0A0", VA = "0x1809BFEA0")]
		public BlackOverlay()
		{
		}

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003D1D RID: 15645
		[Token(Token = "0x4003D1D")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup group;

		// Token: 0x04003D1E RID: 15646
		[Token(Token = "0x4003D1E")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine fadeRoutine;
	}
}
