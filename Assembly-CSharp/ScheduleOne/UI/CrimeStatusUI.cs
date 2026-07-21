using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0xA08340", Offset = "0xA07540", VA = "0x180A08340")]
		public void UpdateStatus()
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0xA08240", Offset = "0xA07440", VA = "0x180A08240")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0xA082D0", Offset = "0xA074D0", VA = "0x180A082D0")]
		private IEnumerator Routine()
		{
			return null;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CrimeStatusUI()
		{
		}

		// Token: 0x0400404E RID: 16462
		[Token(Token = "0x400404E")]
		public const float SmallTextSize = 0.75f;

		// Token: 0x0400404F RID: 16463
		[Token(Token = "0x400404F")]
		public const float LargeTextSize = 1f;

		// Token: 0x04004050 RID: 16464
		[Token(Token = "0x4004050")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public RectTransform CrimeStatusContainer;

		// Token: 0x04004051 RID: 16465
		[Token(Token = "0x4004051")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup CrimeStatusGroup;

		// Token: 0x04004052 RID: 16466
		[Token(Token = "0x4004052")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BodysearchLabel;

		// Token: 0x04004053 RID: 16467
		[Token(Token = "0x4004053")]
		[FieldOffset(Offset = "0x38")]
		public Image InvestigatingMask;

		// Token: 0x04004054 RID: 16468
		[Token(Token = "0x4004054")]
		[FieldOffset(Offset = "0x40")]
		public Image UnderArrestMask;

		// Token: 0x04004055 RID: 16469
		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x48")]
		public Image WantedMask;

		// Token: 0x04004056 RID: 16470
		[Token(Token = "0x4004056")]
		[FieldOffset(Offset = "0x50")]
		public Image WantedDeadMask;

		// Token: 0x04004057 RID: 16471
		[Token(Token = "0x4004057")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrestProgressContainer;

		// Token: 0x04004058 RID: 16472
		[Token(Token = "0x4004058")]
		[FieldOffset(Offset = "0x60")]
		private bool animateText;

		// Token: 0x04004059 RID: 16473
		[Token(Token = "0x4004059")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine routine;
	}
}
