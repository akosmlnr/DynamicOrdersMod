using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D24 RID: 3364
	[Token(Token = "0x2000D24")]
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060061D2 RID: 25042 RVA: 0x000183A8 File Offset: 0x000165A8
		// (set) Token: 0x060061D3 RID: 25043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E14")]
		public bool IsOpen
		{
			[Token(Token = "0x60061D2")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061D3")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x000183C0 File Offset: 0x000165C0
		// (set) Token: 0x060061D5 RID: 25045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E15")]
		public bool isHorizontal
		{
			[Token(Token = "0x60061D4")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061D5")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060061D6 RID: 25046 RVA: 0x000183D8 File Offset: 0x000165D8
		// (set) Token: 0x060061D7 RID: 25047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E16")]
		public bool isOpenable
		{
			[Token(Token = "0x60061D6")]
			[Address(RVA = "0xA4FA40", Offset = "0xA4EC40", VA = "0x180A4FA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061D7")]
			[Address(RVA = "0xA4F3D0", Offset = "0xA4E5D0", VA = "0x180A4F3D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060061D8 RID: 25048 RVA: 0x000183F0 File Offset: 0x000165F0
		// (set) Token: 0x060061D9 RID: 25049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E17")]
		public bool FlashlightOn
		{
			[Token(Token = "0x60061D8")]
			[Address(RVA = "0xA4F990", Offset = "0xA4EB90", VA = "0x180A4F990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061D9")]
			[Address(RVA = "0xA4FA50", Offset = "0xA4EC50", VA = "0x180A4FA50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060061DA RID: 25050 RVA: 0x00018408 File Offset: 0x00016608
		[Token(Token = "0x17000E18")]
		public float ScaledLookOffset
		{
			[Token(Token = "0x60061DA")]
			[Address(RVA = "0xA4F9A0", Offset = "0xA4EBA0", VA = "0x180A4F9A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E19")]
		public ColorFont GeneralColorFont
		{
			[Token(Token = "0x60061DB")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			get
			{
				return null;
			}
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DC")]
		[Address(RVA = "0xA4EB00", Offset = "0xA4DD00", VA = "0x180A4EB00", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DD")]
		[Address(RVA = "0xA4EDC0", Offset = "0xA4DFC0", VA = "0x180A4EDC0", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DE")]
		[Address(RVA = "0xA4F3E0", Offset = "0xA4E5E0", VA = "0x180A4F3E0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061DF")]
		[Address(RVA = "0xA4F600", Offset = "0xA4E800", VA = "0x180A4F600", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E0")]
		[Address(RVA = "0xA4ED50", Offset = "0xA4DF50", VA = "0x180A4ED50", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E1")]
		[Address(RVA = "0xA4F4E0", Offset = "0xA4E6E0", VA = "0x180A4F4E0")]
		private void ToggleFlashlight()
		{
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E2")]
		[Address(RVA = "0xA4F3D0", Offset = "0xA4E5D0", VA = "0x180A4F3D0")]
		public void SetOpenable(bool o)
		{
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E3")]
		[Address(RVA = "0xA4F030", Offset = "0xA4E230", VA = "0x180A4F030")]
		public void SetIsOpen(bool o)
		{
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E4")]
		[Address(RVA = "0xA4EF70", Offset = "0xA4E170", VA = "0x180A4EF70")]
		public void SetIsHorizontal(bool h)
		{
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60061E5")]
		[Address(RVA = "0xA4EEF0", Offset = "0xA4E0F0", VA = "0x180A4EEF0")]
		protected IEnumerator SetIsHorizontal_Process(bool h)
		{
			return null;
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E6")]
		[Address(RVA = "0xA4F210", Offset = "0xA4E410", VA = "0x180A4F210")]
		public void SetLookOffsetMultiplier(float multiplier)
		{
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061E7")]
		[Address(RVA = "0xA4EE50", Offset = "0xA4E050", VA = "0x180A4EE50")]
		public void RequestCloseApp()
		{
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60061E8")]
		[Address(RVA = "0xA4F350", Offset = "0xA4E550", VA = "0x180A4F350")]
		protected IEnumerator SetLookOffset_Process(float lookOffset)
		{
			return null;
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00018420 File Offset: 0x00016620
		[Token(Token = "0x60061E9")]
		[Address(RVA = "0xA4EB80", Offset = "0xA4DD80", VA = "0x180A4EB80")]
		public bool MouseRaycast(out RaycastResult result)
		{
			return default(bool);
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061EA")]
		[Address(RVA = "0xA4F930", Offset = "0xA4EB30", VA = "0x180A4F930")]
		public Phone()
		{
		}

		// Token: 0x040043BB RID: 17339
		[Token(Token = "0x40043BB")]
		[FieldOffset(Offset = "0x0")]
		public static GameObject ActiveApp;

		// Token: 0x040043C0 RID: 17344
		[Token(Token = "0x40043C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected GameObject phoneModel;

		// Token: 0x040043C1 RID: 17345
		[Token(Token = "0x40043C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform orientation_Vertical;

		// Token: 0x040043C2 RID: 17346
		[Token(Token = "0x40043C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Transform orientation_Horizontal;

		// Token: 0x040043C3 RID: 17347
		[Token(Token = "0x40043C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x040043C4 RID: 17348
		[Token(Token = "0x40043C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject PhoneFlashlight;

		// Token: 0x040043C5 RID: 17349
		[Token(Token = "0x40043C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected AudioSourceController FlashlightToggleSound;

		// Token: 0x040043C6 RID: 17350
		[Token(Token = "0x40043C6")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public float rotationTime;

		// Token: 0x040043C7 RID: 17351
		[Token(Token = "0x40043C7")]
		[FieldOffset(Offset = "0x5C")]
		public float LookOffsetMax;

		// Token: 0x040043C8 RID: 17352
		[Token(Token = "0x40043C8")]
		[FieldOffset(Offset = "0x60")]
		public float LookOffsetMin;

		// Token: 0x040043C9 RID: 17353
		[Token(Token = "0x40043C9")]
		[FieldOffset(Offset = "0x64")]
		public float OpenVerticalOffset;

		// Token: 0x040043CA RID: 17354
		[Token(Token = "0x40043CA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Fonts")]
		private ColorFont _generalColorFont;

		// Token: 0x040043CB RID: 17355
		[Token(Token = "0x40043CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ColorFont _productColorFont;

		// Token: 0x040043CC RID: 17356
		[Token(Token = "0x40043CC")]
		[FieldOffset(Offset = "0x78")]
		public Action onPhoneOpened;

		// Token: 0x040043CD RID: 17357
		[Token(Token = "0x40043CD")]
		[FieldOffset(Offset = "0x80")]
		public Action onPhoneClosed;

		// Token: 0x040043CE RID: 17358
		[Token(Token = "0x40043CE")]
		[FieldOffset(Offset = "0x88")]
		public Action closeApps;

		// Token: 0x040043CF RID: 17359
		[Token(Token = "0x40043CF")]
		[FieldOffset(Offset = "0x90")]
		private EventSystem eventSystem;

		// Token: 0x040043D0 RID: 17360
		[Token(Token = "0x40043D0")]
		[FieldOffset(Offset = "0x98")]
		private VisibilityAttribute flashlightVisibility;

		// Token: 0x040043D1 RID: 17361
		[Token(Token = "0x40043D1")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine rotationCoroutine;

		// Token: 0x040043D2 RID: 17362
		[Token(Token = "0x40043D2")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine lookOffsetCoroutine;
	}
}
