using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C7B RID: 3195
	[Token(Token = "0x2000C7B")]
	public abstract class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x06005D84 RID: 23940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D84")]
		public static App<T> GetApp(int index)
		{
			return null;
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x00017880 File Offset: 0x00015A80
		// (set) Token: 0x06005D86 RID: 23942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D87")]
		public bool isOpen
		{
			[Token(Token = "0x6005D85")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D86")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D87")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D88")]
		protected override void Start()
		{
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D89")]
		private void Close()
		{
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8A")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x6005D8B")]
		private bool IsHoveringButton()
		{
			return default(bool);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8C")]
		private void GenerateHomeScreenIcon()
		{
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8D")]
		public void SetNotificationCount(int amount)
		{
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8E")]
		protected virtual void OnPhoneOpened()
		{
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D8F")]
		private void ShortcutClicked()
		{
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D90")]
		public virtual void Exit(ExitAction exit)
		{
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D91")]
		public virtual void SetOpen(bool open)
		{
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D92")]
		protected App()
		{
		}

		// Token: 0x04004005 RID: 16389
		[Token(Token = "0x4004005")]
		[FieldOffset(Offset = "0x0")]
		public static List<App<T>> Apps;

		// Token: 0x04004006 RID: 16390
		[Token(Token = "0x4004006")]
		[FieldOffset(Offset = "0x0")]
		[Header("Settings")]
		public string AppName;

		// Token: 0x04004007 RID: 16391
		[Token(Token = "0x4004007")]
		[FieldOffset(Offset = "0x0")]
		public string IconLabel;

		// Token: 0x04004008 RID: 16392
		[Token(Token = "0x4004008")]
		[FieldOffset(Offset = "0x0")]
		public Sprite AppIcon;

		// Token: 0x04004009 RID: 16393
		[Token(Token = "0x4004009")]
		[FieldOffset(Offset = "0x0")]
		public App<T>.EOrientation Orientation;

		// Token: 0x0400400A RID: 16394
		[Token(Token = "0x400400A")]
		[FieldOffset(Offset = "0x0")]
		public bool AvailableInTutorial;

		// Token: 0x0400400B RID: 16395
		[Token(Token = "0x400400B")]
		[FieldOffset(Offset = "0x0")]
		[Header("References")]
		[SerializeField]
		protected RectTransform appContainer;

		// Token: 0x0400400C RID: 16396
		[Token(Token = "0x400400C")]
		[FieldOffset(Offset = "0x0")]
		protected RectTransform notificationContainer;

		// Token: 0x0400400D RID: 16397
		[Token(Token = "0x400400D")]
		[FieldOffset(Offset = "0x0")]
		protected Text notificationText;

		// Token: 0x0400400F RID: 16399
		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0x0")]
		protected Button appIconButton;

		// Token: 0x02000C7C RID: 3196
		[Token(Token = "0x2000C7C")]
		public enum EOrientation
		{
			// Token: 0x04004011 RID: 16401
			[Token(Token = "0x4004011")]
			Horizontal,
			// Token: 0x04004012 RID: 16402
			[Token(Token = "0x4004012")]
			Vertical
		}
	}
}
