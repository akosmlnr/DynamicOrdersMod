using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D4C RID: 3404
	[Token(Token = "0x2000D4C")]
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x000187F8 File Offset: 0x000169F8
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E31")]
		public bool IsOpen
		{
			[Token(Token = "0x60062DA")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60062DB")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DC")]
		[Address(RVA = "0xA5C5E0", Offset = "0xA5B7E0", VA = "0x180A5C5E0")]
		private void Start()
		{
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DD")]
		[Address(RVA = "0xA5C0A0", Offset = "0xA5B2A0", VA = "0x180A5C0A0")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DE")]
		[Address(RVA = "0xA5C130", Offset = "0xA5B330", VA = "0x180A5C130")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0xA5C150", Offset = "0xA5B350", VA = "0x180A5C150")]
		public void SetIsOpen(bool open, MSGConversation conversation, [Optional] Action<EDealWindow> callback)
		{
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60062E0")]
		[Address(RVA = "0xA5C030", Offset = "0xA5B230", VA = "0x180A5C030")]
		private IEnumerator DelaySelectPanel()
		{
			return null;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E1")]
		[Address(RVA = "0xA5CE10", Offset = "0xA5C010", VA = "0x180A5CE10")]
		public void Update()
		{
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E2")]
		[Address(RVA = "0xA5C910", Offset = "0xA5BB10", VA = "0x180A5C910")]
		private void UpdateTime()
		{
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E3")]
		[Address(RVA = "0xA5CAD0", Offset = "0xA5BCD0", VA = "0x180A5CAD0")]
		private void UpdateWindowValidity()
		{
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E4")]
		[Address(RVA = "0xA5C010", Offset = "0xA5B210", VA = "0x180A5C010")]
		private void Close()
		{
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E5")]
		[Address(RVA = "0xA5BF80", Offset = "0xA5B180", VA = "0x180A5BF80")]
		private void ButtonClicked(EDealWindow window)
		{
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E6")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DealWindowSelector()
		{
		}

		// Token: 0x040044C7 RID: 17607
		[Token(Token = "0x40044C7")]
		public const float TIME_ARM_ROTATION_0000 = 0f;

		// Token: 0x040044C8 RID: 17608
		[Token(Token = "0x40044C8")]
		public const float TIME_ARM_ROTATION_2400 = -360f;

		// Token: 0x040044C9 RID: 17609
		[Token(Token = "0x40044C9")]
		public const int WINDOW_CUTOFF_MINS = 120;

		// Token: 0x040044CA RID: 17610
		[Token(Token = "0x40044CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent<EDealWindow> OnSelected;

		// Token: 0x040044CC RID: 17612
		[Token(Token = "0x40044CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x040044CD RID: 17613
		[Token(Token = "0x40044CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public WindowSelectorButton MorningButton;

		// Token: 0x040044CE RID: 17614
		[Token(Token = "0x40044CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public WindowSelectorButton AfternoonButton;

		// Token: 0x040044CF RID: 17615
		[Token(Token = "0x40044CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public WindowSelectorButton NightButton;

		// Token: 0x040044D0 RID: 17616
		[Token(Token = "0x40044D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public WindowSelectorButton LateNightButton;

		// Token: 0x040044D1 RID: 17617
		[Token(Token = "0x40044D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform CurrentTimeArm;

		// Token: 0x040044D2 RID: 17618
		[Token(Token = "0x40044D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text CurrentTimeLabel;

		// Token: 0x040044D3 RID: 17619
		[Token(Token = "0x40044D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Custom UI")]
		public UIScreen uiScreen;

		// Token: 0x040044D4 RID: 17620
		[Token(Token = "0x40044D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UIPanel uiPanel;

		// Token: 0x040044D5 RID: 17621
		[Token(Token = "0x40044D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action<EDealWindow> callback;

		// Token: 0x040044D6 RID: 17622
		[Token(Token = "0x40044D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private WindowSelectorButton[] buttons;

		// Token: 0x040044D7 RID: 17623
		[Token(Token = "0x40044D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool hintShown;
	}
}
