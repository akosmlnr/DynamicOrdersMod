using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C1B RID: 3099
	[Token(Token = "0x2000C1B")]
	[RequireComponent(typeof(CanvasGroup))]
	public class CanvasGroupFader : MonoBehaviour
	{
		// Token: 0x06005AE8 RID: 23272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0x9C2050", Offset = "0x9C1250", VA = "0x1809C2050")]
		private void Awake()
		{
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0x9C2290", Offset = "0x9C1490", VA = "0x1809C2290")]
		public void FadeTo(float targetAlpha)
		{
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0x9C20A0", Offset = "0x9C12A0", VA = "0x1809C20A0")]
		public void FadeTo(float targetAlpha, float duration)
		{
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0x9C22A0", Offset = "0x9C14A0", VA = "0x1809C22A0")]
		public CanvasGroupFader()
		{
		}

		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _defaultFadeDuration;

		// Token: 0x04003D62 RID: 15714
		[Token(Token = "0x4003D62")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _scaleDurationWithFadeAmount;

		// Token: 0x04003D63 RID: 15715
		[Token(Token = "0x4003D63")]
		[FieldOffset(Offset = "0x28")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04003D64 RID: 15716
		[Token(Token = "0x4003D64")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _fadeRoutine;
	}
}
