using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public static class ShaderProperties
	{
		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int ConeRadius;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ConeGeomProps;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ColorFlat;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int DistanceFallOff;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int NoiseVelocityAndScale;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int NoiseParam;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int ColorGradientMatrix;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int LocalToWorldMatrix;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int WorldToLocalMatrix;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int BlendSrcFactor;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int BlendDstFactor;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int ZTest;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int ParticlesTintColor;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int HDRPExposureWeight;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int GlobalUsesReversedZBuffer;

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int GlobalNoiseTex3D;

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int GlobalNoiseCustomTime;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int GlobalDitheringFactor;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int GlobalDitheringNoiseTex;

		// Token: 0x0200014F RID: 335
		[Token(Token = "0x200014F")]
		public static class SD
		{
			// Token: 0x040006BE RID: 1726
			[Token(Token = "0x40006BE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int FadeOutFactor;

			// Token: 0x040006BF RID: 1727
			[Token(Token = "0x40006BF")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int ConeSlopeCosSin;

			// Token: 0x040006C0 RID: 1728
			[Token(Token = "0x40006C0")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int AlphaInside;

			// Token: 0x040006C1 RID: 1729
			[Token(Token = "0x40006C1")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int AlphaOutside;

			// Token: 0x040006C2 RID: 1730
			[Token(Token = "0x40006C2")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int AttenuationLerpLinearQuad;

			// Token: 0x040006C3 RID: 1731
			[Token(Token = "0x40006C3")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int DistanceCamClipping;

			// Token: 0x040006C4 RID: 1732
			[Token(Token = "0x40006C4")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int FresnelPow;

			// Token: 0x040006C5 RID: 1733
			[Token(Token = "0x40006C5")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int GlareBehind;

			// Token: 0x040006C6 RID: 1734
			[Token(Token = "0x40006C6")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int GlareFrontal;

			// Token: 0x040006C7 RID: 1735
			[Token(Token = "0x40006C7")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int DrawCap;

			// Token: 0x040006C8 RID: 1736
			[Token(Token = "0x40006C8")]
			[FieldOffset(Offset = "0x28")]
			public static readonly int DepthBlendDistance;

			// Token: 0x040006C9 RID: 1737
			[Token(Token = "0x40006C9")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly int CameraParams;

			// Token: 0x040006CA RID: 1738
			[Token(Token = "0x40006CA")]
			[FieldOffset(Offset = "0x30")]
			public static readonly int DynamicOcclusionClippingPlaneWS;

			// Token: 0x040006CB RID: 1739
			[Token(Token = "0x40006CB")]
			[FieldOffset(Offset = "0x34")]
			public static readonly int DynamicOcclusionClippingPlaneProps;

			// Token: 0x040006CC RID: 1740
			[Token(Token = "0x40006CC")]
			[FieldOffset(Offset = "0x38")]
			public static readonly int DynamicOcclusionDepthTexture;

			// Token: 0x040006CD RID: 1741
			[Token(Token = "0x40006CD")]
			[FieldOffset(Offset = "0x3C")]
			public static readonly int DynamicOcclusionDepthProps;

			// Token: 0x040006CE RID: 1742
			[Token(Token = "0x40006CE")]
			[FieldOffset(Offset = "0x40")]
			public static readonly int LocalForwardDirection;

			// Token: 0x040006CF RID: 1743
			[Token(Token = "0x40006CF")]
			[FieldOffset(Offset = "0x44")]
			public static readonly int TiltVector;

			// Token: 0x040006D0 RID: 1744
			[Token(Token = "0x40006D0")]
			[FieldOffset(Offset = "0x48")]
			public static readonly int AdditionalClippingPlaneWS;
		}

		// Token: 0x02000150 RID: 336
		[Token(Token = "0x2000150")]
		public static class HD
		{
			// Token: 0x040006D1 RID: 1745
			[Token(Token = "0x40006D1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int Intensity;

			// Token: 0x040006D2 RID: 1746
			[Token(Token = "0x40006D2")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int SideSoftness;

			// Token: 0x040006D3 RID: 1747
			[Token(Token = "0x40006D3")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int CameraForwardOS;

			// Token: 0x040006D4 RID: 1748
			[Token(Token = "0x40006D4")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int CameraForwardWS;

			// Token: 0x040006D5 RID: 1749
			[Token(Token = "0x40006D5")]
			[FieldOffset(Offset = "0x10")]
			public static readonly int TransformScale;

			// Token: 0x040006D6 RID: 1750
			[Token(Token = "0x40006D6")]
			[FieldOffset(Offset = "0x14")]
			public static readonly int ShadowDepthTexture;

			// Token: 0x040006D7 RID: 1751
			[Token(Token = "0x40006D7")]
			[FieldOffset(Offset = "0x18")]
			public static readonly int ShadowProps;

			// Token: 0x040006D8 RID: 1752
			[Token(Token = "0x40006D8")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly int Jittering;

			// Token: 0x040006D9 RID: 1753
			[Token(Token = "0x40006D9")]
			[FieldOffset(Offset = "0x20")]
			public static readonly int CookieTexture;

			// Token: 0x040006DA RID: 1754
			[Token(Token = "0x40006DA")]
			[FieldOffset(Offset = "0x24")]
			public static readonly int CookieProperties;

			// Token: 0x040006DB RID: 1755
			[Token(Token = "0x40006DB")]
			[FieldOffset(Offset = "0x28")]
			public static readonly int CookiePosAndScale;

			// Token: 0x040006DC RID: 1756
			[Token(Token = "0x40006DC")]
			[FieldOffset(Offset = "0x2C")]
			public static readonly int GlobalCameraBlendingDistance;

			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			[FieldOffset(Offset = "0x30")]
			public static readonly int GlobalJitteringNoiseTex;
		}
	}
}
