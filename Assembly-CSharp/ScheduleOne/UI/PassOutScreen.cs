using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x00017A48 File Offset: 0x00015C48
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA0")]
		public bool isOpen
		{
			[Token(Token = "0x6005E11")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005E12")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E13")]
		[Address(RVA = "0xA0A810", Offset = "0xA09A10", VA = "0x180A0A810", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E14")]
		[Address(RVA = "0xA0AA90", Offset = "0xA09C90", VA = "0x180A0AA90")]
		private void Continue()
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E15")]
		[Address(RVA = "0xA0AB10", Offset = "0xA09D10", VA = "0x180A0AB10")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xA0AB20", Offset = "0xA09D20", VA = "0x180A0AB20")]
		public void Open()
		{
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xA0A890", Offset = "0xA09A90", VA = "0x180A0A890")]
		public void Close()
		{
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xA0AE00", Offset = "0xA0A000", VA = "0x180A0AE00")]
		public PassOutScreen()
		{
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0xA0AD20", Offset = "0xA09F20", VA = "0x180A0AD20")]
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|14_0()
		{
			return null;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0xA0AD90", Offset = "0xA09F90", VA = "0x180A0AD90")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|16_0()
		{
			return null;
		}

		// Token: 0x0400408B RID: 16523
		[Token(Token = "0x400408B")]
		public const float CASH_LOSS_MIN = 50f;

		// Token: 0x0400408C RID: 16524
		[Token(Token = "0x400408C")]
		public const float CASH_LOSS_MAX = 500f;

		// Token: 0x0400408D RID: 16525
		[Token(Token = "0x400408D")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400408E RID: 16526
		[Token(Token = "0x400408E")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup Group;

		// Token: 0x0400408F RID: 16527
		[Token(Token = "0x400408F")]
		[FieldOffset(Offset = "0x40")]
		public Transform RecoveryPointsContainer;

		// Token: 0x04004090 RID: 16528
		[Token(Token = "0x4004090")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x04004091 RID: 16529
		[Token(Token = "0x4004091")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI ContextLabel;

		// Token: 0x04004092 RID: 16530
		[Token(Token = "0x4004092")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x04004093 RID: 16531
		[Token(Token = "0x4004093")]
		[FieldOffset(Offset = "0x60")]
		private float cashLoss;
	}
}
