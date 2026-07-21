using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CD")]
		public string CurrentEmotion
		{
			[Token(Token = "0x6003737")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CE")]
		public AvatarEmotionPreset CurrentEmotionPreset
		{
			[Token(Token = "0x6003739")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600373A")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x170008CF")]
		public bool IsSwitchingEmotion
		{
			[Token(Token = "0x600373B")]
			[Address(RVA = "0x7E6110", Offset = "0x7E5310", VA = "0x1807E6110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x7E5AD0", Offset = "0x7E4CD0", VA = "0x1807E5AD0")]
		private void Start()
		{
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x7E5C90", Offset = "0x7E4E90", VA = "0x1807E5C90")]
		public void UpdateEmotion()
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x7E5180", Offset = "0x7E4380", VA = "0x1807E5180")]
		public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x7E4C60", Offset = "0x7E3E60", VA = "0x1807E4C60", Slot = "4")]
		public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x7E57F0", Offset = "0x7E49F0", VA = "0x1807E57F0")]
		public void RemoveEmotionOverride(string label)
		{
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x7E4F90", Offset = "0x7E4190", VA = "0x1807E4F90")]
		public void ClearOverrides()
		{
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x7E5070", Offset = "0x7E4270", VA = "0x1807E5070")]
		private void ClearRemovalRoutine(string label)
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x7E54D0", Offset = "0x7E46D0", VA = "0x1807E54D0")]
		public EmotionOverride GetHighestPriorityOverride()
		{
			return null;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x7E5640", Offset = "0x7E4840", VA = "0x1807E5640")]
		private void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x7E5910", Offset = "0x7E4B10", VA = "0x1807E5910")]
		private void SetEmotion(AvatarEmotionPreset preset)
		{
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x7E5620", Offset = "0x7E4820", VA = "0x1807E5620")]
		public bool HasEmotion(string emotion)
		{
			return default(bool);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x7E53F0", Offset = "0x7E45F0", VA = "0x1807E53F0")]
		public AvatarEmotionPreset GetEmotion(string emotion)
		{
			return null;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x7E5FE0", Offset = "0x7E51E0", VA = "0x1807E5FE0")]
		public AvatarEmotionManager()
		{
		}

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		public const float MAX_UPDATE_DISTANCE = 30f;

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public List<AvatarEmotionPreset> EmotionPresetList;

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Avatar Avatar;

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x40")]
		public EyeController EyeController;

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x48")]
		public EyebrowController EyebrowController;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x50")]
		private EmotionOverride activeEmotionOverride;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x58")]
		private List<EmotionOverride> overrideStack;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x60")]
		private AvatarEmotionPreset neutralPreset;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine emotionLerpRoutine;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, Coroutine> emotionRemovalRoutines;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x78")]
		private int tempIndex;
	}
}
