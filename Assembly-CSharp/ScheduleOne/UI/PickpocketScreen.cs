using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C7D RID: 3197
	[Token(Token = "0x2000C7D")]
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06005D94 RID: 23956 RVA: 0x000178B0 File Offset: 0x00015AB0
		// (set) Token: 0x06005D95 RID: 23957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D88")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D94")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D95")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06005D96 RID: 23958 RVA: 0x000178C8 File Offset: 0x00015AC8
		// (set) Token: 0x06005D97 RID: 23959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D89")]
		public bool TutorialOpen
		{
			[Token(Token = "0x6005D96")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D97")]
			[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x9E9F60", Offset = "0x9E9160", VA = "0x1809E9F60", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D99")]
		[Address(RVA = "0x9EB6C0", Offset = "0x9EA8C0", VA = "0x1809EB6C0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D9A")]
		[Address(RVA = "0x9EA950", Offset = "0x9E9B50", VA = "0x1809EA950")]
		public void Open(NPC _npc)
		{
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D9B")]
		[Address(RVA = "0x9EA5A0", Offset = "0x9E97A0", VA = "0x1809EA5A0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0x9EBAF0", Offset = "0x9EACF0", VA = "0x1809EBAF0")]
		private void Update()
		{
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x9EB790", Offset = "0x9EA990", VA = "0x1809EB790")]
		private void StopArrow()
		{
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D9E")]
		[Address(RVA = "0x9EB4A0", Offset = "0x9EA6A0", VA = "0x1809EB4A0")]
		public void SetSlotLocked(int index, bool locked)
		{
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D9F")]
		[Address(RVA = "0x9EA760", Offset = "0x9E9960", VA = "0x1809EA760")]
		private ItemSlotUI GetHoveredSlot()
		{
			return null;
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0x9EA5F0", Offset = "0x9E97F0", VA = "0x1809EA5F0")]
		private void Fail()
		{
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0x9EA090", Offset = "0x9E9290", VA = "0x1809EA090")]
		public void Close()
		{
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0x9EA900", Offset = "0x9E9B00", VA = "0x1809EA900")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0x9EA050", Offset = "0x9E9250", VA = "0x1809EA050")]
		public void CloseTutorial()
		{
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0x9EA680", Offset = "0x9E9880", VA = "0x1809EA680")]
		private float GetGreenAreaNormalizedPosition(int index)
		{
			return 0f;
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x000178F8 File Offset: 0x00015AF8
		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0x9EA6F0", Offset = "0x9E98F0", VA = "0x1809EA6F0")]
		private float GetGreenAreaNormalizedWidth(int index)
		{
			return 0f;
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x9EBD80", Offset = "0x9EAF80", VA = "0x1809EBD80")]
		public PickpocketScreen()
		{
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0x9EBA80", Offset = "0x9EAC80", VA = "0x1809EBA80")]
		[CompilerGenerated]
		private IEnumerator <Fail>g__FailCoroutine|42_0()
		{
			return null;
		}

		// Token: 0x04004013 RID: 16403
		[Token(Token = "0x4004013")]
		public const int PICKPOCKET_XP = 2;

		// Token: 0x04004016 RID: 16406
		[Token(Token = "0x4004016")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float GreenAreaMaxWidth;

		// Token: 0x04004017 RID: 16407
		[Token(Token = "0x4004017")]
		[FieldOffset(Offset = "0x30")]
		public float GreenAreaMinWidth;

		// Token: 0x04004018 RID: 16408
		[Token(Token = "0x4004018")]
		[FieldOffset(Offset = "0x34")]
		public float SlideTime;

		// Token: 0x04004019 RID: 16409
		[Token(Token = "0x4004019")]
		[FieldOffset(Offset = "0x38")]
		public float SlideTimeMaxMultiplier;

		// Token: 0x0400401A RID: 16410
		[Token(Token = "0x400401A")]
		[FieldOffset(Offset = "0x3C")]
		public float ValueDivisor;

		// Token: 0x0400401B RID: 16411
		[Token(Token = "0x400401B")]
		[FieldOffset(Offset = "0x40")]
		public float Tolerance;

		// Token: 0x0400401C RID: 16412
		[Token(Token = "0x400401C")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400401D RID: 16413
		[Token(Token = "0x400401D")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform Container;

		// Token: 0x0400401E RID: 16414
		[Token(Token = "0x400401E")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI[] Slots;

		// Token: 0x0400401F RID: 16415
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform[] GreenAreas;

		// Token: 0x04004020 RID: 16416
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x68")]
		public Animation TutorialAnimation;

		// Token: 0x04004021 RID: 16417
		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform TutorialContainer;

		// Token: 0x04004022 RID: 16418
		[Token(Token = "0x4004022")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform SliderContainer;

		// Token: 0x04004023 RID: 16419
		[Token(Token = "0x4004023")]
		[FieldOffset(Offset = "0x80")]
		public Slider Slider;

		// Token: 0x04004024 RID: 16420
		[Token(Token = "0x4004024")]
		[FieldOffset(Offset = "0x88")]
		public InputPrompt InputPrompt;

		// Token: 0x04004025 RID: 16421
		[Token(Token = "0x4004025")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform ActionsContainer;

		// Token: 0x04004026 RID: 16422
		[Token(Token = "0x4004026")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onFail;

		// Token: 0x04004027 RID: 16423
		[Token(Token = "0x4004027")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onStop;

		// Token: 0x04004028 RID: 16424
		[Token(Token = "0x4004028")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onHitGreen;

		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		[FieldOffset(Offset = "0xB0")]
		private NPC npc;

		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x400402A")]
		[FieldOffset(Offset = "0xB8")]
		private bool isSliding;

		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x400402B")]
		[FieldOffset(Offset = "0xBC")]
		private int slideDirection;

		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x400402C")]
		[FieldOffset(Offset = "0xC0")]
		private float sliderPosition;

		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x400402D")]
		[FieldOffset(Offset = "0xC4")]
		private float slideTimeMultiplier;

		// Token: 0x0400402E RID: 16430
		[Token(Token = "0x400402E")]
		[FieldOffset(Offset = "0xC8")]
		private bool isFail;
	}
}
