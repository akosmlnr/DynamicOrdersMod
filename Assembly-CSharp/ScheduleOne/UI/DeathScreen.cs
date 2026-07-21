using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C86 RID: 3206
	[Token(Token = "0x2000C86")]
	public class DeathScreen : Singleton<DeathScreen>
	{
		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x000179B8 File Offset: 0x00015BB8
		// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D96")]
		public bool isOpen
		{
			[Token(Token = "0x6005DE1")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DE2")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0xA08770", Offset = "0xA07970", VA = "0x180A08770", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0xA08DD0", Offset = "0xA07FD0", VA = "0x180A08DD0")]
		private void RespawnClicked()
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0xA08A90", Offset = "0xA07C90", VA = "0x180A08A90")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0xA08B80", Offset = "0xA07D80", VA = "0x180A08B80")]
		public void Open()
		{
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0xA088E0", Offset = "0xA07AE0", VA = "0x180A088E0")]
		private bool CanRespawn()
		{
			return default(bool);
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0xA08950", Offset = "0xA07B50", VA = "0x180A08950")]
		public void Close()
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0xA08F30", Offset = "0xA08130", VA = "0x180A08F30")]
		public DeathScreen()
		{
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0xA08EC0", Offset = "0xA080C0", VA = "0x180A08EC0")]
		[CompilerGenerated]
		private IEnumerator <RespawnClicked>g__Routine|13_0()
		{
			return null;
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0xA08E50", Offset = "0xA08050", VA = "0x180A08E50")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|15_0()
		{
			return null;
		}

		// Token: 0x04004060 RID: 16480
		[Token(Token = "0x4004060")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04004061 RID: 16481
		[Token(Token = "0x4004061")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04004062 RID: 16482
		[Token(Token = "0x4004062")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup group;

		// Token: 0x04004063 RID: 16483
		[Token(Token = "0x4004063")]
		[FieldOffset(Offset = "0x48")]
		public Button respawnButton;

		// Token: 0x04004064 RID: 16484
		[Token(Token = "0x4004064")]
		[FieldOffset(Offset = "0x50")]
		public Button loadSaveButton;

		// Token: 0x04004065 RID: 16485
		[Token(Token = "0x4004065")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x04004066 RID: 16486
		[Token(Token = "0x4004066")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController Sound;

		// Token: 0x04004067 RID: 16487
		[Token(Token = "0x4004067")]
		[FieldOffset(Offset = "0x68")]
		private bool arrested;
	}
}
