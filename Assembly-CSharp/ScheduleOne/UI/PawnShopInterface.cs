using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C76 RID: 3190
	[Token(Token = "0x2000C76")]
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06005D54 RID: 23892 RVA: 0x00017790 File Offset: 0x00015990
		// (set) Token: 0x06005D55 RID: 23893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D82")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D54")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D55")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06005D56 RID: 23894 RVA: 0x000177A8 File Offset: 0x000159A8
		// (set) Token: 0x06005D57 RID: 23895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D83")]
		public float SelectedPayment
		{
			[Token(Token = "0x6005D56")]
			[Address(RVA = "0x4C20F0", Offset = "0x4C12F0", VA = "0x1804C20F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005D57")]
			[Address(RVA = "0x6B6F20", Offset = "0x6B6120", VA = "0x1806B6F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x000177C0 File Offset: 0x000159C0
		// (set) Token: 0x06005D59 RID: 23897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D84")]
		public float NPCAnger
		{
			[Token(Token = "0x6005D58")]
			[Address(RVA = "0x4B3A40", Offset = "0x4B2C40", VA = "0x1804B3A40")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005D59")]
			[Address(RVA = "0x7C2F60", Offset = "0x7C2160", VA = "0x1807C2F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x9E6B70", Offset = "0x9E5D70", VA = "0x1809E6B70", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x9E93B0", Offset = "0x9E85B0", VA = "0x1809E93B0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x9E83E0", Offset = "0x9E75E0", VA = "0x1809E83E0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x9E8620", Offset = "0x9E7820", VA = "0x1809E8620")]
		public void Open()
		{
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x9E7460", Offset = "0x9E6660", VA = "0x1809E7460")]
		public void Close(bool returnItemsToPlayer)
		{
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x9E7D10", Offset = "0x9E6F10", VA = "0x1809E7D10")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x9E8610", Offset = "0x9E7810", VA = "0x1809E8610")]
		private void OnMinPass()
		{
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x9E83D0", Offset = "0x9E75D0", VA = "0x1809E83D0")]
		private void OnDayPass()
		{
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x9E9C20", Offset = "0x9E8E20", VA = "0x1809E9C20")]
		private void Update()
		{
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x9E8250", Offset = "0x9E7450", VA = "0x1809E8250")]
		private List<ItemInstance> GetPawnItems()
		{
			return null;
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x9E8AD0", Offset = "0x9E7CD0", VA = "0x1809E8AD0")]
		private void PawnSlotChanged()
		{
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x9E9900", Offset = "0x9E8B00", VA = "0x1809E9900")]
		private void UpdateValueRangeLabels()
		{
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x9E9300", Offset = "0x9E8500", VA = "0x1809E9300")]
		public void StartButtonPressed()
		{
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x9E9300", Offset = "0x9E8500", VA = "0x1809E9300")]
		private void StartNegotiation()
		{
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x9E8B30", Offset = "0x9E7D30", VA = "0x1809E8B30")]
		private void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x6005D69")]
		[Address(RVA = "0x9E79B0", Offset = "0x9E6BB0", VA = "0x1809E79B0")]
		private PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			return PawnShopInterface.EShopResponse.Accept;
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x9E7930", Offset = "0x9E6B30", VA = "0x1809E7930")]
		private void EndNegotiation()
		{
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x9E8AE0", Offset = "0x9E7CE0", VA = "0x1809E8AE0")]
		public void PaymentSubmitted(string value)
		{
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x9E7450", Offset = "0x9E6650", VA = "0x1809E7450")]
		public void ChangePayment(float change)
		{
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x9E9200", Offset = "0x9E8400", VA = "0x1809E9200")]
		public void SetSelectedPayment(float amount)
		{
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0x9E9140", Offset = "0x9E8340", VA = "0x1809E9140")]
		public void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x9E6B40", Offset = "0x9E5D40", VA = "0x1809E6B40")]
		public void AcceptOrCounter()
		{
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x9E7080", Offset = "0x9E6280", VA = "0x1809E7080")]
		public void Cancel()
		{
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0x9E7090", Offset = "0x9E6290", VA = "0x1809E7090")]
		private void ChangeAnger(float change)
		{
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x9E8F20", Offset = "0x9E8120", VA = "0x1809E8F20")]
		private void SetAngeredToday(bool angered)
		{
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0x9E97E0", Offset = "0x9E89E0", VA = "0x1809E97E0")]
		private void Think()
		{
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D74")]
		[Address(RVA = "0x9E8FF0", Offset = "0x9E81F0", VA = "0x1809E8FF0")]
		private void SetOffer(float amount)
		{
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D75")]
		[Address(RVA = "0x9E7D70", Offset = "0x9E6F70", VA = "0x1809E7D70")]
		private void FinalizeDeal(float amount)
		{
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x6005D76")]
		[Address(RVA = "0x9E8330", Offset = "0x9E7530", VA = "0x1809E8330")]
		private float GetTotalValue()
		{
			return 0f;
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x00017808 File Offset: 0x00015A08
		[Token(Token = "0x6005D77")]
		[Address(RVA = "0x9E8DD0", Offset = "0x9E7FD0", VA = "0x1809E8DD0")]
		private float RoundOffer(float offer)
		{
			return 0f;
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x6005D78")]
		[Address(RVA = "0x9E7EA0", Offset = "0x9E70A0", VA = "0x1809E7EA0")]
		private float GetItemValue(ItemInstance item)
		{
			return 0f;
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D79")]
		[Address(RVA = "0x9E8D20", Offset = "0x9E7F20", VA = "0x1809E8D20")]
		private void ResetUI()
		{
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D7A")]
		[Address(RVA = "0x9E9F20", Offset = "0x9E9120", VA = "0x1809E9F20")]
		public PawnShopInterface()
		{
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D7B")]
		[Address(RVA = "0x9E9890", Offset = "0x9E8A90", VA = "0x1809E9890")]
		[CompilerGenerated]
		private IEnumerator <StartNegotiation>g__NegotiationRoutine|67_0()
		{
			return null;
		}

		// Token: 0x04003FCA RID: 16330
		[Token(Token = "0x4003FCA")]
		public const float PAYMENT_MIN = 1f;

		// Token: 0x04003FCB RID: 16331
		[Token(Token = "0x4003FCB")]
		public const float PAYMENT_MAX = 999999f;

		// Token: 0x04003FCC RID: 16332
		[Token(Token = "0x4003FCC")]
		public const float THINK_TIME = 0.75f;

		// Token: 0x04003FCD RID: 16333
		[Token(Token = "0x4003FCD")]
		public const float MIN_VALUE_MULTIPLIER = 0.5f;

		// Token: 0x04003FCE RID: 16334
		[Token(Token = "0x4003FCE")]
		public const float MAX_VALUE_MULTIPLIER = 2f;

		// Token: 0x04003FCF RID: 16335
		[Token(Token = "0x4003FCF")]
		public const int PAWN_SLOT_COUNT = 5;

		// Token: 0x04003FD1 RID: 16337
		[Token(Token = "0x4003FD1")]
		[FieldOffset(Offset = "0x2C")]
		private PawnShopInterface.EState CurrentState;

		// Token: 0x04003FD2 RID: 16338
		[Token(Token = "0x4003FD2")]
		[FieldOffset(Offset = "0x30")]
		private PawnShopInterface.EPlayerResponse PlayerResponse;

		// Token: 0x04003FD3 RID: 16339
		[Token(Token = "0x4003FD3")]
		[FieldOffset(Offset = "0x34")]
		private int CurrentNegotiationRound;

		// Token: 0x04003FD4 RID: 16340
		[Token(Token = "0x4003FD4")]
		[FieldOffset(Offset = "0x38")]
		private float InitialShopOffer;

		// Token: 0x04003FD5 RID: 16341
		[Token(Token = "0x4003FD5")]
		[FieldOffset(Offset = "0x3C")]
		private float LastShopOffer;

		// Token: 0x04003FD6 RID: 16342
		[Token(Token = "0x4003FD6")]
		[FieldOffset(Offset = "0x40")]
		private float LastRefusedAmount;

		// Token: 0x04003FD7 RID: 16343
		[Token(Token = "0x4003FD7")]
		[FieldOffset(Offset = "0x48")]
		public NPC PawnShopNPC;

		// Token: 0x04003FDA RID: 16346
		[Token(Token = "0x4003FDA")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve RandomCurve;

		// Token: 0x04003FDB RID: 16347
		[Token(Token = "0x4003FDB")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003FDC RID: 16348
		[Token(Token = "0x4003FDC")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform Container;

		// Token: 0x04003FDD RID: 16349
		[Token(Token = "0x4003FDD")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI[] Slots;

		// Token: 0x04003FDE RID: 16350
		[Token(Token = "0x4003FDE")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] ValueRangeLabels;

		// Token: 0x04003FDF RID: 16351
		[Token(Token = "0x4003FDF")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI TotalValueLabel;

		// Token: 0x04003FE0 RID: 16352
		[Token(Token = "0x4003FE0")]
		[FieldOffset(Offset = "0x88")]
		public Button StartButton;

		// Token: 0x04003FE1 RID: 16353
		[Token(Token = "0x4003FE1")]
		[FieldOffset(Offset = "0x90")]
		public Animation Step1Animation;

		// Token: 0x04003FE2 RID: 16354
		[Token(Token = "0x4003FE2")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup Step1CanvasGroup;

		// Token: 0x04003FE3 RID: 16355
		[Token(Token = "0x4003FE3")]
		[FieldOffset(Offset = "0xA0")]
		public Animation Step2Animation;

		// Token: 0x04003FE4 RID: 16356
		[Token(Token = "0x4003FE4")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup Step2CanvasGroup;

		// Token: 0x04003FE5 RID: 16357
		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0xB0")]
		public AnimationClip FadeInAnim;

		// Token: 0x04003FE6 RID: 16358
		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0xB8")]
		public AnimationClip FadeOutAnim;

		// Token: 0x04003FE7 RID: 16359
		[Token(Token = "0x4003FE7")]
		[FieldOffset(Offset = "0xC0")]
		public TMP_InputField OfferInputField;

		// Token: 0x04003FE8 RID: 16360
		[Token(Token = "0x4003FE8")]
		[FieldOffset(Offset = "0xC8")]
		public Slider AngerSlider;

		// Token: 0x04003FE9 RID: 16361
		[Token(Token = "0x4003FE9")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI AcceptCounterButtonLabel;

		// Token: 0x04003FEA RID: 16362
		[Token(Token = "0x4003FEA")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Settings")]
		public string[] OfferLines;

		// Token: 0x04003FEB RID: 16363
		[Token(Token = "0x4003FEB")]
		[FieldOffset(Offset = "0xE0")]
		public string[] ThinkLines;

		// Token: 0x04003FEC RID: 16364
		[Token(Token = "0x4003FEC")]
		[FieldOffset(Offset = "0xE8")]
		public string[] AcceptLines;

		// Token: 0x04003FED RID: 16365
		[Token(Token = "0x4003FED")]
		[FieldOffset(Offset = "0xF0")]
		public string[] CounterLines;

		// Token: 0x04003FEE RID: 16366
		[Token(Token = "0x4003FEE")]
		[FieldOffset(Offset = "0xF8")]
		public string[] RefusalLines;

		// Token: 0x04003FEF RID: 16367
		[Token(Token = "0x4003FEF")]
		[FieldOffset(Offset = "0x100")]
		public string[] DealFinalizedLines;

		// Token: 0x04003FF0 RID: 16368
		[Token(Token = "0x4003FF0")]
		[FieldOffset(Offset = "0x108")]
		public string[] AngeredLines;

		// Token: 0x04003FF1 RID: 16369
		[Token(Token = "0x4003FF1")]
		[FieldOffset(Offset = "0x110")]
		public string[] CrashOutLines;

		// Token: 0x04003FF2 RID: 16370
		[Token(Token = "0x4003FF2")]
		[FieldOffset(Offset = "0x118")]
		private ItemSlot[] PawnSlots;

		// Token: 0x04003FF3 RID: 16371
		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x120")]
		private Coroutine routine;

		// Token: 0x02000C77 RID: 3191
		[Token(Token = "0x2000C77")]
		public enum EState
		{
			// Token: 0x04003FF5 RID: 16373
			[Token(Token = "0x4003FF5")]
			WaitingForOffer,
			// Token: 0x04003FF6 RID: 16374
			[Token(Token = "0x4003FF6")]
			Negotiating
		}

		// Token: 0x02000C78 RID: 3192
		[Token(Token = "0x2000C78")]
		public enum EPlayerResponse
		{
			// Token: 0x04003FF8 RID: 16376
			[Token(Token = "0x4003FF8")]
			None,
			// Token: 0x04003FF9 RID: 16377
			[Token(Token = "0x4003FF9")]
			Accept,
			// Token: 0x04003FFA RID: 16378
			[Token(Token = "0x4003FFA")]
			Counter,
			// Token: 0x04003FFB RID: 16379
			[Token(Token = "0x4003FFB")]
			Cancel
		}

		// Token: 0x02000C79 RID: 3193
		[Token(Token = "0x2000C79")]
		public enum EShopResponse
		{
			// Token: 0x04003FFD RID: 16381
			[Token(Token = "0x4003FFD")]
			Accept,
			// Token: 0x04003FFE RID: 16382
			[Token(Token = "0x4003FFE")]
			Counter,
			// Token: 0x04003FFF RID: 16383
			[Token(Token = "0x4003FFF")]
			Refusal
		}
	}
}
