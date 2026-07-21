using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000027")]
		private AmbientOcclusionComponent.OcclusionSource occlusionSource
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x565400", Offset = "0x564600", VA = "0x180565400")]
			get
			{
				return AmbientOcclusionComponent.OcclusionSource.DepthTexture;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000028")]
		private bool ambientOnlySupported
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x565370", Offset = "0x564570", VA = "0x180565370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000029")]
		public override bool active
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x565300", Offset = "0x564500", VA = "0x180565300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x564700", Offset = "0x563900", VA = "0x180564700", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x564740", Offset = "0x563940", VA = "0x180564740", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x564690", Offset = "0x563890", VA = "0x180564690", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x564770", Offset = "0x563970", VA = "0x180564770", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x565210", Offset = "0x564410", VA = "0x180565210")]
		public AmbientOcclusionComponent()
		{
		}

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		private const string k_BlitShaderString = "Hidden/Post FX/Blit";

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTargetIdentifier[] m_MRT;

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		private static class Uniforms
		{
			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Intensity;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Radius;

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _FogParams;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _Downsample;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleCount;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _OcclusionTexture1;

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _OcclusionTexture2;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _OcclusionTexture;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _MainTex;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _TempRT;
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		private enum OcclusionSource
		{
			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			DepthTexture,
			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			DepthNormalsTexture,
			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			GBuffer
		}
	}
}
