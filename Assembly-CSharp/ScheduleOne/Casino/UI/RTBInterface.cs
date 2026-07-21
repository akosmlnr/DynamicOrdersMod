using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000829")]
		public RTBGameController CurrentGame
		{
			[Token(Token = "0x6003295")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003296")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003297")]
		[Address(RVA = "0x77B040", Offset = "0x77A240", VA = "0x18077B040", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x77BA80", Offset = "0x77AC80", VA = "0x18077BA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x77BDC0", Offset = "0x77AFC0", VA = "0x18077BDC0")]
		private string GetStatusText()
		{
			return null;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x77C090", Offset = "0x77B290", VA = "0x18077C090")]
		public void Open(RTBGameController game)
		{
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x77B3D0", Offset = "0x77A5D0", VA = "0x18077B3D0")]
		public void Close()
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x77B330", Offset = "0x77A530", VA = "0x18077B330")]
		private void BetSliderChanged(float newValue)
		{
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x77BD70", Offset = "0x77AF70", VA = "0x18077BD70")]
		private float GetBetFromSliderValue(float sliderVal)
		{
			return 0f;
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329E")]
		[Address(RVA = "0x77CBC0", Offset = "0x77BDC0", VA = "0x18077CBC0")]
		private void RefreshDisplayedBet()
		{
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329F")]
		[Address(RVA = "0x77CCA0", Offset = "0x77BEA0", VA = "0x18077CCA0")]
		private void RefreshReadyButton()
		{
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x77C700", Offset = "0x77B900", VA = "0x18077C700")]
		private void QuestionReady(string question, string[] answers)
		{
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x77AF40", Offset = "0x77A140", VA = "0x18077AF40")]
		private void AnswerButtonClicked(int index)
		{
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x77BC60", Offset = "0x77AE60", VA = "0x18077BC60")]
		private void ForfeitClicked()
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x77C6A0", Offset = "0x77B8A0", VA = "0x18077C6A0")]
		private void QuestionDone()
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x77C010", Offset = "0x77B210", VA = "0x18077C010")]
		private void LocalPlayerExitRound()
		{
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x77B990", Offset = "0x77AB90", VA = "0x18077B990")]
		private void Correct()
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x77BFF0", Offset = "0x77B1F0", VA = "0x18077BFF0")]
		private void Incorrect()
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x77CA00", Offset = "0x77BC00", VA = "0x18077CA00")]
		private void ReadyButtonClicked()
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x77CF30", Offset = "0x77C130", VA = "0x18077CF30")]
		public RTBInterface()
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x77CEC0", Offset = "0x77C0C0", VA = "0x18077CEC0")]
		[CompilerGenerated]
		private IEnumerator <QuestionReady>g__Routine|38_0()
		{
			return null;
		}

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x38")]
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI StatusLabel;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform BetContainer;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x58")]
		public Slider BetSlider;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI BetAmount;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x68")]
		public Button ReadyButton;

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI WinningsMultiplierLabel;

		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		[FieldOffset(Offset = "0x80")]
		[Header("Question and answers")]
		public RectTransform QuestionContainer;

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI QuestionLabel;

		// Token: 0x04002545 RID: 9541
		[Token(Token = "0x4002545")]
		[FieldOffset(Offset = "0x90")]
		public Slider TimerSlider;

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x98")]
		public Button[] AnswerButtons;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI[] AnswerLabels;

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0xA8")]
		public Button ForfeitButton;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI ForfeitLabel;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0xB8")]
		public Animation QuestionContainerAnimation;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0xC0")]
		public AnimationClip QuestionContainerFadeIn;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationClip QuestionContainerFadeOut;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0xD0")]
		public CanvasGroup QuestionCanvasGroup;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0xD8")]
		public RectTransform SelectionIndicator;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onCorrect;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onFinalCorrect;

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onIncorrect;
	}
}
