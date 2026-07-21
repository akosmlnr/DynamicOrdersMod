using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x00018FA8 File Offset: 0x000171A8
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8E")]
		public bool DraggingEnabled
		{
			[Token(Token = "0x600669C")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600669D")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8F")]
		public ItemSlotUI HoveredSlot
		{
			[Token(Token = "0x600669E")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600669F")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x00018FC0 File Offset: 0x000171C0
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E90")]
		public bool QuickMoveEnabled
		{
			[Token(Token = "0x60066A0")]
			[Address(RVA = "0x7B13B0", Offset = "0x7B05B0", VA = "0x1807B13B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60066A1")]
			[Address(RVA = "0xA38080", Offset = "0xA37280", VA = "0x180A38080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A2")]
		[Address(RVA = "0xA96520", Offset = "0xA95720", VA = "0x180A96520", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A3")]
		[Address(RVA = "0xA98CB0", Offset = "0xA97EB0", VA = "0x180A98CB0")]
		private void OnInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A4")]
		[Address(RVA = "0xA96CE0", Offset = "0xA95EE0", VA = "0x180A96CE0")]
		public void ControllerHighlightSlot(ItemSlotUI itemSlot)
		{
		}

		// Token: 0x060066A5 RID: 26277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A5")]
		[Address(RVA = "0xA96E70", Offset = "0xA96070", VA = "0x180A96E70")]
		public void ControllerToggleTooltip()
		{
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A6")]
		[Address(RVA = "0xA96C30", Offset = "0xA95E30", VA = "0x180A96C30")]
		public void ControllerGrabAllSlot()
		{
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A7")]
		[Address(RVA = "0xA96D90", Offset = "0xA95F90", VA = "0x180A96D90")]
		public void ControllerQuickMoveSlot()
		{
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A8")]
		[Address(RVA = "0xA96910", Offset = "0xA95B10", VA = "0x180A96910")]
		public void ControllerDragAddQuantity()
		{
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A9")]
		[Address(RVA = "0xA96AA0", Offset = "0xA95CA0", VA = "0x180A96AA0")]
		public void ControllerDragSubtractQuantity()
		{
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0xA96840", Offset = "0xA95A40", VA = "0x180A96840")]
		public void ControllerDiscardSlot()
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0xA9A410", Offset = "0xA99610", VA = "0x180A9A410")]
		private void TryOpenInfoPanel(ItemSlotUI itemSlot)
		{
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0xA9A3E0", Offset = "0xA995E0", VA = "0x180A9A3E0")]
		private void TryCloseInfoPanel()
		{
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0xA9A850", Offset = "0xA99A50", VA = "0x180A9A850")]
		private void UpdateControllerTooltip()
		{
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0xA9A8F0", Offset = "0xA99AF0", VA = "0x180A9A8F0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0xA96410", Offset = "0xA95610", VA = "0x180A96410")]
		public void AddRaycaster(GraphicRaycaster raycaster)
		{
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0xA98A40", Offset = "0xA97C40", VA = "0x180A98A40", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B1")]
		[Address(RVA = "0xA9A5E0", Offset = "0xA997E0", VA = "0x180A9A5E0")]
		private void UpdateCashDragSelectorUI()
		{
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B2")]
		[Address(RVA = "0xA9A4B0", Offset = "0xA996B0", VA = "0x180A9A4B0")]
		private void UpdateCashDragAmount(CashInstance instance)
		{
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B3")]
		[Address(RVA = "0xA96280", Offset = "0xA95480", VA = "0x180A96280")]
		private void AddCashAmount(CashInstance instance, bool wrapAround = false)
		{
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0xA9A240", Offset = "0xA99440", VA = "0x180A9A240")]
		private void SubtractCashAmount(CashInstance instance, bool wrapAround = false)
		{
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0xA99030", Offset = "0xA98230", VA = "0x180A99030")]
		public void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B6")]
		[Address(RVA = "0xA96F80", Offset = "0xA96180", VA = "0x180A96F80")]
		public void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0xA98780", Offset = "0xA97980", VA = "0x180A98780")]
		private List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			return null;
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0xA96F70", Offset = "0xA96170", VA = "0x180A96F70")]
		public void DisableQuickMove()
		{
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0xA983A0", Offset = "0xA975A0", VA = "0x180A983A0")]
		private ItemSlotUI GetHoveredItemSlot()
		{
			return null;
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0xA98040", Offset = "0xA97240", VA = "0x180A98040")]
		private ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			return null;
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0xA991B0", Offset = "0xA983B0", VA = "0x180A991B0")]
		private void SlotClicked(ItemSlotUI ui)
		{
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0xA99A10", Offset = "0xA98C10", VA = "0x180A99A10")]
		private void StartDragCash()
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0xA97900", Offset = "0xA96B00", VA = "0x180A97900")]
		private void EndDrag()
		{
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0xA98D10", Offset = "0xA97F10", VA = "0x180A98D10")]
		private void SetDraggedAmount(int amount)
		{
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0xA970C0", Offset = "0xA962C0", VA = "0x180A970C0")]
		private void EndCashDrag()
		{
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00018FD8 File Offset: 0x000171D8
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0xA967A0", Offset = "0xA959A0", VA = "0x180A967A0")]
		public bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			return default(bool);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00018FF0 File Offset: 0x000171F0
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0xA966E0", Offset = "0xA958E0", VA = "0x180A966E0")]
		public bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			return default(bool);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066C2")]
		[Address(RVA = "0xA9B0F0", Offset = "0xA9A2F0", VA = "0x180A9B0F0")]
		public ItemUIManager()
		{
		}

		// Token: 0x0400486A RID: 18538
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] CASH_DRAG_AMOUNTS;

		// Token: 0x0400486B RID: 18539
		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float[] CASH_DRAG_THRESHOLDS;

		// Token: 0x0400486F RID: 18543
		[Token(Token = "0x400486F")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004870 RID: 18544
		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform CashDragAmountContainer;

		// Token: 0x04004871 RID: 18545
		[Token(Token = "0x4004871")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform InputsContainer;

		// Token: 0x04004872 RID: 18546
		[Token(Token = "0x4004872")]
		[FieldOffset(Offset = "0x58")]
		public ItemInfoPanel InfoPanel;

		// Token: 0x04004873 RID: 18547
		[Token(Token = "0x4004873")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform ItemQuantityPrompt;

		// Token: 0x04004874 RID: 18548
		[Token(Token = "0x4004874")]
		[FieldOffset(Offset = "0x68")]
		public FilterConfigPanel FilterConfigPanel;

		// Token: 0x04004875 RID: 18549
		[Token(Token = "0x4004875")]
		[FieldOffset(Offset = "0x70")]
		[Header("Prefabs")]
		public ItemSlotUI ItemSlotUIPrefab;

		// Token: 0x04004876 RID: 18550
		[Token(Token = "0x4004876")]
		[FieldOffset(Offset = "0x78")]
		public ItemUI DefaultItemUIPrefab;

		// Token: 0x04004877 RID: 18551
		[Token(Token = "0x4004877")]
		[FieldOffset(Offset = "0x80")]
		public ItemSlotUI HotbarSlotUIPrefab;

		// Token: 0x04004878 RID: 18552
		[Token(Token = "0x4004878")]
		[FieldOffset(Offset = "0x88")]
		private ItemSlotUI draggedSlot;

		// Token: 0x04004879 RID: 18553
		[Token(Token = "0x4004879")]
		[FieldOffset(Offset = "0x90")]
		private Vector2 mouseOffset;

		// Token: 0x0400487A RID: 18554
		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x98")]
		private int draggedAmount;

		// Token: 0x0400487B RID: 18555
		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform tempIcon;

		// Token: 0x0400487C RID: 18556
		[Token(Token = "0x400487C")]
		[FieldOffset(Offset = "0xA8")]
		private List<GraphicRaycaster> _raycasters;

		// Token: 0x0400487D RID: 18557
		[Token(Token = "0x400487D")]
		[FieldOffset(Offset = "0xB0")]
		private bool isDraggingCash;

		// Token: 0x0400487E RID: 18558
		[Token(Token = "0x400487E")]
		[FieldOffset(Offset = "0xB4")]
		private float draggedCashAmount;

		// Token: 0x0400487F RID: 18559
		[Token(Token = "0x400487F")]
		[FieldOffset(Offset = "0xB8")]
		private List<ItemSlot> PrimarySlots;

		// Token: 0x04004880 RID: 18560
		[Token(Token = "0x4004880")]
		[FieldOffset(Offset = "0xC0")]
		private List<ItemSlot> SecondarySlots;

		// Token: 0x04004881 RID: 18561
		[Token(Token = "0x4004881")]
		[FieldOffset(Offset = "0xC8")]
		private bool customDragAmount;

		// Token: 0x04004882 RID: 18562
		[Token(Token = "0x4004882")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine quantityChangePopRoutine;

		// Token: 0x04004883 RID: 18563
		[Token(Token = "0x4004883")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onDragStart;

		// Token: 0x04004884 RID: 18564
		[Token(Token = "0x4004884")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onItemMoved;

		// Token: 0x04004885 RID: 18565
		[Token(Token = "0x4004885")]
		[FieldOffset(Offset = "0xE8")]
		private bool canControllerQuickMove;

		// Token: 0x04004886 RID: 18566
		[Token(Token = "0x4004886")]
		[FieldOffset(Offset = "0xE9")]
		private bool isInfoPanelToggledOn;
	}
}
