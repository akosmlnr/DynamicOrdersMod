using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public class TVApp : MonoBehaviour
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00008238 File Offset: 0x00006438
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		public bool IsOpen
		{
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001186")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x170003A8")]
		public bool IsPaused
		{
			[Token(Token = "0x6001187")]
			[Address(RVA = "0xB27E80", Offset = "0xB27080", VA = "0x180B27E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001188")]
		[Address(RVA = "0xB27640", Offset = "0xB26840", VA = "0x180B27640", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001189")]
		[Address(RVA = "0xB27B50", Offset = "0xB26D50", VA = "0x180B27B50")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118A")]
		[Address(RVA = "0xB27BE0", Offset = "0xB26DE0", VA = "0x180B27BE0", Slot = "5")]
		public virtual void Open()
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118B")]
		[Address(RVA = "0xB276F0", Offset = "0xB268F0", VA = "0x180B276F0", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public virtual void Resume()
		{
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118D")]
		[Address(RVA = "0xB279D0", Offset = "0xB26BD0", VA = "0x180B279D0")]
		private void Lerp(float endScale, float endAlpha)
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		protected virtual void ActiveMinPass()
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118F")]
		[Address(RVA = "0xB278C0", Offset = "0xB26AC0", VA = "0x180B278C0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001190")]
		[Address(RVA = "0xB27DC0", Offset = "0xB26FC0", VA = "0x180B27DC0", Slot = "9")]
		protected virtual void TryPause()
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001191")]
		[Address(RVA = "0xB27E70", Offset = "0xB27070", VA = "0x180B27E70")]
		public TVApp()
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001192")]
		[Address(RVA = "0xB27DE0", Offset = "0xB26FE0", VA = "0x180B27DE0")]
		[CompilerGenerated]
		private IEnumerator <Lerp>g__Lerp|23_0(float endScale, float endAlpha)
		{
			return null;
		}

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		public const float SCALE_MIN = 0.67f;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		public const float SCALE_MAX = 1.5f;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		public const float LERP_TIME = 0.12f;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings")]
		public bool CanClose;

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x28")]
		public string AppName;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x30")]
		public Sprite Icon;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x38")]
		public bool Pauseable;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public TVApp PreviousScreen;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x50")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x58")]
		public TVPauseScreen PauseScreen;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine lerpCoroutine;
	}
}
