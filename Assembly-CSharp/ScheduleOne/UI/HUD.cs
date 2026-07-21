using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C58 RID: 3160
	[Token(Token = "0x2000C58")]
	public class HUD : Singleton<HUD>
	{
		// Token: 0x06005C7C RID: 23676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x9DA8E0", Offset = "0x9D9AE0", VA = "0x1809DA8E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x9DB170", Offset = "0x9DA370", VA = "0x1809DB170", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x819C50", Offset = "0x818E50", VA = "0x180819C50")]
		public void SetCrosshairVisible(bool vis)
		{
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x9DAF20", Offset = "0x9DA120", VA = "0x1809DAF20")]
		public void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x9DB300", Offset = "0x9DA500", VA = "0x1809DB300")]
		private void Update()
		{
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x9DB240", Offset = "0x9DA440", VA = "0x1809DB240")]
		private void UpdateQuestEntryTitle()
		{
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x9DAD30", Offset = "0x9D9F30", VA = "0x1809DAD30")]
		private void RefreshFPS()
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00017598 File Offset: 0x00015798
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x9DAA40", Offset = "0x9D9C40", VA = "0x1809DAA40")]
		private float GetAverageFPS()
		{
			return 0f;
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x9DAB60", Offset = "0x9D9D60", VA = "0x1809DAB60", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x9DA9B0", Offset = "0x9D9BB0", VA = "0x1809DA9B0")]
		protected IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			return null;
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x9DB060", Offset = "0x9DA260", VA = "0x1809DB060")]
		public void ShowRadialIndicator(float fill)
		{
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x9DB0A0", Offset = "0x9DA2A0", VA = "0x1809DB0A0")]
		public void ShowTopScreenText(string t)
		{
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x9DAB30", Offset = "0x9D9D30", VA = "0x1809DAB30")]
		public void HideTopScreenText()
		{
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x9DB020", Offset = "0x9DA220", VA = "0x1809DB020")]
		public void ShowFirearmReticle()
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x9DAAF0", Offset = "0x9D9CF0", VA = "0x1809DAAF0")]
		public void HideFirearmReticle()
		{
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x9DAFF0", Offset = "0x9DA1F0", VA = "0x1809DAFF0")]
		public void SetFirearmReticle(float spreadAngle)
		{
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x9DB6A0", Offset = "0x9DA8A0", VA = "0x1809DB6A0")]
		public HUD()
		{
		}

		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003EC4 RID: 16068
		[Token(Token = "0x4003EC4")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform canvasRect;

		// Token: 0x04003EC5 RID: 16069
		[Token(Token = "0x4003EC5")]
		[FieldOffset(Offset = "0x38")]
		public Image crosshair;

		// Token: 0x04003EC6 RID: 16070
		[Token(Token = "0x4003EC6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image blackOverlay;

		// Token: 0x04003EC7 RID: 16071
		[Token(Token = "0x4003EC7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Image radialIndicator;

		// Token: 0x04003EC8 RID: 16072
		[Token(Token = "0x4003EC8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x04003EC9 RID: 16073
		[Token(Token = "0x4003EC9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected TextMeshProUGUI topScreenText;

		// Token: 0x04003ECA RID: 16074
		[Token(Token = "0x4003ECA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected RectTransform topScreenText_Background;

		// Token: 0x04003ECB RID: 16075
		[Token(Token = "0x4003ECB")]
		[FieldOffset(Offset = "0x68")]
		public Text fpsLabel;

		// Token: 0x04003ECC RID: 16076
		[Token(Token = "0x4003ECC")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform cashSlotContainer;

		// Token: 0x04003ECD RID: 16077
		[Token(Token = "0x4003ECD")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform cashSlotUI;

		// Token: 0x04003ECE RID: 16078
		[Token(Token = "0x4003ECE")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform onlineBalanceContainer;

		// Token: 0x04003ECF RID: 16079
		[Token(Token = "0x4003ECF")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform onlineBalanceSlotUI;

		// Token: 0x04003ED0 RID: 16080
		[Token(Token = "0x4003ED0")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform managementSlotContainer;

		// Token: 0x04003ED1 RID: 16081
		[Token(Token = "0x4003ED1")]
		[FieldOffset(Offset = "0x98")]
		public ItemSlotUI managementSlotUI;

		// Token: 0x04003ED2 RID: 16082
		[Token(Token = "0x4003ED2")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform HotbarContainer;

		// Token: 0x04003ED3 RID: 16083
		[Token(Token = "0x4003ED3")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform SlotContainer;

		// Token: 0x04003ED4 RID: 16084
		[Token(Token = "0x4003ED4")]
		[FieldOffset(Offset = "0xB0")]
		public ItemSlotUI discardSlot;

		// Token: 0x04003ED5 RID: 16085
		[Token(Token = "0x4003ED5")]
		[FieldOffset(Offset = "0xB8")]
		public Image discardSlotFill;

		// Token: 0x04003ED6 RID: 16086
		[Token(Token = "0x4003ED6")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI selectedItemLabel;

		// Token: 0x04003ED7 RID: 16087
		[Token(Token = "0x4003ED7")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform QuestEntryContainer;

		// Token: 0x04003ED8 RID: 16088
		[Token(Token = "0x4003ED8")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI QuestEntryTitle;

		// Token: 0x04003ED9 RID: 16089
		[Token(Token = "0x4003ED9")]
		[FieldOffset(Offset = "0xD8")]
		public CrimeStatusUI CrimeStatusUI;

		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		[FieldOffset(Offset = "0xE0")]
		public BalanceDisplay OnlineBalanceDisplay;

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0xE8")]
		public BalanceDisplay SafeBalanceDisplay;

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		[FieldOffset(Offset = "0xF0")]
		public CrosshairText CrosshairText;

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform UnreadMessagesPrompt;

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI SleepPrompt;

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI CurfewPrompt;

		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		[FieldOffset(Offset = "0x110")]
		public CanvasGroup NotificationsCanvasGroup;

		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		[FieldOffset(Offset = "0x118")]
		public Animation CashSlotHintAnim;

		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		[FieldOffset(Offset = "0x120")]
		public CanvasGroup CashSlotHintAnimCanvasGroup;

		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private ReticleController _reticleController;

		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		[FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public Gradient RedGreenGradient;

		// Token: 0x04003EE5 RID: 16101
		[Token(Token = "0x4003EE5")]
		[FieldOffset(Offset = "0x138")]
		private int SampleSize;

		// Token: 0x04003EE6 RID: 16102
		[Token(Token = "0x4003EE6")]
		[FieldOffset(Offset = "0x140")]
		private List<float> _previousFPS;

		// Token: 0x04003EE7 RID: 16103
		[Token(Token = "0x4003EE7")]
		[FieldOffset(Offset = "0x148")]
		private EventSystem eventSystem;

		// Token: 0x04003EE8 RID: 16104
		[Token(Token = "0x4003EE8")]
		[FieldOffset(Offset = "0x150")]
		private Coroutine blackOverlayFade;

		// Token: 0x04003EE9 RID: 16105
		[Token(Token = "0x4003EE9")]
		[FieldOffset(Offset = "0x158")]
		private bool radialIndicatorSetThisFrame;
	}
}
