using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000C12 RID: 3090
	[Token(Token = "0x2000C12")]
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x00017040 File Offset: 0x00015240
		// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D22")]
		public bool IsOpen
		{
			[Token(Token = "0x6005AB6")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AB7")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00017058 File Offset: 0x00015258
		// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D23")]
		public bool TutorialOpen
		{
			[Token(Token = "0x6005AB8")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AB9")]
			[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x9BFEE0", Offset = "0x9BF0E0", VA = "0x1809BFEE0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x9C1390", Offset = "0x9C0590", VA = "0x1809C1390", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x9C09E0", Offset = "0x9BFBE0", VA = "0x1809C09E0")]
		private void SetupSlots()
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x9C1590", Offset = "0x9C0790", VA = "0x1809C1590")]
		private void Update()
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x9C0360", Offset = "0x9BF560", VA = "0x1809C0360")]
		public void Open(NPC _searcher, float searchTime = 0f)
		{
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00017070 File Offset: 0x00015270
		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x9C0290", Offset = "0x9BF490", VA = "0x1809C0290")]
		private bool IsSlotConcealed(ItemSlotUI slot)
		{
			return default(bool);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0x9C02F0", Offset = "0x9BF4F0", VA = "0x1809C02F0")]
		private void ItemDetected(ItemSlotUI slot)
		{
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x9C1100", Offset = "0x9C0300", VA = "0x1809C1100")]
		public void SlotHeld(ItemSlotUI ui)
		{
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x9C1290", Offset = "0x9C0490", VA = "0x1809C1290")]
		public void SlotReleased(ItemSlotUI ui)
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x9BFF60", Offset = "0x9BF160", VA = "0x1809BFF60")]
		public void Close(bool clear)
		{
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x9C0310", Offset = "0x9BF510", VA = "0x1809C0310")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0x9BFF20", Offset = "0x9BF120", VA = "0x1809BFF20")]
		public void CloseTutorial()
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x9C1800", Offset = "0x9C0A00", VA = "0x1809C1800")]
		public BodySearchScreen()
		{
		}

		// Token: 0x04003D26 RID: 15654
		[Token(Token = "0x4003D26")]
		public const float MAX_SPEED_BOOST = 2.5f;

		// Token: 0x04003D29 RID: 15657
		[Token(Token = "0x4003D29")]
		[FieldOffset(Offset = "0x2C")]
		public Color SlotRedColor;

		// Token: 0x04003D2A RID: 15658
		[Token(Token = "0x4003D2A")]
		[FieldOffset(Offset = "0x3C")]
		public Color SlotHighlightRedColor;

		// Token: 0x04003D2B RID: 15659
		[Token(Token = "0x4003D2B")]
		[FieldOffset(Offset = "0x4C")]
		public float GapTime;

		// Token: 0x04003D2C RID: 15660
		[Token(Token = "0x4003D2C")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003D2D RID: 15661
		[Token(Token = "0x4003D2D")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform Container;

		// Token: 0x04003D2E RID: 15662
		[Token(Token = "0x4003D2E")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform MinigameController;

		// Token: 0x04003D2F RID: 15663
		[Token(Token = "0x4003D2F")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform SlotContainer;

		// Token: 0x04003D30 RID: 15664
		[Token(Token = "0x4003D30")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI ItemSlotPrefab;

		// Token: 0x04003D31 RID: 15665
		[Token(Token = "0x4003D31")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform SearchIndicator;

		// Token: 0x04003D32 RID: 15666
		[Token(Token = "0x4003D32")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform SearchIndicatorStart;

		// Token: 0x04003D33 RID: 15667
		[Token(Token = "0x4003D33")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform SearchIndicatorEnd;

		// Token: 0x04003D34 RID: 15668
		[Token(Token = "0x4003D34")]
		[FieldOffset(Offset = "0x90")]
		public Animation IndicatorAnimation;

		// Token: 0x04003D35 RID: 15669
		[Token(Token = "0x4003D35")]
		[FieldOffset(Offset = "0x98")]
		public Animation TutorialAnimation;

		// Token: 0x04003D36 RID: 15670
		[Token(Token = "0x4003D36")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform TutorialContainer;

		// Token: 0x04003D37 RID: 15671
		[Token(Token = "0x4003D37")]
		[FieldOffset(Offset = "0xA8")]
		public Animation ResetAnimation;

		// Token: 0x04003D38 RID: 15672
		[Token(Token = "0x4003D38")]
		[FieldOffset(Offset = "0xB0")]
		public AudioSourceController FailSound;

		// Token: 0x04003D39 RID: 15673
		[Token(Token = "0x4003D39")]
		[FieldOffset(Offset = "0xB8")]
		private List<ItemSlotUI> slots;

		// Token: 0x04003D3A RID: 15674
		[Token(Token = "0x4003D3A")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onSearchClear;

		// Token: 0x04003D3B RID: 15675
		[Token(Token = "0x4003D3B")]
		[FieldOffset(Offset = "0xC8")]
		public UnityEvent onSearchFail;

		// Token: 0x04003D3C RID: 15676
		[Token(Token = "0x4003D3C")]
		[FieldOffset(Offset = "0xD0")]
		private Color defaultSlotColor;

		// Token: 0x04003D3D RID: 15677
		[Token(Token = "0x4003D3D")]
		[FieldOffset(Offset = "0xE0")]
		private Color defaultSlotHighlightColor;

		// Token: 0x04003D3E RID: 15678
		[Token(Token = "0x4003D3E")]
		[FieldOffset(Offset = "0xF0")]
		private ItemSlotUI concealedSlot;

		// Token: 0x04003D3F RID: 15679
		[Token(Token = "0x4003D3F")]
		[FieldOffset(Offset = "0xF8")]
		private ItemSlotUI hoveredSlot;

		// Token: 0x04003D40 RID: 15680
		[Token(Token = "0x4003D40")]
		[FieldOffset(Offset = "0x100")]
		private Color[] defaultItemIconColors;

		// Token: 0x04003D41 RID: 15681
		[Token(Token = "0x4003D41")]
		[FieldOffset(Offset = "0x108")]
		private float speedBoost;

		// Token: 0x04003D42 RID: 15682
		[Token(Token = "0x4003D42")]
		[FieldOffset(Offset = "0x110")]
		private NPC searcher;

		// Token: 0x04003D43 RID: 15683
		[Token(Token = "0x4003D43")]
		[FieldOffset(Offset = "0x118")]
		private bool _caught;
	}
}
