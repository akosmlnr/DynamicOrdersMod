using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Clothing;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x0000F048 File Offset: 0x0000D248
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F5")]
		public bool IsPlaying
		{
			[Token(Token = "0x600307E")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600307F")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x7660B0", Offset = "0x7652B0", VA = "0x1807660B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x766880", Offset = "0x765A80", VA = "0x180766880")]
		private void Update()
		{
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x7662C0", Offset = "0x7654C0", VA = "0x1807662C0")]
		[Button]
		public void Play()
		{
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x766210", Offset = "0x765410", VA = "0x180766210")]
		private void PlayMusic()
		{
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003084")]
		[Address(RVA = "0x766120", Offset = "0x765320", VA = "0x180766120")]
		public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003085")]
		[Address(RVA = "0x6C1170", Offset = "0x6C0370", VA = "0x1806C1170")]
		public void PassedStep(int stepIndex)
		{
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003086")]
		[Address(RVA = "0x766B60", Offset = "0x765D60", VA = "0x180766B60")]
		public IntroManager()
		{
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003087")]
		[Address(RVA = "0x766810", Offset = "0x765A10", VA = "0x180766810")]
		[CompilerGenerated]
		private IEnumerator <Play>g__Wait|23_0()
		{
			return null;
		}

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		public const float SKIP_TIME = 0.5f;

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x2C")]
		public int CurrentStep;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public int TimeOfDayOverride;

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x40")]
		public Transform PlayerInitialPosition;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x48")]
		public Transform PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[FieldOffset(Offset = "0x50")]
		public Transform CameraContainer;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SkipContainer;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[FieldOffset(Offset = "0x68")]
		public Image SkipDial;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[FieldOffset(Offset = "0x70")]
		public GameObject[] DisableDuringIntro;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[FieldOffset(Offset = "0x78")]
		public RV rv;

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onIntroDone;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[FieldOffset(Offset = "0x90")]
		public string MusicName;

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0x98")]
		private float currentSkipTime;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0x9C")]
		private bool depressed;
	}
}
