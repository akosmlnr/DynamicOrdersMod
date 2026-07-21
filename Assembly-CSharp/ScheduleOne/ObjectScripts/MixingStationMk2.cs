using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009B1 RID: 2481
	[Token(Token = "0x20009B1")]
	public class MixingStationMk2 : MixingStation
	{
		// Token: 0x0600456D RID: 17773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x8A2AE0", Offset = "0x8A1CE0", VA = "0x1808A2AE0", Slot = "137")]
		protected override void OnTimePass(int minutes)
		{
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x8A2970", Offset = "0x8A1B70", VA = "0x1808A2970", Slot = "140")]
		public override void MixingStart()
		{
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x8A2840", Offset = "0x8A1A40", VA = "0x1808A2840", Slot = "141")]
		public override void MixingDone()
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x8A2630", Offset = "0x8A1830", VA = "0x1808A2630")]
		private void EnableScreen()
		{
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x8A2B00", Offset = "0x8A1D00", VA = "0x1808A2B00")]
		private void UpdateScreen()
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x8A2600", Offset = "0x8A1800", VA = "0x1808A2600")]
		private void DisableScreen()
		{
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "139")]
		protected override void SetMixerToLowered()
		{
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x8A2BB0", Offset = "0x8A1DB0", VA = "0x1808A2BB0")]
		public MixingStationMk2()
		{
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x8A2AC0", Offset = "0x8A1CC0", VA = "0x1808A2AC0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x8A2A10", Offset = "0x8A1C10", VA = "0x1808A2A10", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x8A2590", Offset = "0x8A1790", VA = "0x1808A2590", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x3C8")]
		public Animation Animation;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x3D8")]
		public Image OutputIcon;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x3E0")]
		public RectTransform QuestionMark;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x3E8")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x3F0")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x3F8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted;

		// Token: 0x040031AF RID: 12719
		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x3F9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted;
	}
}
