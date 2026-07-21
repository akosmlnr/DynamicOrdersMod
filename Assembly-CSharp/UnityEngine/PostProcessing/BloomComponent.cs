using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x1700002A")]
		public override bool active
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x5666E0", Offset = "0x5658E0", VA = "0x1805666E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x565A80", Offset = "0x564C80", VA = "0x180565A80")]
		public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x566650", Offset = "0x565850", VA = "0x180566650")]
		public BloomComponent()
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		private const int k_MaxPyramidBlurLevel = 16;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[] m_BlurBuffer1;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x28")]
		private readonly RenderTexture[] m_BlurBuffer2;

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		private static class Uniforms
		{
			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _AutoExposure;

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Threshold;

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Curve;

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _PrefilterOffs;

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleScale;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _BaseTex;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _BloomTex;

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Bloom_Settings;

			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _Bloom_DirtTex;

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _Bloom_DirtIntensity;
		}
	}
}
