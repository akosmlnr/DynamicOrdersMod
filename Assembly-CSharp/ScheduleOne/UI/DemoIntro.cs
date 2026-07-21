using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C34 RID: 3124
	[Token(Token = "0x2000C34")]
	public class DemoIntro : Singleton<DemoIntro>
	{
		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x00017358 File Offset: 0x00015558
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D42")]
		public bool IsPlaying
		{
			[Token(Token = "0x6005B98")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B99")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x9CA9F0", Offset = "0x9C9BF0", VA = "0x1809CA9F0")]
		private void Update()
		{
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x9CA620", Offset = "0x9C9820", VA = "0x1809CA620")]
		[Button]
		public void Play()
		{
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x9CA540", Offset = "0x9C9740", VA = "0x1809CA540")]
		private void PlayMusic()
		{
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x9CA8B0", Offset = "0x9C9AB0", VA = "0x1809CA8B0")]
		public void ShowAvatar()
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x9CA3D0", Offset = "0x9C95D0", VA = "0x1809CA3D0")]
		public void CutsceneDone()
		{
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x4D4B00", Offset = "0x4D3D00", VA = "0x1804D4B00")]
		public void PassedStep(int stepIndex)
		{
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0x9CA350", Offset = "0x9C9550", VA = "0x1809CA350")]
		public void CharacterCreationDone(BasicAvatarSettings avatar)
		{
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x9CAE60", Offset = "0x9CA060", VA = "0x1809CAE60")]
		public DemoIntro()
		{
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x9CA980", Offset = "0x9C9B80", VA = "0x1809CA980")]
		[CompilerGenerated]
		private IEnumerator <CharacterCreationDone>g__Wait|26_0()
		{
			return null;
		}

		// Token: 0x04003DF2 RID: 15858
		[Token(Token = "0x4003DF2")]
		public const float SKIP_TIME = 0.5f;

		// Token: 0x04003DF4 RID: 15860
		[Token(Token = "0x4003DF4")]
		[FieldOffset(Offset = "0x30")]
		public Animation Anim;

		// Token: 0x04003DF5 RID: 15861
		[Token(Token = "0x4003DF5")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlayerInitialPosition;

		// Token: 0x04003DF6 RID: 15862
		[Token(Token = "0x4003DF6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SkipContainer;

		// Token: 0x04003DF7 RID: 15863
		[Token(Token = "0x4003DF7")]
		[FieldOffset(Offset = "0x48")]
		public Image SkipDial;

		// Token: 0x04003DF8 RID: 15864
		[Token(Token = "0x4003DF8")]
		[FieldOffset(Offset = "0x50")]
		public int SkipEvents;

		// Token: 0x04003DF9 RID: 15865
		[Token(Token = "0x4003DF9")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onStart;

		// Token: 0x04003DFA RID: 15866
		[Token(Token = "0x4003DFA")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onStartAsServer;

		// Token: 0x04003DFB RID: 15867
		[Token(Token = "0x4003DFB")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onCutsceneDone;

		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onIntroDone;

		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		[FieldOffset(Offset = "0x80")]
		private int CurrentStep;

		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		[FieldOffset(Offset = "0x88")]
		public string MusicName;

		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x90")]
		private float currentSkipTime;

		// Token: 0x04003E01 RID: 15873
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x94")]
		private bool depressed;

		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x95")]
		private bool waitingForCutsceneEnd;
	}
}
