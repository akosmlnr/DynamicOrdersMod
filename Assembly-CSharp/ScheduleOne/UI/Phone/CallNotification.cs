using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D1E RID: 3358
	[Token(Token = "0x2000D1E")]
	public class CallNotification : Singleton<CallNotification>
	{
		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060061A6 RID: 24998 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060061A7 RID: 24999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E0A")]
		public PhoneCallData ActiveCallData
		{
			[Token(Token = "0x60061A6")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60061A7")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060061A8 RID: 25000 RVA: 0x00018330 File Offset: 0x00016530
		// (set) Token: 0x060061A9 RID: 25001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E0B")]
		public bool IsOpen
		{
			[Token(Token = "0x60061A8")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60061A9")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0xA3CB40", Offset = "0xA3BD40", VA = "0x180A3CB40", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0xA3CBF0", Offset = "0xA3BDF0", VA = "0x180A3CBF0")]
		public void SetIsOpen(bool visible, CallerID caller)
		{
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0xA3CD10", Offset = "0xA3BF10", VA = "0x180A3CD10")]
		public CallNotification()
		{
		}

		// Token: 0x04004396 RID: 17302
		[Token(Token = "0x4004396")]
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x04004399 RID: 17305
		[Token(Token = "0x4004399")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x0400439A RID: 17306
		[Token(Token = "0x400439A")]
		[FieldOffset(Offset = "0x40")]
		public Image ProfilePicture;

		// Token: 0x0400439B RID: 17307
		[Token(Token = "0x400439B")]
		[FieldOffset(Offset = "0x48")]
		public CanvasGroup Group;

		// Token: 0x0400439C RID: 17308
		[Token(Token = "0x400439C")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine slideRoutine;
	}
}
