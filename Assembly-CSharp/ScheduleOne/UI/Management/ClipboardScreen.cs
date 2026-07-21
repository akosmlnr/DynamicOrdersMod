using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class ClipboardScreen : MonoBehaviour
	{
		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x00018930 File Offset: 0x00016B30
		// (set) Token: 0x0600637F RID: 25471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E42")]
		public bool IsOpen
		{
			[Token(Token = "0x600637E")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600637F")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006380")]
		[Address(RVA = "0xA57250", Offset = "0xA56450", VA = "0x180A57250", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006381")]
		[Address(RVA = "0xA56FE0", Offset = "0xA561E0", VA = "0x180A56FE0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006382")]
		[Address(RVA = "0xA57200", Offset = "0xA56400", VA = "0x180A57200", Slot = "5")]
		public virtual void Open()
		{
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006383")]
		[Address(RVA = "0xA56F60", Offset = "0xA56160", VA = "0x180A56F60", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006384")]
		[Address(RVA = "0xA57040", Offset = "0xA56240", VA = "0x180A57040")]
		private void Lerp(bool open, Action callback)
		{
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006385")]
		[Address(RVA = "0xA573D0", Offset = "0xA565D0", VA = "0x180A573D0")]
		public ClipboardScreen()
		{
		}

		// Token: 0x040045B1 RID: 17841
		[Token(Token = "0x40045B1")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x040045B2 RID: 17842
		[Token(Token = "0x40045B2")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float ClosedOffset;

		// Token: 0x040045B3 RID: 17843
		[Token(Token = "0x40045B3")]
		[FieldOffset(Offset = "0x34")]
		public bool OpenOnStart;

		// Token: 0x040045B4 RID: 17844
		[Token(Token = "0x40045B4")]
		[FieldOffset(Offset = "0x35")]
		public bool UseExitListener;

		// Token: 0x040045B5 RID: 17845
		[Token(Token = "0x40045B5")]
		[FieldOffset(Offset = "0x38")]
		public int ExitActionPriority;

		// Token: 0x040045B6 RID: 17846
		[Token(Token = "0x40045B6")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine lerpRoutine;
	}
}
