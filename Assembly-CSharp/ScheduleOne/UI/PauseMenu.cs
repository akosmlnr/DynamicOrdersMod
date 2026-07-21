using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000C74")]
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x00017760 File Offset: 0x00015960
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7F")]
		public bool IsPaused
		{
			[Token(Token = "0x6005D41")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D42")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D43")]
		[Address(RVA = "0x9E5CF0", Offset = "0x9E4EF0", VA = "0x1809E5CF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x9E6940", Offset = "0x9E5B40", VA = "0x1809E6940", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D45")]
		[Address(RVA = "0x9E5E80", Offset = "0x9E5080", VA = "0x1809E5E80")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D46")]
		[Address(RVA = "0x9E6A50", Offset = "0x9E5C50", VA = "0x1809E6A50")]
		private void Update()
		{
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D47")]
		[Address(RVA = "0x9E5F20", Offset = "0x9E5120", VA = "0x1809E5F20")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D48")]
		[Address(RVA = "0x9E5D30", Offset = "0x9E4F30", VA = "0x1809E5D30")]
		private void CheckTogglePause()
		{
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D49")]
		[Address(RVA = "0x9E6040", Offset = "0x9E5240", VA = "0x1809E6040")]
		public void Pause()
		{
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0x9E5E10", Offset = "0x9E5010", VA = "0x1809E5E10")]
		private IEnumerator DelayPanelSelect()
		{
			return null;
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0x9E65E0", Offset = "0x9E57E0", VA = "0x1809E65E0")]
		public void Resume()
		{
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x9E69C0", Offset = "0x9E5BC0", VA = "0x1809E69C0")]
		public void StuckButtonClicked()
		{
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x9E6B00", Offset = "0x9E5D00", VA = "0x1809E6B00")]
		public PauseMenu()
		{
		}

		// Token: 0x04003FB7 RID: 16311
		[Token(Token = "0x4003FB7")]
		[FieldOffset(Offset = "0x30")]
		public Canvas Canvas;

		// Token: 0x04003FB8 RID: 16312
		[Token(Token = "0x4003FB8")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003FB9 RID: 16313
		[Token(Token = "0x4003FB9")]
		[FieldOffset(Offset = "0x40")]
		public MainMenuScreen Screen;

		// Token: 0x04003FBA RID: 16314
		[Token(Token = "0x4003FBA")]
		[FieldOffset(Offset = "0x48")]
		public FeedbackForm FeedbackForm;

		// Token: 0x04003FBB RID: 16315
		[Token(Token = "0x4003FBB")]
		[FieldOffset(Offset = "0x50")]
		[Header("Custom UI")]
		public UIScreen uiScreen;

		// Token: 0x04003FBC RID: 16316
		[Token(Token = "0x4003FBC")]
		[FieldOffset(Offset = "0x58")]
		public UIPanel uiPanel;

		// Token: 0x04003FBD RID: 16317
		[Token(Token = "0x4003FBD")]
		[FieldOffset(Offset = "0x60")]
		private bool justPaused;

		// Token: 0x04003FBE RID: 16318
		[Token(Token = "0x4003FBE")]
		[FieldOffset(Offset = "0x61")]
		private bool justResumed;

		// Token: 0x04003FBF RID: 16319
		[Token(Token = "0x4003FBF")]
		[FieldOffset(Offset = "0x62")]
		private bool couldLook;

		// Token: 0x04003FC0 RID: 16320
		[Token(Token = "0x4003FC0")]
		[FieldOffset(Offset = "0x63")]
		private bool lockedMouse;

		// Token: 0x04003FC1 RID: 16321
		[Token(Token = "0x4003FC1")]
		[FieldOffset(Offset = "0x64")]
		private bool crosshairVisible;

		// Token: 0x04003FC2 RID: 16322
		[Token(Token = "0x4003FC2")]
		[FieldOffset(Offset = "0x65")]
		private bool hudVisible;

		// Token: 0x04003FC3 RID: 16323
		[Token(Token = "0x4003FC3")]
		[FieldOffset(Offset = "0x68")]
		public Action onPause;

		// Token: 0x04003FC4 RID: 16324
		[Token(Token = "0x4003FC4")]
		[FieldOffset(Offset = "0x70")]
		public Action onResume;

		// Token: 0x04003FC5 RID: 16325
		[Token(Token = "0x4003FC5")]
		[FieldOffset(Offset = "0x78")]
		private bool _togglePausePressed;

		// Token: 0x04003FC6 RID: 16326
		[Token(Token = "0x4003FC6")]
		[FieldOffset(Offset = "0x79")]
		private bool _backWasTriggeredThisFrame;
	}
}
