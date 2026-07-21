using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	public class BoilingFlask : Fillable
	{
		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003C7E RID: 15486 RVA: 0x00011748 File Offset: 0x0000F948
		// (set) Token: 0x06003C7F RID: 15487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000977")]
		public float CurrentTemperature
		{
			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x494490", Offset = "0x493690", VA = "0x180494490")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003C7F")]
			[Address(RVA = "0x49B880", Offset = "0x49AA80", VA = "0x18049B880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x00011760 File Offset: 0x0000F960
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000978")]
		public float CurrentTemperatureVelocity
		{
			[Token(Token = "0x6003C80")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003C81")]
			[Address(RVA = "0x49B890", Offset = "0x49AA90", VA = "0x18049B890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x17000979")]
		public bool IsTemperatureInRange
		{
			[Token(Token = "0x6003C82")]
			[Address(RVA = "0x813E40", Offset = "0x813040", VA = "0x180813E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x00011790 File Offset: 0x0000F990
		// (set) Token: 0x06003C84 RID: 15492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097A")]
		public float OverheatScale
		{
			[Token(Token = "0x6003C83")]
			[Address(RVA = "0x4943B0", Offset = "0x4935B0", VA = "0x1804943B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003C84")]
			[Address(RVA = "0x813F00", Offset = "0x813100", VA = "0x180813F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C86 RID: 15494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097B")]
		public StationRecipe Recipe
		{
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C86")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x813930", Offset = "0x812B30", VA = "0x180813930")]
		public void Update()
		{
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x813100", Offset = "0x812300", VA = "0x180813100")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x813420", Offset = "0x812620", VA = "0x180813420")]
		private void UpdateCanvas()
		{
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x8137A0", Offset = "0x8129A0", VA = "0x1808137A0")]
		private void UpdateSmoke()
		{
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x8132A0", Offset = "0x8124A0", VA = "0x1808132A0")]
		public void SetCanvasVisible(bool visible)
		{
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x49B880", Offset = "0x49AA80", VA = "0x18049B880")]
		public void SetTemperature(float temp)
		{
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x8132E0", Offset = "0x8124E0", VA = "0x1808132E0")]
		public void SetRecipe(StationRecipe recipe)
		{
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x813DA0", Offset = "0x812FA0", VA = "0x180813DA0")]
		public BoilingFlask()
		{
		}

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		public const float TEMPERATURE_MAX = 500f;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[FieldOffset(Offset = "0x38")]
		public float TEMPERATURE_MAX_VELOCITY;

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[FieldOffset(Offset = "0x3C")]
		public float TEMPERATURE_ACCELERATION;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		public const float OVERHEAT_TIME = 1.25f;

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x58")]
		public bool LockTemperature;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve BoilSoundPitchCurve;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x68")]
		public float LabelJitterScale;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public BunsenBurner Burner;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x78")]
		public Canvas TemperatureCanvas;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI TemperatureLabel;

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		[FieldOffset(Offset = "0x88")]
		public Slider TemperatureSlider;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform TemperatureRangeIndicator;

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem SmokeParticles;

		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		[FieldOffset(Offset = "0xA0")]
		public AudioSourceController BoilSound;

		// Token: 0x04002C71 RID: 11377
		[Token(Token = "0x4002C71")]
		[FieldOffset(Offset = "0xA8")]
		public MeshRenderer OverheatMesh;
	}
}
