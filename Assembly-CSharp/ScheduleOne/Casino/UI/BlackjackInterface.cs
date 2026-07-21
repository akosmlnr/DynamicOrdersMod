using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000828")]
		public BlackjackGameController CurrentGame
		{
			[Token(Token = "0x600327C")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600327D")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x76C1A0", Offset = "0x76B3A0", VA = "0x18076C1A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x76CA20", Offset = "0x76BC20", VA = "0x18076CA20")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x76D360", Offset = "0x76C560", VA = "0x18076D360")]
		public void Open(BlackjackGameController game)
		{
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x76C460", Offset = "0x76B660", VA = "0x18076C460")]
		public void Close()
		{
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003282")]
		[Address(RVA = "0x76C3E0", Offset = "0x76B5E0", VA = "0x18076C3E0")]
		private void BetSliderChanged(float newValue)
		{
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x76CE70", Offset = "0x76C070", VA = "0x18076CE70")]
		private float GetBetFromSliderValue(float sliderVal)
		{
			return 0f;
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x76D970", Offset = "0x76CB70", VA = "0x18076D970")]
		private void RefreshDisplayedBet()
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x76DA50", Offset = "0x76CC50", VA = "0x18076DA50")]
		private void RefreshReadyButton()
		{
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x76D120", Offset = "0x76C320", VA = "0x18076D120")]
		private void LocalPlayerReadyForInput()
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x76DC70", Offset = "0x76CE70", VA = "0x18076DC70")]
		private void ShowScores()
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x76CEC0", Offset = "0x76C0C0", VA = "0x18076CEC0")]
		private void HideScores()
		{
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x76CF00", Offset = "0x76C100", VA = "0x18076CF00")]
		private void HitClicked()
		{
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x76DCB0", Offset = "0x76CEB0", VA = "0x18076DCB0")]
		private void StandClicked()
		{
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x76D070", Offset = "0x76C270", VA = "0x18076D070")]
		private void LocalPlayerExitRound()
		{
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x76D950", Offset = "0x76CB50", VA = "0x18076D950")]
		private void ReadyButtonClicked()
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x76D1B0", Offset = "0x76C3B0", VA = "0x18076D1B0")]
		private void OnLocalPlayerBust()
		{
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x76D1D0", Offset = "0x76C3D0", VA = "0x18076D1D0")]
		private void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x76DE20", Offset = "0x76D020", VA = "0x18076DE20")]
		public BlackjackInterface()
		{
		}

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x400251A")]
		[FieldOffset(Offset = "0x38")]
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x0400251B RID: 9499
		[Token(Token = "0x400251B")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform BetContainer;

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x50")]
		public Slider BetSlider;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI BetAmount;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x60")]
		public Button ReadyButton;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform WaitingContainer;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI WaitingLabel;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI DealerScoreLabel;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI PlayerScoreLabel;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x90")]
		public Button HitButton;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x98")]
		public Button StandButton;

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0xA0")]
		public Animation InputContainerAnimation;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup InputContainerCanvasGroup;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0xB0")]
		public AnimationClip InputContainerFadeIn;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0xB8")]
		public AnimationClip InputContainerFadeOut;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform SelectionIndicator;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0xC8")]
		public Animation ScoresContainerAnimation;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0xD0")]
		public CanvasGroup ScoresContainerCanvasGroup;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI PositiveOutcomeLabel;

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI PayoutLabel;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onBust;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onBlackjack;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0xF8")]
		public UnityEvent onWin;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0x100")]
		public UnityEvent onLose;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0x108")]
		public UnityEvent onPush;
	}
}
