using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C81 RID: 3201
	[Token(Token = "0x2000C81")]
	public class ArrestScreen : Singleton<ArrestScreen>
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06005DC1 RID: 24001 RVA: 0x00017958 File Offset: 0x00015B58
		// (set) Token: 0x06005DC2 RID: 24002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8F")]
		public bool isOpen
		{
			[Token(Token = "0x6005DC1")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DC2")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0xA07B90", Offset = "0xA06D90", VA = "0x180A07B90", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC4")]
		[Address(RVA = "0xA07D20", Offset = "0xA06F20", VA = "0x180A07D20")]
		private void Continue()
		{
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0xA07DA0", Offset = "0xA06FA0", VA = "0x180A07DA0")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0xA07DB0", Offset = "0xA06FB0", VA = "0x180A07DB0")]
		public void Open()
		{
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC7")]
		[Address(RVA = "0xA07C10", Offset = "0xA06E10", VA = "0x180A07C10")]
		public void Close()
		{
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DC8")]
		[Address(RVA = "0xA07FC0", Offset = "0xA071C0", VA = "0x180A07FC0")]
		public ArrestScreen()
		{
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DC9")]
		[Address(RVA = "0xA07EE0", Offset = "0xA070E0", VA = "0x180A07EE0")]
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|9_0()
		{
			return null;
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DCA")]
		[Address(RVA = "0xA07F50", Offset = "0xA07150", VA = "0x180A07F50")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x04004042 RID: 16450
		[Token(Token = "0x4004042")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04004043 RID: 16451
		[Token(Token = "0x4004043")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup group;

		// Token: 0x04004044 RID: 16452
		[Token(Token = "0x4004044")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController Sound;

		// Token: 0x04004045 RID: 16453
		[Token(Token = "0x4004045")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;
	}
}
