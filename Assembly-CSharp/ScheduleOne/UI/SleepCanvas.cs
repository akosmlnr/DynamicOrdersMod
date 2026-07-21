using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C92 RID: 3218
	[Token(Token = "0x2000C92")]
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x00017A90 File Offset: 0x00015C90
		// (set) Token: 0x06005E2E RID: 24110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA5")]
		public bool IsMenuOpen
		{
			[Token(Token = "0x6005E2D")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005E2E")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005E30 RID: 24112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA6")]
		public string QueuedSleepMessage
		{
			[Token(Token = "0x6005E2F")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E30")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xA11510", Offset = "0xA10710", VA = "0x180A11510", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0xA11B40", Offset = "0xA10D40", VA = "0x180A11B40")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0xA11E30", Offset = "0xA11030", VA = "0x180A11E30")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0xA12A00", Offset = "0xA11C00", VA = "0x180A12A00")]
		public void Update()
		{
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0xA113D0", Offset = "0xA105D0", VA = "0x180A113D0")]
		public void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0xA12870", Offset = "0xA11A70", VA = "0x180A12870")]
		private void UpdateHourSetting()
		{
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xA12980", Offset = "0xA11B80", VA = "0x180A12980")]
		private void UpdateTimeLabels()
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xA128B0", Offset = "0xA11AB0", VA = "0x180A128B0")]
		private void UpdateSleepButton()
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xA11840", Offset = "0xA10A40", VA = "0x180A11840")]
		private void ChangeSleepAmount(int change)
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0xA119B0", Offset = "0xA10BB0", VA = "0x180A119B0")]
		private int ClampWakeTime(int time)
		{
			return 0;
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x00017AC0 File Offset: 0x00015CC0
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0xA118E0", Offset = "0xA10AE0", VA = "0x180A118E0")]
		private int ClampTime(int time, int startTime, int endTime)
		{
			return 0;
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0xA124D0", Offset = "0xA116D0", VA = "0x180A124D0")]
		private void SleepButtonPressed()
		{
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0xA12550", Offset = "0xA11750", VA = "0x180A12550")]
		private void SleepStart()
		{
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0xA11B90", Offset = "0xA10D90", VA = "0x180A11B90")]
		private void LerpBlackOverlay(float transparency, float lerpTime)
		{
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0xA11CB0", Offset = "0xA10EB0", VA = "0x180A11CB0")]
		public void QueueSleepMessage(string message, float displayTime = 3f)
		{
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0xA12BF0", Offset = "0xA11DF0", VA = "0x180A12BF0")]
		public SleepCanvas()
		{
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xA12800", Offset = "0xA11A00", VA = "0x180A12800")]
		[CompilerGenerated]
		private IEnumerator <SleepStart>g__Sleep|42_0()
		{
			return null;
		}

		// Token: 0x040040A9 RID: 16553
		[Token(Token = "0x40040A9")]
		public const int MaxSleepTime = 12;

		// Token: 0x040040AA RID: 16554
		[Token(Token = "0x40040AA")]
		public const int MinSleepTime = 4;

		// Token: 0x040040AD RID: 16557
		[Token(Token = "0x40040AD")]
		[FieldOffset(Offset = "0x38")]
		private float QueuedMessageDisplayTime;

		// Token: 0x040040AE RID: 16558
		[Token(Token = "0x40040AE")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040040AF RID: 16559
		[Token(Token = "0x40040AF")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform Container;

		// Token: 0x040040B0 RID: 16560
		[Token(Token = "0x40040B0")]
		[FieldOffset(Offset = "0x50")]
		public UIScreen UIScreen;

		// Token: 0x040040B1 RID: 16561
		[Token(Token = "0x40040B1")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform MenuContainer;

		// Token: 0x040040B2 RID: 16562
		[Token(Token = "0x40040B2")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI CurrentTimeLabel;

		// Token: 0x040040B3 RID: 16563
		[Token(Token = "0x40040B3")]
		[FieldOffset(Offset = "0x68")]
		public Button IncreaseButton;

		// Token: 0x040040B4 RID: 16564
		[Token(Token = "0x40040B4")]
		[FieldOffset(Offset = "0x70")]
		public Button DecreaseButton;

		// Token: 0x040040B5 RID: 16565
		[Token(Token = "0x40040B5")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI EndTimeLabel;

		// Token: 0x040040B6 RID: 16566
		[Token(Token = "0x40040B6")]
		[FieldOffset(Offset = "0x80")]
		public Button SleepButton;

		// Token: 0x040040B7 RID: 16567
		[Token(Token = "0x40040B7")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI SleepButtonLabel;

		// Token: 0x040040B8 RID: 16568
		[Token(Token = "0x40040B8")]
		[FieldOffset(Offset = "0x90")]
		public Image BlackOverlay;

		// Token: 0x040040B9 RID: 16569
		[Token(Token = "0x40040B9")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI SleepMessageLabel;

		// Token: 0x040040BA RID: 16570
		[Token(Token = "0x40040BA")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup SleepMessageGroup;

		// Token: 0x040040BB RID: 16571
		[Token(Token = "0x40040BB")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x040040BC RID: 16572
		[Token(Token = "0x40040BC")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI WakeLabel;

		// Token: 0x040040BD RID: 16573
		[Token(Token = "0x40040BD")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI WaitingForHostLabel;

		// Token: 0x040040BE RID: 16574
		[Token(Token = "0x40040BE")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onSleepFullyFaded;

		// Token: 0x040040BF RID: 16575
		[Token(Token = "0x40040BF")]
		[FieldOffset(Offset = "0xC8")]
		public UnityEvent onSleepEndFade;

		// Token: 0x040040C0 RID: 16576
		[Token(Token = "0x40040C0")]
		[FieldOffset(Offset = "0xD0")]
		private List<IPostSleepEvent> queuedPostSleepEvents;
	}
}
