using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000033")]
		public override bool active
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x56C820", Offset = "0x56BA20", VA = "0x18056C820", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x506D00", Offset = "0x505F00", VA = "0x180506D00")]
		public void ResetHistory()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x506D00", Offset = "0x505F00", VA = "0x180506D00", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x56B800", Offset = "0x56AA00", VA = "0x18056B800", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x56B6E0", Offset = "0x56A8E0", VA = "0x18056B6E0")]
		private Vector4 GetHistogramScaleOffsetRes()
		{
			return default(Vector4);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x56BA80", Offset = "0x56AC80", VA = "0x18056BA80")]
		public Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x56B900", Offset = "0x56AB00", VA = "0x18056B900")]
		public void OnGUI()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x56C7B0", Offset = "0x56B9B0", VA = "0x18056C7B0")]
		public EyeAdaptationComponent()
		{
		}

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x20")]
		private ComputeShader m_EyeCompute;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_HistogramBuffer;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x30")]
		private readonly RenderTexture[] m_AutoExposurePool;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x38")]
		private int m_AutoExposurePingPing;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_CurrentAutoExposure;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_DebugHistogram;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x0")]
		private static uint[] s_EmptyHistogramBuffer;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x50")]
		private bool m_FirstFrame;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		private const int k_HistogramBins = 64;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		private const int k_HistogramThreadX = 16;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		private const int k_HistogramThreadY = 16;

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x2000084")]
		private static class Uniforms
		{
			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Params;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Speed;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _ScaleOffsetRes;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _ExposureCompensation;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _AutoExposure;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _DebugWidth;
		}
	}
}
