using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000D31 RID: 3377
	[Token(Token = "0x2000D31")]
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x0600622D RID: 25133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622D")]
		[Address(RVA = "0xA435C0", Offset = "0xA427C0", VA = "0x180A435C0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622E")]
		[Address(RVA = "0xA454E0", Offset = "0xA446E0", VA = "0x180A454E0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622F")]
		[Address(RVA = "0xA44520", Offset = "0xA43720", VA = "0x180A44520")]
		public void OpenShop(DeliveryShop shop)
		{
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006230")]
		[Address(RVA = "0xA43780", Offset = "0xA42980", VA = "0x180A43780")]
		public void CloseShop(DeliveryShop shop)
		{
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006231")]
		[Address(RVA = "0xA43D10", Offset = "0xA42F10", VA = "0x180A43D10")]
		private IEnumerator DoShopTransitionRoutine(float duration, int direction, List<RectTransform> panels, Action onComplete)
		{
			return null;
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006232")]
		[Address(RVA = "0xA43DD0", Offset = "0xA42FD0", VA = "0x180A43DD0", Slot = "10")]
		public override void Exit(ExitAction exit)
		{
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006233")]
		[Address(RVA = "0xA44F40", Offset = "0xA44140", VA = "0x180A44F40")]
		private void SetCanvasInteraction(CanvasGroup canvas, bool interactable)
		{
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006234")]
		[Address(RVA = "0xA45130", Offset = "0xA44330", VA = "0x180A45130", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006235")]
		[Address(RVA = "0xA442F0", Offset = "0xA434F0", VA = "0x180A442F0")]
		private void OnMinPass()
		{
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006236")]
		[Address(RVA = "0xA44960", Offset = "0xA43B60", VA = "0x180A44960")]
		public void RefreshContent(bool keepScrollPosition = true)
		{
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006237")]
		[Address(RVA = "0xA44430", Offset = "0xA43630", VA = "0x180A44430")]
		public void OnSubmitOrder(DeliveryShop shop)
		{
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006238")]
		[Address(RVA = "0xA44910", Offset = "0xA43B10", VA = "0x180A44910")]
		public void PlayOrderSubmittedAnim()
		{
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006239")]
		[Address(RVA = "0xA44E10", Offset = "0xA44010", VA = "0x180A44E10")]
		public void Reorder(DeliveryReceipt receipt)
		{
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x000184E0 File Offset: 0x000166E0
		[Token(Token = "0x600623A")]
		[Address(RVA = "0xA43650", Offset = "0xA42850", VA = "0x180A43650")]
		public bool CanReorder(DeliveryReceipt receipt, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x000184F8 File Offset: 0x000166F8
		[Token(Token = "0x600623B")]
		[Address(RVA = "0xA43FC0", Offset = "0xA431C0", VA = "0x180A43FC0")]
		public float GetDeliveryCost(DeliveryReceipt receipt)
		{
			return 0f;
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623C")]
		[Address(RVA = "0xA43980", Offset = "0xA42B80", VA = "0x180A43980")]
		private void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623D")]
		[Address(RVA = "0xA43B30", Offset = "0xA42D30", VA = "0x180A43B30")]
		private void DeliveryCompleted(DeliveryInstance instance)
		{
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623E")]
		[Address(RVA = "0xA45310", Offset = "0xA44510", VA = "0x180A45310")]
		private void SortStatusDisplays()
		{
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623F")]
		[Address(RVA = "0xA44BA0", Offset = "0xA43DA0", VA = "0x180A44BA0")]
		private void RefreshNoDeliveriesIndicator()
		{
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006240")]
		[Address(RVA = "0xA44A50", Offset = "0xA43C50", VA = "0x180A44A50")]
		public static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006241")]
		[Address(RVA = "0xA440B0", Offset = "0xA432B0", VA = "0x180A440B0")]
		public DeliveryShop GetShop(string shopName)
		{
			return null;
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006242")]
		[Address(RVA = "0xA44F70", Offset = "0xA44170", VA = "0x180A44F70")]
		public void SetIsAvailable(ShopInterface matchingShop, bool available)
		{
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006243")]
		[Address(RVA = "0xA444A0", Offset = "0xA436A0", VA = "0x180A444A0")]
		private void OnTabChange(int index)
		{
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006244")]
		[Address(RVA = "0xA461C0", Offset = "0xA453C0", VA = "0x180A461C0")]
		private void UpdatePastDeliveries()
		{
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x00018510 File Offset: 0x00016710
		[Token(Token = "0x6006245")]
		[Address(RVA = "0xA44190", Offset = "0xA43390", VA = "0x180A44190")]
		private bool IsValidReceipt(DeliveryReceipt receipt)
		{
			return default(bool);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006246")]
		[Address(RVA = "0xA44C10", Offset = "0xA43E10", VA = "0x180A44C10")]
		private void RefreshNotifications()
		{
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006247")]
		[Address(RVA = "0xA46520", Offset = "0xA45720", VA = "0x180A46520")]
		public DeliveryApp()
		{
		}

		// Token: 0x0400441E RID: 17438
		[Token(Token = "0x400441E")]
		[FieldOffset(Offset = "0x68")]
		private List<DeliveryShop> deliveryShops;

		// Token: 0x0400441F RID: 17439
		[Token(Token = "0x400441F")]
		[FieldOffset(Offset = "0x70")]
		public DeliveryStatusDisplay StatusDisplayPrefab;

		// Token: 0x04004420 RID: 17440
		[Token(Token = "0x4004420")]
		[FieldOffset(Offset = "0x78")]
		[Header("References")]
		public Animation OrderSubmittedAnim;

		// Token: 0x04004421 RID: 17441
		[Token(Token = "0x4004421")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController OrderSubmittedSound;

		// Token: 0x04004422 RID: 17442
		[Token(Token = "0x4004422")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform StatusDisplayContainer;

		// Token: 0x04004423 RID: 17443
		[Token(Token = "0x4004423")]
		[FieldOffset(Offset = "0x90")]
		public GameObject NoDeliveriesIndicator;

		// Token: 0x04004424 RID: 17444
		[Token(Token = "0x4004424")]
		[FieldOffset(Offset = "0x98")]
		public GameObject NoPastDeliveriesIndicator;

		// Token: 0x04004425 RID: 17445
		[Token(Token = "0x4004425")]
		[FieldOffset(Offset = "0xA0")]
		public ScrollRect MainScrollRect;

		// Token: 0x04004426 RID: 17446
		[Token(Token = "0x4004426")]
		[FieldOffset(Offset = "0xA8")]
		public LayoutGroup MainLayoutGroup;

		// Token: 0x04004427 RID: 17447
		[Token(Token = "0x4004427")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Header("Components")]
		private DeliveryReceiptDisplay _deliveryReceiptPrefab;

		// Token: 0x04004428 RID: 17448
		[Token(Token = "0x4004428")]
		[FieldOffset(Offset = "0xB8")]
		public RectTransform PastDeliveriesContainer;

		// Token: 0x04004429 RID: 17449
		[Token(Token = "0x4004429")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("References")]
		private TabController _tabController;

		// Token: 0x0400442A RID: 17450
		[Token(Token = "0x400442A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup shopListCanvas;

		// Token: 0x0400442B RID: 17451
		[Token(Token = "0x400442B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup orderCanvas;

		// Token: 0x0400442C RID: 17452
		[Token(Token = "0x400442C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<DeliveryApp.DeliveryShopElement> _shopElements;

		// Token: 0x0400442D RID: 17453
		[Token(Token = "0x400442D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Header("Settings")]
		private float shopPanelWidth;

		// Token: 0x0400442E RID: 17454
		[Token(Token = "0x400442E")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float shopTransitionDuration;

		// Token: 0x0400442F RID: 17455
		[Token(Token = "0x400442F")]
		[FieldOffset(Offset = "0xE8")]
		private List<DeliveryStatusDisplay> statusDisplays;

		// Token: 0x04004430 RID: 17456
		[Token(Token = "0x4004430")]
		[FieldOffset(Offset = "0xF0")]
		private DeliveryReceiptDisplay[] _pastDeliveries;

		// Token: 0x04004431 RID: 17457
		[Token(Token = "0x4004431")]
		[FieldOffset(Offset = "0xF8")]
		private bool started;

		// Token: 0x04004432 RID: 17458
		[Token(Token = "0x4004432")]
		[FieldOffset(Offset = "0x100")]
		private List<RectTransform> _shopPanels;

		// Token: 0x04004433 RID: 17459
		[Token(Token = "0x4004433")]
		[FieldOffset(Offset = "0x108")]
		private List<Vector2> _shopPanelInitialAnchors;

		// Token: 0x04004434 RID: 17460
		[Token(Token = "0x4004434")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine _shopTransitionCoroutine;

		// Token: 0x02000D32 RID: 3378
		[Token(Token = "0x2000D32")]
		[Serializable]
		public class DeliveryShopElement
		{
			// Token: 0x06006248 RID: 25160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006248")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public DeliveryShopElement()
			{
			}

			// Token: 0x04004435 RID: 17461
			[Token(Token = "0x4004435")]
			[FieldOffset(Offset = "0x10")]
			public DeliveryShop Shop;

			// Token: 0x04004436 RID: 17462
			[Token(Token = "0x4004436")]
			[FieldOffset(Offset = "0x18")]
			public Button Button;
		}
	}
}
