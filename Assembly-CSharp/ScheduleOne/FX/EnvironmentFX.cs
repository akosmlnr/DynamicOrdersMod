using System;
using Funly.SkyStudio;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using VolumetricFogAndMist2;

namespace ScheduleOne.FX
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x17000773")]
		public float normalizedEnvironmentalBrightness
		{
			[Token(Token = "0x6002B3F")]
			[Address(RVA = "0x701100", Offset = "0x700300", VA = "0x180701100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x17000774")]
		public float FogEndDistanceMultiplier
		{
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x7010D0", Offset = "0x7002D0", VA = "0x1807010D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x7006E0", Offset = "0x6FF8E0", VA = "0x1807006E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x7008E0", Offset = "0x6FFAE0", VA = "0x1807008E0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x700880", Offset = "0x6FFA80", VA = "0x180700880", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x700FE0", Offset = "0x7001E0", VA = "0x180700FE0")]
		private void Update()
		{
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x700930", Offset = "0x6FFB30", VA = "0x180700930")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x7008C0", Offset = "0x6FFAC0", VA = "0x1807008C0")]
		public void SetEnvironmentScrollingActive(bool active)
		{
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x7008D0", Offset = "0x6FFAD0", VA = "0x1807008D0")]
		public void SetEnvironmentScrollingSpeedByPercentage(float percentage)
		{
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x701060", Offset = "0x700260", VA = "0x180701060")]
		public EnvironmentFX()
		{
		}

		// Token: 0x04002060 RID: 8288
		[Token(Token = "0x4002060")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected TimeOfDayController timeOfDayController;

		// Token: 0x04002061 RID: 8289
		[Token(Token = "0x4002061")]
		[FieldOffset(Offset = "0x30")]
		public VolumetricFog VolumetricFog;

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x38")]
		public Light SunLight;

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x40")]
		public Light MoonLight;

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x48")]
		[Header("Height Fog")]
		[SerializeField]
		protected Gradient HeightFogColor;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected AnimationCurve HeightFogIntensityCurve;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float HeightFogIntensityMultiplier;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected AnimationCurve HeightFogDirectionalIntensityCurve;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x68")]
		[Header("Volumetric Fog")]
		[SerializeField]
		protected AnimationCurve VolumetricFogIntensityCurve;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected float VolumetricFogIntensityMultiplier;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected float VolumetricFogSaturationMultiplier;

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Fog")]
		private float fogEndDistanceMultiplier;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("God rays")]
		protected AnimationCurve godRayIntensityCurve;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Contrast")]
		protected AnimationCurve contrastCurve;

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected float contractMultiplier;

		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		[FieldOffset(Offset = "0x98")]
		[Header("Saturation")]
		[SerializeField]
		protected AnimationCurve saturationCurve;

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected float saturationMultiplier;

		// Token: 0x04002071 RID: 8305
		[Token(Token = "0x4002071")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Header("Grass")]
		protected Material grassMat;

		// Token: 0x04002072 RID: 8306
		[Token(Token = "0x4002072")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected Gradient grassColorGradient;

		// Token: 0x04002073 RID: 8307
		[Token(Token = "0x4002073")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Trees")]
		public Material distanceTreeMat;

		// Token: 0x04002074 RID: 8308
		[Token(Token = "0x4002074")]
		[FieldOffset(Offset = "0xC0")]
		public AnimationCurve distanceTreeColorCurve;

		// Token: 0x04002075 RID: 8309
		[Token(Token = "0x4002075")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Stealth settings")]
		public AnimationCurve environmentalBrightnessCurve;

		// Token: 0x04002076 RID: 8310
		[Token(Token = "0x4002076")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Bloom")]
		public AnimationCurve bloomThreshholdCurve;

		// Token: 0x04002077 RID: 8311
		[Token(Token = "0x4002077")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Gloabl Shader Properties")]
		[SerializeField]
		private float _environmentScrollSpeed;

		// Token: 0x04002078 RID: 8312
		[Token(Token = "0x4002078")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float _testPercentage;

		// Token: 0x04002079 RID: 8313
		[Token(Token = "0x4002079")]
		[FieldOffset(Offset = "0xE0")]
		public FloatSmoother FogEndDistanceController;

		// Token: 0x0400207A RID: 8314
		[Token(Token = "0x400207A")]
		[FieldOffset(Offset = "0xE8")]
		private float _scrollTime;

		// Token: 0x0400207B RID: 8315
		[Token(Token = "0x400207B")]
		[FieldOffset(Offset = "0xEC")]
		private float _scrollValue;

		// Token: 0x0400207C RID: 8316
		[Token(Token = "0x400207C")]
		[FieldOffset(Offset = "0xF0")]
		private bool _scrollTActive;

		// Token: 0x0400207D RID: 8317
		[Token(Token = "0x400207D")]
		[FieldOffset(Offset = "0xF4")]
		private Color _defaultDistantTreeMatColor;

		// Token: 0x0400207E RID: 8318
		[Token(Token = "0x400207E")]
		[FieldOffset(Offset = "0x104")]
		private Color _defaultGrassMatColor;
	}
}
