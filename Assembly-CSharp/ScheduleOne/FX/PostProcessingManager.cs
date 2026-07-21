using System;
using Beautify.Universal;
using CorgiGodRays;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x06002B63 RID: 11107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x705170", Offset = "0x704370", VA = "0x180705170", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x705FF0", Offset = "0x7051F0", VA = "0x180705FF0")]
		public void Update()
		{
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x7057F0", Offset = "0x7049F0", VA = "0x1807057F0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x705CA0", Offset = "0x704EA0", VA = "0x180705CA0")]
		private void UpdateEffects()
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x7058A0", Offset = "0x704AA0", VA = "0x1807058A0")]
		public void OverrideVignette(float intensity, float smoothness)
		{
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x705950", Offset = "0x704B50", VA = "0x180705950")]
		public void ResetVignette()
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x705AC0", Offset = "0x704CC0", VA = "0x180705AC0")]
		public void SetGodRayIntensity(float intensity)
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x705A80", Offset = "0x704C80", VA = "0x180705A80")]
		public void SetContrast(float value)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x705C70", Offset = "0x704E70", VA = "0x180705C70")]
		public void SetSaturation(float value)
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x7059C0", Offset = "0x704BC0", VA = "0x1807059C0")]
		public void SetBloomThreshold(float threshold)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x705A00", Offset = "0x704C00", VA = "0x180705A00")]
		public void SetBlur(float blurLevel)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x705B00", Offset = "0x704D00", VA = "0x180705B00")]
		public void SetPsychedelicEffectActive(bool isActive)
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x705B90", Offset = "0x704D90", VA = "0x180705B90")]
		public void SetPsychedelicEffectProperties(PsychedelicFullScreenData data)
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x705C40", Offset = "0x704E40", VA = "0x180705C40")]
		public void SetPsychedelicEffectProperties(PsychedelicFullScreenFeature.MaterialProperties properties)
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x705790", Offset = "0x704990", VA = "0x180705790")]
		public PsychedelicFullScreenFeature.MaterialProperties GetActivePsychedelicEffectProperties()
		{
			return null;
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x7057C0", Offset = "0x7049C0", VA = "0x1807057C0")]
		public PsychedelicFullScreenData GetPsychedelicEffectDataPreset(string presetName)
		{
			return null;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x705920", Offset = "0x704B20", VA = "0x180705920")]
		public void PrintValueOfPsychedelicEffectBlend()
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x706000", Offset = "0x705200", VA = "0x180706000")]
		public PostProcessingManager()
		{
		}

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public UniversalRendererData rendererData;

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x30")]
		public Volume GlobalVolume;

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		[FieldOffset(Offset = "0x38")]
		[Header("Vignette")]
		public float Vig_DefaultIntensity;

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		[FieldOffset(Offset = "0x3C")]
		public float Vig_DefaultSmoothness;

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		[FieldOffset(Offset = "0x40")]
		[Header("Blur")]
		public float MinBlur;

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		[FieldOffset(Offset = "0x44")]
		public float MaxBlur;

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		[FieldOffset(Offset = "0x48")]
		[Header("Post exposre")]
		public AnimationCurve PostExposureCurve;

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		[FieldOffset(Offset = "0x50")]
		public float PostExposureMultiplier;

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		[FieldOffset(Offset = "0x58")]
		[Header("Bloom")]
		public AnimationCurve BloomIntensityCurve;

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		[FieldOffset(Offset = "0x60")]
		[Header("Smoothers")]
		public FloatSmoother ChromaticAberrationController;

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		[FieldOffset(Offset = "0x68")]
		public FloatSmoother SaturationController;

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		[FieldOffset(Offset = "0x70")]
		public FloatSmoother BloomController;

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		[FieldOffset(Offset = "0x78")]
		public HDRColorSmoother ColorFilterController;

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		[FieldOffset(Offset = "0x80")]
		private Vignette vig;

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		[FieldOffset(Offset = "0x88")]
		private DepthOfField DoF;

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		[FieldOffset(Offset = "0x90")]
		private GodRaysVolume GodRays;

		// Token: 0x040020A8 RID: 8360
		[Token(Token = "0x40020A8")]
		[FieldOffset(Offset = "0x98")]
		private ColorAdjustments ColorAdjustments;

		// Token: 0x040020A9 RID: 8361
		[Token(Token = "0x40020A9")]
		[FieldOffset(Offset = "0xA0")]
		private Beautify beautifySettings;

		// Token: 0x040020AA RID: 8362
		[Token(Token = "0x40020AA")]
		[FieldOffset(Offset = "0xA8")]
		private Bloom bloom;

		// Token: 0x040020AB RID: 8363
		[Token(Token = "0x40020AB")]
		[FieldOffset(Offset = "0xB0")]
		private ChromaticAberration chromaticAberration;

		// Token: 0x040020AC RID: 8364
		[Token(Token = "0x40020AC")]
		[FieldOffset(Offset = "0xB8")]
		private ColorAdjustments colorAdjustments;

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		[FieldOffset(Offset = "0xC0")]
		private PsychedelicFullScreenFeature _psychedelicFullScreenFeature;
	}
}
