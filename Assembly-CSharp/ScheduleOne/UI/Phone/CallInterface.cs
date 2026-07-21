using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x2000D1B")]
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600618D RID: 24973 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600618E RID: 24974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E06")]
		public PhoneCallData ActiveCallData
		{
			[Token(Token = "0x600618D")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600618E")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600618F RID: 24975 RVA: 0x00018300 File Offset: 0x00016500
		// (set) Token: 0x06006190 RID: 24976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E07")]
		public bool IsOpen
		{
			[Token(Token = "0x600618F")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006190")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006191")]
		[Address(RVA = "0xA3B470", Offset = "0xA3A670", VA = "0x180A3B470", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006192")]
		[Address(RVA = "0xA3C8C0", Offset = "0xA3BAC0", VA = "0x180A3C8C0")]
		private void Update()
		{
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006193")]
		[Address(RVA = "0xA3BC50", Offset = "0xA3AE50", VA = "0x180A3BC50")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006194")]
		[Address(RVA = "0xA3C090", Offset = "0xA3B290", VA = "0x180A3C090")]
		public void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006195")]
		[Address(RVA = "0xA3BB60", Offset = "0xA3AD60", VA = "0x180A3BB60")]
		public void EndCall()
		{
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006196")]
		[Address(RVA = "0xA3B5C0", Offset = "0xA3A7C0", VA = "0x180A3B5C0")]
		private void Close()
		{
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006197")]
		[Address(RVA = "0xA3B9E0", Offset = "0xA3ABE0", VA = "0x180A3B9E0")]
		public void Continue()
		{
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006198")]
		[Address(RVA = "0xA3BF40", Offset = "0xA3B140", VA = "0x180A3BF40")]
		private void ShowStage(int stageIndex, float initialDelay = 0f)
		{
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006199")]
		[Address(RVA = "0xA3BD00", Offset = "0xA3AF00", VA = "0x180A3BD00")]
		private string ProcessText(string text)
		{
			return null;
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600619A")]
		[Address(RVA = "0xA3BCA0", Offset = "0xA3AEA0", VA = "0x180A3BCA0")]
		private string GetVisibleText(int charactersShown, string fullText)
		{
			return null;
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619B")]
		[Address(RVA = "0xA3BE60", Offset = "0xA3B060", VA = "0x180A3BE60")]
		private void SetIsVisible(bool visible)
		{
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619C")]
		[Address(RVA = "0xA3CAF0", Offset = "0xA3BCF0", VA = "0x180A3CAF0")]
		public CallInterface()
		{
		}

		// Token: 0x04004379 RID: 17273
		[Token(Token = "0x4004379")]
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x0400437C RID: 17276
		[Token(Token = "0x400437C")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400437D RID: 17277
		[Token(Token = "0x400437D")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Container;

		// Token: 0x0400437E RID: 17278
		[Token(Token = "0x400437E")]
		[FieldOffset(Offset = "0x48")]
		public Image ProfilePicture;

		// Token: 0x0400437F RID: 17279
		[Token(Token = "0x400437F")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04004380 RID: 17280
		[Token(Token = "0x4004380")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI MainText;

		// Token: 0x04004381 RID: 17281
		[Token(Token = "0x4004381")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform ContinuePrompt;

		// Token: 0x04004382 RID: 17282
		[Token(Token = "0x4004382")]
		[FieldOffset(Offset = "0x68")]
		public Animation OpenAnim;

		// Token: 0x04004383 RID: 17283
		[Token(Token = "0x4004383")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController TypewriterEffectSound;

		// Token: 0x04004384 RID: 17284
		[Token(Token = "0x4004384")]
		[FieldOffset(Offset = "0x78")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04004385 RID: 17285
		[Token(Token = "0x4004385")]
		[FieldOffset(Offset = "0x80")]
		[Header("Settings")]
		public Color Highlight1Color;

		// Token: 0x04004386 RID: 17286
		[Token(Token = "0x4004386")]
		[FieldOffset(Offset = "0x90")]
		private int currentCallStage;

		// Token: 0x04004387 RID: 17287
		[Token(Token = "0x4004387")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine slideRoutine;

		// Token: 0x04004388 RID: 17288
		[Token(Token = "0x4004388")]
		[FieldOffset(Offset = "0xA0")]
		private bool skipRollout;

		// Token: 0x04004389 RID: 17289
		[Token(Token = "0x4004389")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine rolloutRoutine;

		// Token: 0x0400438A RID: 17290
		[Token(Token = "0x400438A")]
		[FieldOffset(Offset = "0xB0")]
		private string highlight1Hex;

		// Token: 0x0400438B RID: 17291
		[Token(Token = "0x400438B")]
		[FieldOffset(Offset = "0xB8")]
		public Action<PhoneCallData> CallCompleted;

		// Token: 0x0400438C RID: 17292
		[Token(Token = "0x400438C")]
		[FieldOffset(Offset = "0xC0")]
		public Action<PhoneCallData> CallStarted;
	}
}
