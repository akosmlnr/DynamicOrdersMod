using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06005C05 RID: 23557 RVA: 0x00017478 File Offset: 0x00015678
		// (set) Token: 0x06005C06 RID: 23558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D53")]
		public bool IsOpen
		{
			[Token(Token = "0x6005C05")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C06")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00017490 File Offset: 0x00015690
		[Token(Token = "0x17000D54")]
		public bool CharacterScreenEnabled
		{
			[Token(Token = "0x6005C07")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x000174A8 File Offset: 0x000156A8
		// (set) Token: 0x06005C09 RID: 23561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D55")]
		public GameplayMenu.EGameplayScreen CurrentScreen
		{
			[Token(Token = "0x6005C08")]
			[Address(RVA = "0x6A20F0", Offset = "0x6A12F0", VA = "0x1806A20F0")]
			[CompilerGenerated]
			get
			{
				return GameplayMenu.EGameplayScreen.Phone;
			}
			[Token(Token = "0x6005C09")]
			[Address(RVA = "0x6C1170", Offset = "0x6C0370", VA = "0x1806C1170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x9CF930", Offset = "0x9CEB30", VA = "0x1809CF930", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x9CED40", Offset = "0x9CDF40", VA = "0x1809CED40")]
		public void Exit(ExitAction exit)
		{
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x9CFC30", Offset = "0x9CEE30", VA = "0x1809CFC30", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x9CF6E0", Offset = "0x9CE8E0", VA = "0x1809CF6E0")]
		public void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x9CEE10", Offset = "0x9CE010", VA = "0x1809CEE10")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x9CFFD0", Offset = "0x9CF1D0", VA = "0x1809CFFD0")]
		public GameplayMenu()
		{
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x9CFB30", Offset = "0x9CED30", VA = "0x1809CFB30")]
		[CompilerGenerated]
		private void <Update>g__PrepAppOpen|22_0()
		{
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x9CFAB0", Offset = "0x9CECB0", VA = "0x1809CFAB0")]
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__SetIsOpenRoutine|24_0(bool open)
		{
			return null;
		}

		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		public const float OpenVerticalOffset = 0.02f;

		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		public const float ClosedVerticalOffset = -2f;

		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		public const float OpenTime = 0.06f;

		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		public const float SlideTime = 0.12f;

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Camera OverlayCamera;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[FieldOffset(Offset = "0x38")]
		public Light OverlayLight;

		// Token: 0x04003E56 RID: 15958
		[Token(Token = "0x4003E56")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public float ContainerOffset_PhoneScreen;

		// Token: 0x04003E57 RID: 15959
		[Token(Token = "0x4003E57")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine openCloseRoutine;

		// Token: 0x04003E58 RID: 15960
		[Token(Token = "0x4003E58")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine screenChangeRoutine;

		// Token: 0x02000C45 RID: 3141
		[Token(Token = "0x2000C45")]
		public enum EGameplayScreen
		{
			// Token: 0x04003E5A RID: 15962
			[Token(Token = "0x4003E5A")]
			Phone,
			// Token: 0x04003E5B RID: 15963
			[Token(Token = "0x4003E5B")]
			Character
		}
	}
}
