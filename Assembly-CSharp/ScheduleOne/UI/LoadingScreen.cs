using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C64 RID: 3172
	[Token(Token = "0x2000C64")]
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x00017658 File Offset: 0x00015858
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D70")]
		public bool IsOpen
		{
			[Token(Token = "0x6005CEB")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005CEC")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D71")]
		public Sprite[] ContextualBackgroundImages
		{
			[Token(Token = "0x6005CED")]
			[Address(RVA = "0x9E3060", Offset = "0x9E2260", VA = "0x1809E3060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0x9E2720", Offset = "0x9E1920", VA = "0x1809E2720", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x9E2F70", Offset = "0x9E2170", VA = "0x1809E2F70")]
		protected void Update()
		{
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x9E2C50", Offset = "0x9E1E50", VA = "0x1809E2C50")]
		public void Open(bool loadingTutorial = false)
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x9E2A10", Offset = "0x9E1C10", VA = "0x1809E2A10")]
		public void Close()
		{
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x9E2660", Offset = "0x9E1860", VA = "0x1809E2660")]
		private void AnimateBackground()
		{
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x9E2B30", Offset = "0x9E1D30", VA = "0x1809E2B30")]
		private void Fade(float endAlpha)
		{
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x9E3020", Offset = "0x9E2220", VA = "0x1809E3020")]
		public LoadingScreen()
		{
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x9E2F00", Offset = "0x9E2100", VA = "0x1809E2F00")]
		[CompilerGenerated]
		private IEnumerator <AnimateBackground>g__Routine|30_0()
		{
			return null;
		}

		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		public const float FADE_TIME = 0.25f;

		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		public const float BACKGROUND_IMAGE_TIME = 8f;

		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		public const float BACKGROUND_IMAGE_FADE_TIME = 1f;

		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x30")]
		public StringDatabase LoadingMessagesDatabase;

		// Token: 0x04003F51 RID: 16209
		[Token(Token = "0x4003F51")]
		[FieldOffset(Offset = "0x38")]
		public Sprite[] BackgroundImages;

		// Token: 0x04003F52 RID: 16210
		[Token(Token = "0x4003F52")]
		[FieldOffset(Offset = "0x40")]
		public Sprite[] TutorialBackgroundImages;

		// Token: 0x04003F53 RID: 16211
		[Token(Token = "0x4003F53")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003F54 RID: 16212
		[Token(Token = "0x4003F54")]
		[FieldOffset(Offset = "0x50")]
		public CanvasGroup Group;

		// Token: 0x04003F55 RID: 16213
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI LoadStatusLabel;

		// Token: 0x04003F56 RID: 16214
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI LoadingMessageLabel;

		// Token: 0x04003F57 RID: 16215
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x68")]
		public Image BackgroundImage1;

		// Token: 0x04003F58 RID: 16216
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x70")]
		public Image BackgroundImage2;

		// Token: 0x04003F59 RID: 16217
		[Token(Token = "0x4003F59")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform TutorialContainer;

		// Token: 0x04003F5A RID: 16218
		[Token(Token = "0x4003F5A")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform CoopTutorialHint;

		// Token: 0x04003F5B RID: 16219
		[Token(Token = "0x4003F5B")]
		[FieldOffset(Offset = "0x88")]
		private string[] loadingMessages;

		// Token: 0x04003F5C RID: 16220
		[Token(Token = "0x4003F5C")]
		[FieldOffset(Offset = "0x90")]
		private int currentBackgroundImageIndex;

		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine fadeRoutine;

		// Token: 0x04003F5E RID: 16222
		[Token(Token = "0x4003F5E")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine animateBackgroundRoutine;

		// Token: 0x04003F5F RID: 16223
		[Token(Token = "0x4003F5F")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine scaleBackgroundRoutine;

		// Token: 0x04003F60 RID: 16224
		[Token(Token = "0x4003F60")]
		[FieldOffset(Offset = "0xB0")]
		private bool isLoadingTutorial;
	}
}
