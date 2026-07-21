using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x1700003A")]
		public override bool active
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x573AC0", Offset = "0x572CC0", VA = "0x180573AC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x572550", Offset = "0x571750", VA = "0x180572550", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x572520", Offset = "0x571720", VA = "0x180572520", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x572510", Offset = "0x571710", VA = "0x180572510", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x572670", Offset = "0x571870", VA = "0x180572670", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x573A50", Offset = "0x572C50", VA = "0x180573A50")]
		public ScreenSpaceReflectionComponent()
		{
		}

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x20")]
		private bool k_HighlightSuppression;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x21")]
		private bool k_TraceBehindObjects;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x22")]
		private bool k_TreatBackfaceHitAsMiss;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x23")]
		private bool k_BilateralUpsample;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x28")]
		private readonly int[] m_ReflectionTextures;

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		private static class Uniforms
		{
			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _RayStepSize;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _AdditiveReflection;

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _BilateralUpsampling;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _TreatBackfaceHitAsMiss;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _AllowBackwardsRays;

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _TraceBehindObjects;

			// Token: 0x040002DA RID: 730
			[Token(Token = "0x40002DA")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _MaxSteps;

			// Token: 0x040002DB RID: 731
			[Token(Token = "0x40002DB")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _FullResolutionFiltering;

			// Token: 0x040002DC RID: 732
			[Token(Token = "0x40002DC")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _HalfResolution;

			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _HighlightSuppression;

			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _PixelsPerMeterAtOneMeter;

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _ScreenEdgeFading;

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _ReflectionBlur;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _MaxRayTraceDistance;

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _FadeDistance;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _LayerThickness;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _SSRMultiplier;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _FresnelFade;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _FresnelFadePower;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _ReflectionBufferSize;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x50")]
			internal static readonly int _ScreenSize;

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x54")]
			internal static readonly int _InvScreenSize;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x58")]
			internal static readonly int _ProjInfo;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x5C")]
			internal static readonly int _CameraClipInfo;

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x60")]
			internal static readonly int _ProjectToPixelMatrix;

			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x64")]
			internal static readonly int _WorldToCameraMatrix;

			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x68")]
			internal static readonly int _CameraToWorldMatrix;

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x6C")]
			internal static readonly int _Axis;

			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x70")]
			internal static readonly int _CurrentMipLevel;

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x74")]
			internal static readonly int _NormalAndRoughnessTexture;

			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0x78")]
			internal static readonly int _HitPointTexture;

			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x7C")]
			internal static readonly int _BlurTexture;

			// Token: 0x040002F4 RID: 756
			[Token(Token = "0x40002F4")]
			[FieldOffset(Offset = "0x80")]
			internal static readonly int _FilteredReflections;

			// Token: 0x040002F5 RID: 757
			[Token(Token = "0x40002F5")]
			[FieldOffset(Offset = "0x84")]
			internal static readonly int _FinalReflectionTexture;

			// Token: 0x040002F6 RID: 758
			[Token(Token = "0x40002F6")]
			[FieldOffset(Offset = "0x88")]
			internal static readonly int _TempTexture;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		private enum PassIndex
		{
			// Token: 0x040002F8 RID: 760
			[Token(Token = "0x40002F8")]
			RayTraceStep,
			// Token: 0x040002F9 RID: 761
			[Token(Token = "0x40002F9")]
			CompositeFinal,
			// Token: 0x040002FA RID: 762
			[Token(Token = "0x40002FA")]
			Blur,
			// Token: 0x040002FB RID: 763
			[Token(Token = "0x40002FB")]
			CompositeSSR,
			// Token: 0x040002FC RID: 764
			[Token(Token = "0x40002FC")]
			MinMipGeneration,
			// Token: 0x040002FD RID: 765
			[Token(Token = "0x40002FD")]
			HitPointToReflections,
			// Token: 0x040002FE RID: 766
			[Token(Token = "0x40002FE")]
			BilateralKeyPack,
			// Token: 0x040002FF RID: 767
			[Token(Token = "0x40002FF")]
			BlitDepthAsCSZ,
			// Token: 0x04000300 RID: 768
			[Token(Token = "0x4000300")]
			PoissonBlur
		}
	}
}
