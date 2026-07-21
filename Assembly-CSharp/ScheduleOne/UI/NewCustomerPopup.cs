using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C6B RID: 3179
	[Token(Token = "0x2000C6B")]
	public class NewCustomerPopup : Singleton<NewCustomerPopup>
	{
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x000176B8 File Offset: 0x000158B8
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D78")]
		public bool IsPlaying
		{
			[Token(Token = "0x6005D10")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D11")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D12")]
		[Address(RVA = "0x9E3DB0", Offset = "0x9E2FB0", VA = "0x1809E3DB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D13")]
		[Address(RVA = "0x9E3EC0", Offset = "0x9E30C0", VA = "0x1809E3EC0")]
		public void PlayPopup(Customer customer)
		{
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D14")]
		[Address(RVA = "0x9E3E30", Offset = "0x9E3030", VA = "0x1809E3E30")]
		private void DisableEntries()
		{
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x9E42A0", Offset = "0x9E34A0", VA = "0x1809E42A0")]
		public NewCustomerPopup()
		{
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x9E4230", Offset = "0x9E3430", VA = "0x1809E4230")]
		[CompilerGenerated]
		private IEnumerator <PlayPopup>g__Routine|13_0()
		{
			return null;
		}

		// Token: 0x04003F81 RID: 16257
		[Token(Token = "0x4003F81")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003F82 RID: 16258
		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003F83 RID: 16259
		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x04003F84 RID: 16260
		[Token(Token = "0x4003F84")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;

		// Token: 0x04003F85 RID: 16261
		[Token(Token = "0x4003F85")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Title;

		// Token: 0x04003F86 RID: 16262
		[Token(Token = "0x4003F86")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform[] Entries;

		// Token: 0x04003F87 RID: 16263
		[Token(Token = "0x4003F87")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController SoundEffect;

		// Token: 0x04003F88 RID: 16264
		[Token(Token = "0x4003F88")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine routine;
	}
}
