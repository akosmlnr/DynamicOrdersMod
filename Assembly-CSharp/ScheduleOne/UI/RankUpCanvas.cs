using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class RankUpCanvas : MonoBehaviour, IPostSleepEvent
	{
		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x00017C10 File Offset: 0x00015E10
		// (set) Token: 0x06005EBC RID: 24252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBA")]
		public bool IsRunning
		{
			[Token(Token = "0x6005EBB")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005EBC")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x00017C28 File Offset: 0x00015E28
		// (set) Token: 0x06005EBE RID: 24254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBB")]
		public int Order
		{
			[Token(Token = "0x6005EBD")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005EBE")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0xA0F9E0", Offset = "0xA0EBE0", VA = "0x180A0F9E0")]
		public void Start()
		{
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0xA0F050", Offset = "0xA0E250", VA = "0x180A0F050")]
		private void QueuePostSleepEvent()
		{
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0xA0F1F0", Offset = "0xA0E3F0", VA = "0x180A0F1F0", Slot = "6")]
		public void StartEvent()
		{
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0xA0EA20", Offset = "0xA0DC20", VA = "0x180A0EA20")]
		public void EndEvent()
		{
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0xA0F0F0", Offset = "0xA0E2F0", VA = "0x180A0F0F0")]
		public void RankUp(FullRank oldRank, FullRank newRank)
		{
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0xA0EB50", Offset = "0xA0DD50", VA = "0x180A0EB50")]
		private void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0xA0FC70", Offset = "0xA0EE70", VA = "0x180A0FC70")]
		public RankUpCanvas()
		{
		}

		// Token: 0x0400410A RID: 16650
		[Token(Token = "0x400410A")]
		[FieldOffset(Offset = "0x28")]
		public Animation OpenCloseAnim;

		// Token: 0x0400410B RID: 16651
		[Token(Token = "0x400410B")]
		[FieldOffset(Offset = "0x30")]
		public Animation RankUpAnim;

		// Token: 0x0400410C RID: 16652
		[Token(Token = "0x400410C")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI OldRankLabel;

		// Token: 0x0400410D RID: 16653
		[Token(Token = "0x400410D")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI NewRankLabel;

		// Token: 0x0400410E RID: 16654
		[Token(Token = "0x400410E")]
		[FieldOffset(Offset = "0x48")]
		public Canvas Canvas;

		// Token: 0x0400410F RID: 16655
		[Token(Token = "0x400410F")]
		[FieldOffset(Offset = "0x50")]
		public UIScreen UIScreen;

		// Token: 0x04004110 RID: 16656
		[Token(Token = "0x4004110")]
		[FieldOffset(Offset = "0x58")]
		public UIPanel LevelUpPanel;

		// Token: 0x04004111 RID: 16657
		[Token(Token = "0x4004111")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UnlockedItemsContainer;

		// Token: 0x04004112 RID: 16658
		[Token(Token = "0x4004112")]
		[FieldOffset(Offset = "0x68")]
		public CanvasGroup UnlockedItemsCanvasGroup;

		// Token: 0x04004113 RID: 16659
		[Token(Token = "0x4004113")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform[] UnlockedItems;

		// Token: 0x04004114 RID: 16660
		[Token(Token = "0x4004114")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI ExtraUnlocksLabel;

		// Token: 0x04004115 RID: 16661
		[Token(Token = "0x4004115")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController SoundEffect;

		// Token: 0x04004116 RID: 16662
		[Token(Token = "0x4004116")]
		[FieldOffset(Offset = "0x88")]
		public Slider ProgressSlider;

		// Token: 0x04004117 RID: 16663
		[Token(Token = "0x4004117")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x04004118 RID: 16664
		[Token(Token = "0x4004118")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController BlipSound;

		// Token: 0x04004119 RID: 16665
		[Token(Token = "0x4004119")]
		[FieldOffset(Offset = "0xA0")]
		public AudioSourceController ClickSound;

		// Token: 0x0400411A RID: 16666
		[Token(Token = "0x400411A")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine coroutine;

		// Token: 0x0400411B RID: 16667
		[Token(Token = "0x400411B")]
		[FieldOffset(Offset = "0xB0")]
		private List<Tuple<FullRank, FullRank>> queuedRankUps;
	}
}
