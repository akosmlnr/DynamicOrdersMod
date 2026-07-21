using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.ATM
{
	// Token: 0x02000DEA RID: 3562
	[Token(Token = "0x2000DEA")]
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x00018E70 File Offset: 0x00017070
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E82")]
		public bool isOpen
		{
			[Token(Token = "0x6006618")]
			[Address(RVA = "0x521B00", Offset = "0x520D00", VA = "0x180521B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006619")]
			[Address(RVA = "0xA895D0", Offset = "0xA887D0", VA = "0x180A895D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x00018E88 File Offset: 0x00017088
		[Token(Token = "0x17000E83")]
		private float relevantBalance
		{
			[Token(Token = "0x600661A")]
			[Address(RVA = "0xA89490", Offset = "0xA88690", VA = "0x180A89490")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x00018EA0 File Offset: 0x000170A0
		[Token(Token = "0x17000E84")]
		private static float remainingAllowedDeposit
		{
			[Token(Token = "0x600661B")]
			[Address(RVA = "0xA89570", Offset = "0xA88770", VA = "0x180A89570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661C")]
		[Address(RVA = "0xA871A0", Offset = "0xA863A0", VA = "0x180A871A0")]
		private void Awake()
		{
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661D")]
		[Address(RVA = "0xA87A30", Offset = "0xA86C30", VA = "0x180A87A30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661E")]
		[Address(RVA = "0xA883B0", Offset = "0xA875B0", VA = "0x180A883B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661F")]
		[Address(RVA = "0xA87B70", Offset = "0xA86D70", VA = "0x180A87B70")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006620")]
		[Address(RVA = "0xA88A80", Offset = "0xA87C80", VA = "0x180A88A80", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006621")]
		[Address(RVA = "0xA878D0", Offset = "0xA86AD0", VA = "0x180A878D0", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006622")]
		[Address(RVA = "0xA87FC0", Offset = "0xA871C0", VA = "0x180A87FC0", Slot = "7")]
		public virtual void SetIsOpen(bool o)
		{
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006623")]
		[Address(RVA = "0xA87600", Offset = "0xA86800", VA = "0x180A87600", Slot = "8")]
		public virtual void Exit(ExitAction action)
		{
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006624")]
		[Address(RVA = "0xA87C90", Offset = "0xA86E90", VA = "0x180A87C90")]
		public void SetActiveScreen(RectTransform screen)
		{
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006625")]
		[Address(RVA = "0xA873E0", Offset = "0xA865E0", VA = "0x180A873E0")]
		private void DefaultAmountSelection()
		{
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006626")]
		[Address(RVA = "0xA87590", Offset = "0xA86790", VA = "0x180A87590")]
		public void DepositButtonPressed()
		{
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006627")]
		[Address(RVA = "0xA891D0", Offset = "0xA883D0", VA = "0x180A891D0")]
		public void WithdrawButtonPressed()
		{
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006628")]
		[Address(RVA = "0xA873B0", Offset = "0xA865B0", VA = "0x180A873B0")]
		public void CancelAmountSelection()
		{
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006629")]
		[Address(RVA = "0xA87120", Offset = "0xA86320", VA = "0x180A87120")]
		public void AmountSelected(int amountIndex)
		{
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662A")]
		[Address(RVA = "0xA881F0", Offset = "0xA873F0", VA = "0x180A881F0")]
		private void SetSelectedAmount(float amount)
		{
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00018EB8 File Offset: 0x000170B8
		[Token(Token = "0x600662B")]
		[Address(RVA = "0xA87760", Offset = "0xA86960", VA = "0x180A87760")]
		public static float GetAmountFromIndex(int index, bool depositing)
		{
			return 0f;
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662C")]
		[Address(RVA = "0xA88760", Offset = "0xA87960", VA = "0x180A88760")]
		private void UpdateAvailableAmounts()
		{
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662D")]
		[Address(RVA = "0xA87080", Offset = "0xA86280", VA = "0x180A87080")]
		public void AmountConfirmed()
		{
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662E")]
		[Address(RVA = "0xA873C0", Offset = "0xA865C0", VA = "0x180A873C0")]
		public void ChangeAmount(float amount)
		{
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600662F")]
		[Address(RVA = "0xA87C00", Offset = "0xA86E00", VA = "0x180A87C00")]
		protected IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			return null;
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006630")]
		[Address(RVA = "0x6C6630", Offset = "0x6C5830", VA = "0x1806C6630")]
		public void DoneButtonPressed()
		{
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006631")]
		[Address(RVA = "0xA873B0", Offset = "0xA865B0", VA = "0x180A873B0")]
		public void ReturnToMenuButtonPressed()
		{
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006632")]
		[Address(RVA = "0xA89400", Offset = "0xA88600", VA = "0x180A89400")]
		public ATMInterface()
		{
		}

		// Token: 0x040047F2 RID: 18418
		[Token(Token = "0x40047F2")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x040047F3 RID: 18419
		[Token(Token = "0x40047F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected ATM atm;

		// Token: 0x040047F4 RID: 18420
		[Token(Token = "0x40047F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected AudioSourceController CompleteSound;

		// Token: 0x040047F5 RID: 18421
		[Token(Token = "0x40047F5")]
		[FieldOffset(Offset = "0x38")]
		[Header("Menu")]
		[SerializeField]
		protected RectTransform menuScreen;

		// Token: 0x040047F6 RID: 18422
		[Token(Token = "0x40047F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Text menu_TitleText;

		// Token: 0x040047F7 RID: 18423
		[Token(Token = "0x40047F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Button menu_DepositButton;

		// Token: 0x040047F8 RID: 18424
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Button menu_WithdrawButton;

		// Token: 0x040047F9 RID: 18425
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Top bar")]
		protected Text depositLimitText;

		// Token: 0x040047FA RID: 18426
		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text onlineBalanceText;

		// Token: 0x040047FB RID: 18427
		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Text cleanCashText;

		// Token: 0x040047FC RID: 18428
		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected RectTransform depositLimitContainer;

		// Token: 0x040047FD RID: 18429
		[Token(Token = "0x40047FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Amount screen")]
		protected RectTransform amountSelectorScreen;

		// Token: 0x040047FE RID: 18430
		[Token(Token = "0x40047FE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Text amountSelectorTitle;

		// Token: 0x040047FF RID: 18431
		[Token(Token = "0x40047FF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected List<Button> amountButtons;

		// Token: 0x04004800 RID: 18432
		[Token(Token = "0x4004800")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected Text amountLabelText;

		// Token: 0x04004801 RID: 18433
		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected RectTransform amountBackground;

		// Token: 0x04004802 RID: 18434
		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected RectTransform selectedButtonIndicator;

		// Token: 0x04004803 RID: 18435
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected Button confirmAmountButton;

		// Token: 0x04004804 RID: 18436
		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected Text confirmButtonText;

		// Token: 0x04004805 RID: 18437
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Header("Processing screen")]
		protected RectTransform processingScreen;

		// Token: 0x04004806 RID: 18438
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected RectTransform processingScreenIndicator;

		// Token: 0x04004807 RID: 18439
		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Header("Success screen")]
		protected RectTransform successScreen;

		// Token: 0x04004808 RID: 18440
		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected Text successScreenSubtitle;

		// Token: 0x04004809 RID: 18441
		[Token(Token = "0x4004809")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected Button doneButton;

		// Token: 0x0400480A RID: 18442
		[Token(Token = "0x400480A")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Custom UI")]
		[SerializeField]
		protected UIScreen UIScreen;

		// Token: 0x0400480B RID: 18443
		[Token(Token = "0x400480B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected UIContentPanel MenuPanel;

		// Token: 0x0400480C RID: 18444
		[Token(Token = "0x400480C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected UIContentPanel AmountSelectorPanel;

		// Token: 0x0400480D RID: 18445
		[Token(Token = "0x400480D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		protected UIContentPanel SuccessPanel;

		// Token: 0x0400480F RID: 18447
		[Token(Token = "0x400480F")]
		[FieldOffset(Offset = "0x108")]
		private RectTransform activeScreen;

		// Token: 0x04004810 RID: 18448
		[Token(Token = "0x4004810")]
		[FieldOffset(Offset = "0x0")]
		public static int[] amounts;

		// Token: 0x04004811 RID: 18449
		[Token(Token = "0x4004811")]
		[FieldOffset(Offset = "0x110")]
		private bool depositing;

		// Token: 0x04004812 RID: 18450
		[Token(Token = "0x4004812")]
		[FieldOffset(Offset = "0x114")]
		private int selectedAmountIndex;

		// Token: 0x04004813 RID: 18451
		[Token(Token = "0x4004813")]
		[FieldOffset(Offset = "0x118")]
		private float selectedAmount;
	}
}
