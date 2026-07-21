using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x2000D21")]
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x00018360 File Offset: 0x00016560
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E0E")]
		public bool isOpen
		{
			[Token(Token = "0x60061B5")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061B6")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060061B7 RID: 25015 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060061B8 RID: 25016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E0F")]
		public UISelectable LastSelectedSelectable
		{
			[Token(Token = "0x60061B7")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60061B8")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			set
			{
			}
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B9")]
		[Address(RVA = "0xA4B4C0", Offset = "0xA4A6C0", VA = "0x180A4B4C0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BA")]
		[Address(RVA = "0xA4AA30", Offset = "0xA49C30", VA = "0x180A4AA30", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BB")]
		[Address(RVA = "0xA4A8F0", Offset = "0xA49AF0", VA = "0x180A4A8F0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BC")]
		[Address(RVA = "0xA4B1C0", Offset = "0xA4A3C0", VA = "0x180A4B1C0")]
		protected void PhoneOpened()
		{
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BD")]
		[Address(RVA = "0xA4B130", Offset = "0xA4A330", VA = "0x180A4B130")]
		protected void PhoneClosed()
		{
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60061BE")]
		[Address(RVA = "0xA4A860", Offset = "0xA49A60", VA = "0x180A4A860")]
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			return null;
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BF")]
		[Address(RVA = "0xA4B410", Offset = "0xA4A610", VA = "0x180A4B410")]
		public void SetIsOpen(bool o)
		{
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C0")]
		[Address(RVA = "0xA4B250", Offset = "0xA4A450", VA = "0x180A4B250")]
		public void SetCanvasActive(bool a)
		{
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60061C1")]
		[Address(RVA = "0xA4B1E0", Offset = "0xA4A3E0", VA = "0x180A4B1E0")]
		private IEnumerator SelectUIPanel()
		{
			return null;
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C2")]
		[Address(RVA = "0xA4B580", Offset = "0xA4A780", VA = "0x180A4B580", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C3")]
		[Address(RVA = "0xA4AD60", Offset = "0xA49F60", VA = "0x180A4AD60", Slot = "9")]
		protected virtual void OnUncappedMinPass()
		{
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60061C4")]
		public Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			return null;
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C5")]
		[Address(RVA = "0xA4B740", Offset = "0xA4A940", VA = "0x180A4B740")]
		public HomeScreen()
		{
		}

		// Token: 0x040043AA RID: 17322
		[Token(Token = "0x40043AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected Canvas canvas;

		// Token: 0x040043AB RID: 17323
		[Token(Token = "0x40043AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Text timeText;

		// Token: 0x040043AC RID: 17324
		[Token(Token = "0x40043AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected RectTransform appIconContainer;

		// Token: 0x040043AD RID: 17325
		[Token(Token = "0x40043AD")]
		[FieldOffset(Offset = "0x40")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject appIconPrefab;

		// Token: 0x040043AE RID: 17326
		[Token(Token = "0x40043AE")]
		[FieldOffset(Offset = "0x48")]
		[Header("Custom UI")]
		[SerializeField]
		protected UIScreen uiScreen;

		// Token: 0x040043AF RID: 17327
		[Token(Token = "0x40043AF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected UIPanel uiPanel;

		// Token: 0x040043B0 RID: 17328
		[Token(Token = "0x40043B0")]
		[FieldOffset(Offset = "0x58")]
		protected List<Button> appIcons;

		// Token: 0x040043B1 RID: 17329
		[Token(Token = "0x40043B1")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine delayedSetOpenRoutine;

		// Token: 0x040043B2 RID: 17330
		[Token(Token = "0x40043B2")]
		[FieldOffset(Offset = "0x68")]
		private UISelectable lastSelectedSelectable;
	}
}
