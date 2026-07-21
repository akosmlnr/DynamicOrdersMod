using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20009A8")]
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00012FF0 File Offset: 0x000111F0
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB6")]
		public bool Pressed
		{
			[Token(Token = "0x6004489")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600448A")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x8A0940", Offset = "0x89FB40", VA = "0x1808A0940")]
		private void Start()
		{
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x8A0880", Offset = "0x89FA80", VA = "0x1808A0880")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448D")]
		[Address(RVA = "0x8A07F0", Offset = "0x89F9F0", VA = "0x1808A07F0")]
		public void Press(RaycastHit hit)
		{
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448E")]
		[Address(RVA = "0x8A08A0", Offset = "0x89FAA0", VA = "0x1808A08A0")]
		public void SetPressed(bool pressed)
		{
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x8A0A50", Offset = "0x89FC50", VA = "0x1808A0A50")]
		private void Update()
		{
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LabOvenButton()
		{
		}

		// Token: 0x0400312A RID: 12586
		[Token(Token = "0x400312A")]
		private const float ANIMATION_TIME = 0.2f;

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x28")]
		public Transform Button;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x30")]
		public Transform PressedTransform;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x38")]
		public Transform DepressedTransform;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x40")]
		public ToggleableLight Light;

		// Token: 0x04003130 RID: 12592
		[Token(Token = "0x4003130")]
		[FieldOffset(Offset = "0x48")]
		public Clickable Clickable;

		// Token: 0x04003131 RID: 12593
		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x50")]
		private float animationTimer;

		// Token: 0x04003132 RID: 12594
		[Token(Token = "0x4003132")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 animationStartPos;

		// Token: 0x04003133 RID: 12595
		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 animationEndPos;
	}
}
