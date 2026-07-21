using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D59 RID: 3417
	[Token(Token = "0x2000D59")]
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06006327 RID: 25383 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006328 RID: 25384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E3B")]
		public UIPanel dialogueScreenUIPanel
		{
			[Token(Token = "0x6006327")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006328")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006329")]
		[Address(RVA = "0xA63CE0", Offset = "0xA62EE0", VA = "0x180A63CE0")]
		public void Awake()
		{
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632A")]
		[Address(RVA = "0xA64270", Offset = "0xA63470", VA = "0x180A64270")]
		public void Start()
		{
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632B")]
		[Address(RVA = "0xA63E30", Offset = "0xA63030", VA = "0x180A63E30")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632C")]
		[Address(RVA = "0xA63ED0", Offset = "0xA630D0", VA = "0x180A63ED0")]
		public void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632D")]
		[Address(RVA = "0xA64340", Offset = "0xA63540", VA = "0x180A64340")]
		public void UpdateSendables()
		{
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632E")]
		[Address(RVA = "0xA639A0", Offset = "0xA62BA0", VA = "0x180A639A0")]
		public void AddSendable(SendableMessage sendable)
		{
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632F")]
		[Address(RVA = "0xA63E80", Offset = "0xA63080", VA = "0x180A63E80", Slot = "4")]
		protected virtual void SendableSelected(SendableMessage sendable)
		{
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006330")]
		[Address(RVA = "0xA64520", Offset = "0xA63720", VA = "0x180A64520")]
		public MessageSenderInterface()
		{
		}

		// Token: 0x0400452C RID: 17708
		[Token(Token = "0x400452C")]
		[FieldOffset(Offset = "0x20")]
		public MessageSenderInterface.EVisibility Visibility;

		// Token: 0x0400452D RID: 17709
		[Token(Token = "0x400452D")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public float DockedMenuYPos;

		// Token: 0x0400452E RID: 17710
		[Token(Token = "0x400452E")]
		[FieldOffset(Offset = "0x28")]
		public float ExpandedMenuYPos;

		// Token: 0x0400452F RID: 17711
		[Token(Token = "0x400452F")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform Menu;

		// Token: 0x04004530 RID: 17712
		[Token(Token = "0x4004530")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform SendablesContainer;

		// Token: 0x04004531 RID: 17713
		[Token(Token = "0x4004531")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform[] DockedUIElements;

		// Token: 0x04004532 RID: 17714
		[Token(Token = "0x4004532")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform[] ExpandedUIElements;

		// Token: 0x04004533 RID: 17715
		[Token(Token = "0x4004533")]
		[FieldOffset(Offset = "0x50")]
		public Button ComposeButton;

		// Token: 0x04004534 RID: 17716
		[Token(Token = "0x4004534")]
		[FieldOffset(Offset = "0x58")]
		public Button[] CancelButtons;

		// Token: 0x04004535 RID: 17717
		[Token(Token = "0x4004535")]
		[FieldOffset(Offset = "0x60")]
		private List<MessageBubble> sendableBubbles;

		// Token: 0x04004536 RID: 17718
		[Token(Token = "0x4004536")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<MessageBubble, SendableMessage> sendableMap;

		// Token: 0x04004537 RID: 17719
		[Token(Token = "0x4004537")]
		[FieldOffset(Offset = "0x70")]
		private List<UISelectable> bubbleUISelectables;

		// Token: 0x02000D5A RID: 3418
		[Token(Token = "0x2000D5A")]
		public enum EVisibility
		{
			// Token: 0x0400453A RID: 17722
			[Token(Token = "0x400453A")]
			Hidden,
			// Token: 0x0400453B RID: 17723
			[Token(Token = "0x400453B")]
			Docked,
			// Token: 0x0400453C RID: 17724
			[Token(Token = "0x400453C")]
			Expanded
		}
	}
}
