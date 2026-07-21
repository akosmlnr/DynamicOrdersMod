using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000072D8 File Offset: 0x000054D8
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032A")]
		public static GameInput.InputDeviceType CurrentInputDevice
		{
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0xAE91D0", Offset = "0xAE83D0", VA = "0x180AE91D0")]
			[CompilerGenerated]
			get
			{
				return GameInput.InputDeviceType.KeyboardMouse;
			}
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0xAE9880", Offset = "0xAE8A80", VA = "0x180AE9880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x1700032B")]
		public static Vector2 MouseDelta
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0xAE9220", Offset = "0xAE8420", VA = "0x180AE9220")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x1700032C")]
		public static Vector3 MousePosition
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0xAE9280", Offset = "0xAE8480", VA = "0x180AE9280")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x1700032D")]
		public static float MouseScrollDelta
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0xAE9490", Offset = "0xAE8690", VA = "0x180AE9490")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00007338 File Offset: 0x00005538
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032E")]
		public static float VehicleDriveAxis
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0xAE9830", Offset = "0xAE8A30", VA = "0x180AE9830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0xAE9CD0", Offset = "0xAE8ED0", VA = "0x180AE9CD0")]
			private set
			{
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00007350 File Offset: 0x00005550
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032F")]
		public static Vector2 UINavigationDirection
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0xAE96E0", Offset = "0xAE88E0", VA = "0x180AE96E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0xAE9B40", Offset = "0xAE8D40", VA = "0x180AE9B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00007368 File Offset: 0x00005568
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		public static Vector2 UICyclePanelDirection
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0xAE94E0", Offset = "0xAE86E0", VA = "0x180AE94E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0xAE98E0", Offset = "0xAE8AE0", VA = "0x180AE98E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00007380 File Offset: 0x00005580
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		public static float UITabNavigationPrimaryAxis
		{
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0xAE9790", Offset = "0xAE8990", VA = "0x180AE9790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0xAE9C10", Offset = "0xAE8E10", VA = "0x180AE9C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000332")]
		public static float UITabNavigationSecondaryAxis
		{
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0xAE97E0", Offset = "0xAE89E0", VA = "0x180AE97E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0xAE9C70", Offset = "0xAE8E70", VA = "0x180AE9C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000073B0 File Offset: 0x000055B0
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000333")]
		public static float UIScrollbarAxis
		{
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0xAE9740", Offset = "0xAE8940", VA = "0x180AE9740")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0xAE9BB0", Offset = "0xAE8DB0", VA = "0x180AE9BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000073C8 File Offset: 0x000055C8
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		public static Vector2 UIMapNavigationDirection
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0xAE9540", Offset = "0xAE8740", VA = "0x180AE9540")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0xAE9950", Offset = "0xAE8B50", VA = "0x180AE9950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000073E0 File Offset: 0x000055E0
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		public static float UIMapZoomAxis
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0xAE95A0", Offset = "0xAE87A0", VA = "0x180AE95A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0xAE99C0", Offset = "0xAE8BC0", VA = "0x180AE99C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x000073F8 File Offset: 0x000055F8
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000336")]
		public static float UIModifyAmountIncrementTierOneAxis
		{
			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0xAE95F0", Offset = "0xAE87F0", VA = "0x180AE95F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0xAE9A20", Offset = "0xAE8C20", VA = "0x180AE9A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00007410 File Offset: 0x00005610
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000337")]
		public static float UIModifyAmountIncrementTierTwoAxis
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0xAE9690", Offset = "0xAE8890", VA = "0x180AE9690")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0xAE9AE0", Offset = "0xAE8CE0", VA = "0x180AE9AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00007428 File Offset: 0x00005628
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		public static float UIModifyAmountIncrementTierThreeAxis
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0xAE9640", Offset = "0xAE8840", VA = "0x180AE9640")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0xAE9A80", Offset = "0xAE8C80", VA = "0x180AE9A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0xAE37A0", Offset = "0xAE29A0", VA = "0x180AE37A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0xAE49B0", Offset = "0xAE3BB0", VA = "0x180AE49B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0xAE8B60", Offset = "0xAE7D60", VA = "0x180AE8B60", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0xAE4010", Offset = "0xAE3210", VA = "0x180AE4010")]
		private void OnApplicationFocus(bool focus)
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0xAE3E10", Offset = "0xAE3010", VA = "0x180AE3E10")]
		public static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0xAE3CD0", Offset = "0xAE2ED0", VA = "0x180AE3CD0")]
		public static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0xAE3D70", Offset = "0xAE2F70", VA = "0x180AE3D70")]
		public static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			return default(bool);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0xAE3F30", Offset = "0xAE3130", VA = "0x180AE3F30")]
		public static bool GetCurrentInputDeviceIsKeyboardMouse()
		{
			return default(bool);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0xAE3EB0", Offset = "0xAE30B0", VA = "0x180AE3EB0")]
		public static bool GetCurrentInputDeviceIsGamepad()
		{
			return default(bool);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0xAE8E10", Offset = "0xAE8010", VA = "0x180AE8E10", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0xAE3AC0", Offset = "0xAE2CC0", VA = "0x180AE3AC0")]
		private void Exit(ExitType type)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0xAE3FB0", Offset = "0xAE31B0", VA = "0x180AE3FB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0xAE3920", Offset = "0xAE2B20", VA = "0x180AE3920")]
		public void ExitAll()
		{
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0xAE4580", Offset = "0xAE3780", VA = "0x180AE4580")]
		private void OnControlsChanged(PlayerInput input)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0xAE5640", Offset = "0xAE4840", VA = "0x180AE5640")]
		private void OnMotion(InputValue value)
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0xAE62B0", Offset = "0xAE54B0", VA = "0x180AE62B0")]
		private void OnPrimaryClick()
		{
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0xAE6B80", Offset = "0xAE5D80", VA = "0x180AE6B80")]
		private void OnSecondaryClick()
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0xAE73A0", Offset = "0xAE65A0", VA = "0x180AE73A0")]
		private void OnTertiaryClick()
		{
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0xAE52C0", Offset = "0xAE44C0", VA = "0x180AE52C0")]
		private void OnJump()
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0xAE47D0", Offset = "0xAE39D0", VA = "0x180AE47D0")]
		private void OnCrouch()
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0xAE7060", Offset = "0xAE6260", VA = "0x180AE7060")]
		private void OnSprint()
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0xAE4A60", Offset = "0xAE3C60", VA = "0x180AE4A60")]
		private void OnEscape()
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0xAE41C0", Offset = "0xAE33C0", VA = "0x180AE41C0")]
		private void OnBack()
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0xAE4DA0", Offset = "0xAE3FA0", VA = "0x180AE4DA0")]
		private void OnInteract()
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0xAE7200", Offset = "0xAE6400", VA = "0x180AE7200")]
		private void OnSubmit()
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0xAE7880", Offset = "0xAE6A80", VA = "0x180AE7880")]
		private void OnTogglePhone()
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0xAE85F0", Offset = "0xAE77F0", VA = "0x180AE85F0")]
		private void OnVehicleToggleLights()
		{
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0xAE82B0", Offset = "0xAE74B0", VA = "0x180AE82B0")]
		private void OnVehicleHandbrake()
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0xAE67B0", Offset = "0xAE59B0", VA = "0x180AE67B0")]
		private void OnRotateLeft()
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0xAE6950", Offset = "0xAE5B50", VA = "0x180AE6950")]
		private void OnRotateRight()
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0xAE54A0", Offset = "0xAE46A0", VA = "0x180AE54A0")]
		private void OnManagementMode()
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0xAE5F70", Offset = "0xAE5170", VA = "0x180AE5F70")]
		private void OnOpenMap()
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0xAE5DD0", Offset = "0xAE4FD0", VA = "0x180AE5DD0")]
		private void OnOpenJournal()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0xAE6110", Offset = "0xAE5310", VA = "0x180AE6110")]
		private void OnOpenTexts()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0xAE6430", Offset = "0xAE5630", VA = "0x180AE6430")]
		private void OnQuickMove()
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0xAE7540", Offset = "0xAE6740", VA = "0x180AE7540")]
		private void OnToggleFlashlight()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0xAE8790", Offset = "0xAE7990", VA = "0x180AE8790")]
		private void OnViewAvatar()
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0xAE65D0", Offset = "0xAE57D0", VA = "0x180AE65D0")]
		private void OnReload()
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0xAE43A0", Offset = "0xAE35A0", VA = "0x180AE43A0")]
		private void OnCamera(InputValue value)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0xAE6AF0", Offset = "0xAE5CF0", VA = "0x180AE6AF0")]
		private void OnScrollWheel(InputValue value)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0xAE4F80", Offset = "0xAE4180", VA = "0x180AE4F80")]
		private void OnInventoryLeft()
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0xAE5120", Offset = "0xAE4320", VA = "0x180AE5120")]
		private void OnInventoryRight()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0xAE4C00", Offset = "0xAE3E00", VA = "0x180AE4C00")]
		private void OnHolster()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0xAE44D0", Offset = "0xAE36D0", VA = "0x180AE44D0")]
		private void OnControllerCombo(InputValue value)
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0xAE8450", Offset = "0xAE7650", VA = "0x180AE8450")]
		private void OnVehicleResetCamera()
		{
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0xAE81D0", Offset = "0xAE73D0", VA = "0x180AE81D0")]
		private void OnVehicleDrive(InputValue value)
		{
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0xAE6D20", Offset = "0xAE5F20", VA = "0x180AE6D20")]
		private void OnSkateboardDismount()
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0xAE6EC0", Offset = "0xAE60C0", VA = "0x180AE6EC0")]
		private void OnSkateboardMount()
		{
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0xAE76E0", Offset = "0xAE68E0", VA = "0x180AE76E0")]
		private void OnTogglePauseMenu()
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0xAE7EC0", Offset = "0xAE70C0", VA = "0x180AE7EC0")]
		private void OnUINavigationDirection(InputValue value)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0xAE7A20", Offset = "0xAE6C20", VA = "0x180AE7A20")]
		private void OnUICyclePanelDirection(InputValue value)
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0xAE8050", Offset = "0xAE7250", VA = "0x180AE8050")]
		private void OnUITabNavigationPrimary(InputValue value)
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0xAE8110", Offset = "0xAE7310", VA = "0x180AE8110")]
		private void OnUITabNavigationSecondary(InputValue value)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0xAE7F90", Offset = "0xAE7190", VA = "0x180AE7F90")]
		private void OnUIScrollbar(InputValue value)
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0xAE7AF0", Offset = "0xAE6CF0", VA = "0x180AE7AF0")]
		private void OnUIMapNavigationDirection(InputValue value)
		{
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0xAE7BC0", Offset = "0xAE6DC0", VA = "0x180AE7BC0")]
		private void OnUIMapZoom(InputValue value)
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0xAE7C80", Offset = "0xAE6E80", VA = "0x180AE7C80")]
		private void OnUIModifyAmountIncrementTierOne(InputValue value)
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0xAE7E00", Offset = "0xAE7000", VA = "0x180AE7E00")]
		private void OnUIModifyAmountIncrementTierTwo(InputValue value)
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0xAE7D40", Offset = "0xAE6F40", VA = "0x180AE7D40")]
		private void OnUIModifyAmountIncrementTierThree(InputValue value)
		{
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0xAE8930", Offset = "0xAE7B30", VA = "0x180AE8930")]
		public static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0xAE37E0", Offset = "0xAE29E0", VA = "0x180AE37E0")]
		public static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0xAE3C40", Offset = "0xAE2E40", VA = "0x180AE3C40")]
		public InputAction GetAction(GameInput.ButtonCode code)
		{
			return null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0xAE90E0", Offset = "0xAE82E0", VA = "0x180AE90E0")]
		public GameInput()
		{
		}

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameInput.InputDeviceType> OnInputDeviceChanged;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x10")]
		public static List<GameInput.ExitListener> exitListeners;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x28")]
		public PlayerInput PlayerInput;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x18")]
		public static bool IsTyping;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x1C")]
		public static Vector2 MotionAxis;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x24")]
		public static Vector2 CameraAxis;

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x2C")]
		public static bool TogglePauseInputUsed;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x30")]
		private static Mouse systemMouse;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x38")]
		public static float MouseWheelAxis;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x3C")]
		public static bool ControllerComboActive;

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x30")]
		private float vehicleDriveAxis;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x38")]
		private List<GameInput.ButtonCode> buttonsDownThisFrame;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x40")]
		private List<GameInput.ButtonCode> buttonsDown;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x48")]
		private List<GameInput.ButtonCode> buttonsUpThisFrame;

		// Token: 0x02000284 RID: 644
		[Token(Token = "0x2000284")]
		public enum ButtonCode
		{
			// Token: 0x04000D1E RID: 3358
			[Token(Token = "0x4000D1E")]
			PrimaryClick,
			// Token: 0x04000D1F RID: 3359
			[Token(Token = "0x4000D1F")]
			SecondaryClick,
			// Token: 0x04000D20 RID: 3360
			[Token(Token = "0x4000D20")]
			TertiaryClick,
			// Token: 0x04000D21 RID: 3361
			[Token(Token = "0x4000D21")]
			Forward,
			// Token: 0x04000D22 RID: 3362
			[Token(Token = "0x4000D22")]
			Backward,
			// Token: 0x04000D23 RID: 3363
			[Token(Token = "0x4000D23")]
			Left,
			// Token: 0x04000D24 RID: 3364
			[Token(Token = "0x4000D24")]
			Right,
			// Token: 0x04000D25 RID: 3365
			[Token(Token = "0x4000D25")]
			Jump,
			// Token: 0x04000D26 RID: 3366
			[Token(Token = "0x4000D26")]
			Crouch,
			// Token: 0x04000D27 RID: 3367
			[Token(Token = "0x4000D27")]
			Sprint,
			// Token: 0x04000D28 RID: 3368
			[Token(Token = "0x4000D28")]
			Escape,
			// Token: 0x04000D29 RID: 3369
			[Token(Token = "0x4000D29")]
			Back,
			// Token: 0x04000D2A RID: 3370
			[Token(Token = "0x4000D2A")]
			Interact,
			// Token: 0x04000D2B RID: 3371
			[Token(Token = "0x4000D2B")]
			Submit,
			// Token: 0x04000D2C RID: 3372
			[Token(Token = "0x4000D2C")]
			TogglePhone,
			// Token: 0x04000D2D RID: 3373
			[Token(Token = "0x4000D2D")]
			VehicleToggleLights,
			// Token: 0x04000D2E RID: 3374
			[Token(Token = "0x4000D2E")]
			VehicleHandbrake,
			// Token: 0x04000D2F RID: 3375
			[Token(Token = "0x4000D2F")]
			RotateLeft,
			// Token: 0x04000D30 RID: 3376
			[Token(Token = "0x4000D30")]
			RotateRight,
			// Token: 0x04000D31 RID: 3377
			[Token(Token = "0x4000D31")]
			ManagementMode,
			// Token: 0x04000D32 RID: 3378
			[Token(Token = "0x4000D32")]
			OpenMap,
			// Token: 0x04000D33 RID: 3379
			[Token(Token = "0x4000D33")]
			OpenJournal,
			// Token: 0x04000D34 RID: 3380
			[Token(Token = "0x4000D34")]
			OpenTexts,
			// Token: 0x04000D35 RID: 3381
			[Token(Token = "0x4000D35")]
			QuickMove,
			// Token: 0x04000D36 RID: 3382
			[Token(Token = "0x4000D36")]
			ToggleFlashlight,
			// Token: 0x04000D37 RID: 3383
			[Token(Token = "0x4000D37")]
			ViewAvatar,
			// Token: 0x04000D38 RID: 3384
			[Token(Token = "0x4000D38")]
			Reload,
			// Token: 0x04000D39 RID: 3385
			[Token(Token = "0x4000D39")]
			InventoryLeft,
			// Token: 0x04000D3A RID: 3386
			[Token(Token = "0x4000D3A")]
			InventoryRight,
			// Token: 0x04000D3B RID: 3387
			[Token(Token = "0x4000D3B")]
			Holster,
			// Token: 0x04000D3C RID: 3388
			[Token(Token = "0x4000D3C")]
			VehicleResetCamera,
			// Token: 0x04000D3D RID: 3389
			[Token(Token = "0x4000D3D")]
			SkateboardDismount,
			// Token: 0x04000D3E RID: 3390
			[Token(Token = "0x4000D3E")]
			SkateboardMount,
			// Token: 0x04000D3F RID: 3391
			[Token(Token = "0x4000D3F")]
			TogglePauseMenu
		}

		// Token: 0x02000285 RID: 645
		[Token(Token = "0x2000285")]
		public enum InputDeviceType
		{
			// Token: 0x04000D41 RID: 3393
			[Token(Token = "0x4000D41")]
			KeyboardMouse,
			// Token: 0x04000D42 RID: 3394
			[Token(Token = "0x4000D42")]
			Gamepad
		}

		// Token: 0x02000286 RID: 646
		[Token(Token = "0x2000286")]
		public class ExitListener
		{
			// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EA5")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ExitListener()
			{
			}

			// Token: 0x04000D43 RID: 3395
			[Token(Token = "0x4000D43")]
			[FieldOffset(Offset = "0x10")]
			public GameInput.ExitDelegate listenerFunction;

			// Token: 0x04000D44 RID: 3396
			[Token(Token = "0x4000D44")]
			[FieldOffset(Offset = "0x18")]
			public int priority;
		}

		// Token: 0x02000287 RID: 647
		// (Invoke) Token: 0x06000EA7 RID: 3751
		[Token(Token = "0x2000287")]
		public delegate void ExitDelegate(ExitAction exitAction);
	}
}
