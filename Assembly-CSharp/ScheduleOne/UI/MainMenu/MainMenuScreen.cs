using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	public class MainMenuScreen : MonoBehaviour
	{
		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x00018C00 File Offset: 0x00016E00
		// (set) Token: 0x06006518 RID: 25880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6B")]
		public bool IsOpen
		{
			[Token(Token = "0x6006517")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006518")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006519")]
		[Address(RVA = "0xA7A910", Offset = "0xA79B10", VA = "0x180A7A910", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651A")]
		[Address(RVA = "0xA7AFE0", Offset = "0xA7A1E0", VA = "0x180A7AFE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651B")]
		[Address(RVA = "0xA7AD00", Offset = "0xA79F00", VA = "0x180A7AD00", Slot = "5")]
		protected virtual void Exit(ExitAction action)
		{
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651C")]
		[Address(RVA = "0xA7B0F0", Offset = "0xA7A2F0", VA = "0x180A7B0F0", Slot = "6")]
		public virtual void Open(bool closePrevious)
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651D")]
		[Address(RVA = "0xA76BC0", Offset = "0xA75DC0", VA = "0x180A76BC0")]
		private void Close()
		{
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651E")]
		[Address(RVA = "0xA7AB30", Offset = "0xA79D30", VA = "0x180A7AB30", Slot = "7")]
		public virtual void Close(bool openPrevious)
		{
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651F")]
		[Address(RVA = "0xA7ADB0", Offset = "0xA79FB0", VA = "0x180A7ADB0")]
		private void Lerp(bool open)
		{
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MainMenuScreen()
		{
		}

		// Token: 0x040046E9 RID: 18153
		[Token(Token = "0x40046E9")]
		public const float LERP_TIME = 0.075f;

		// Token: 0x040046EA RID: 18154
		[Token(Token = "0x40046EA")]
		public const float LERP_SCALE = 1.25f;

		// Token: 0x040046EC RID: 18156
		[Token(Token = "0x40046EC")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public int ExitInputPriority;

		// Token: 0x040046ED RID: 18157
		[Token(Token = "0x40046ED")]
		[FieldOffset(Offset = "0x28")]
		public bool OpenOnStart;

		// Token: 0x040046EE RID: 18158
		[Token(Token = "0x40046EE")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public MainMenuScreen PreviousScreen;

		// Token: 0x040046EF RID: 18159
		[Token(Token = "0x40046EF")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup Group;

		// Token: 0x040046F0 RID: 18160
		[Token(Token = "0x40046F0")]
		[FieldOffset(Offset = "0x40")]
		[Header("Custom UI")]
		public UIScreen uiScreen;

		// Token: 0x040046F1 RID: 18161
		[Token(Token = "0x40046F1")]
		[FieldOffset(Offset = "0x48")]
		public UIPanel uiPanel;

		// Token: 0x040046F2 RID: 18162
		[Token(Token = "0x40046F2")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform Rect;

		// Token: 0x040046F3 RID: 18163
		[Token(Token = "0x40046F3")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine lerpRoutine;
	}
}
