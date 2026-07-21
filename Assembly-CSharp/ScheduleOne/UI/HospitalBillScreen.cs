using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public class HospitalBillScreen : Singleton<HospitalBillScreen>
	{
		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06005DFC RID: 24060 RVA: 0x00017A18 File Offset: 0x00015C18
		// (set) Token: 0x06005DFD RID: 24061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9B")]
		public bool isOpen
		{
			[Token(Token = "0x6005DFC")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DFD")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0xA093F0", Offset = "0xA085F0", VA = "0x180A093F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0xA09830", Offset = "0xA08A30", VA = "0x180A09830")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E00")]
		[Address(RVA = "0xA09B40", Offset = "0xA08D40", VA = "0x180A09B40")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E01")]
		[Address(RVA = "0xA09880", Offset = "0xA08A80", VA = "0x180A09880")]
		public void Open()
		{
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E02")]
		[Address(RVA = "0xA09620", Offset = "0xA08820", VA = "0x180A09620")]
		public void Close()
		{
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E03")]
		[Address(RVA = "0xA09C40", Offset = "0xA08E40", VA = "0x180A09C40")]
		public HospitalBillScreen()
		{
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0xA09BD0", Offset = "0xA08DD0", VA = "0x180A09BD0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|16_0()
		{
			return null;
		}

		// Token: 0x04004079 RID: 16505
		[Token(Token = "0x4004079")]
		public const float BILL_COST = 250f;

		// Token: 0x0400407B RID: 16507
		[Token(Token = "0x400407B")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400407C RID: 16508
		[Token(Token = "0x400407C")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x0400407D RID: 16509
		[Token(Token = "0x400407D")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup CanvasGroup;

		// Token: 0x0400407E RID: 16510
		[Token(Token = "0x400407E")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI PatientNameLabel;

		// Token: 0x0400407F RID: 16511
		[Token(Token = "0x400407F")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI BillNumberLabel;

		// Token: 0x04004080 RID: 16512
		[Token(Token = "0x4004080")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI PaidAmountLabel;

		// Token: 0x04004081 RID: 16513
		[Token(Token = "0x4004081")]
		[FieldOffset(Offset = "0x60")]
		private bool arrested;
	}
}
