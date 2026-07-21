using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D19 RID: 3353
	[Token(Token = "0x2000D19")]
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x0600617D RID: 24957 RVA: 0x000182D0 File Offset: 0x000164D0
		// (set) Token: 0x0600617E RID: 24958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E03")]
		public bool isOpen
		{
			[Token(Token = "0x600617D")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600617E")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600617F")]
		[Address(RVA = "0xA3AF40", Offset = "0xA3A140", VA = "0x180A3AF40", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006180")]
		[Address(RVA = "0xA3B040", Offset = "0xA3A240", VA = "0x180A3B040", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006181")]
		[Address(RVA = "0xA3B340", Offset = "0xA3A540", VA = "0x180A3B340")]
		protected void PhoneOpened()
		{
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006182")]
		[Address(RVA = "0xA3B2B0", Offset = "0xA3A4B0", VA = "0x180A3B2B0")]
		protected void PhoneClosed()
		{
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006183")]
		[Address(RVA = "0xA3AFB0", Offset = "0xA3A1B0", VA = "0x180A3AFB0")]
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			return null;
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006184")]
		[Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
		public void SetIsOpen(bool o)
		{
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006185")]
		[Address(RVA = "0xA3B390", Offset = "0xA3A590", VA = "0x180A3B390")]
		private void SetCanvasActive(bool a)
		{
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006186")]
		[Address(RVA = "0xA3B430", Offset = "0xA3A630", VA = "0x180A3B430")]
		public AppsCanvas()
		{
		}

		// Token: 0x04004372 RID: 17266
		[Token(Token = "0x4004372")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04004373 RID: 17267
		[Token(Token = "0x4004373")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine delayedSetOpenRoutine;
	}
}
