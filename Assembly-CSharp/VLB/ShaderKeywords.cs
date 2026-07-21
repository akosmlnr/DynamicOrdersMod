using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public static class ShaderKeywords
	{
		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		public const string Noise3D = "VLB_NOISE_3D";

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x200014C")]
		public static class SD
		{
			// Token: 0x040006A0 RID: 1696
			[Token(Token = "0x40006A0")]
			public const string DepthBlend = "VLB_DEPTH_BLEND";

			// Token: 0x040006A1 RID: 1697
			[Token(Token = "0x40006A1")]
			public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

			// Token: 0x040006A2 RID: 1698
			[Token(Token = "0x40006A2")]
			public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

			// Token: 0x040006A3 RID: 1699
			[Token(Token = "0x40006A3")]
			public const string MeshSkewing = "VLB_MESH_SKEWING";

			// Token: 0x040006A4 RID: 1700
			[Token(Token = "0x40006A4")]
			public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
		}

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x200014D")]
		public static class HD
		{
			// Token: 0x060005FD RID: 1533 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x7A65D0", Offset = "0x7A57D0", VA = "0x1807A65D0")]
			public static string GetRaymarchingQuality(int id)
			{
				return null;
			}

			// Token: 0x040006A5 RID: 1701
			[Token(Token = "0x40006A5")]
			public const string AttenuationLinear = "VLB_ATTENUATION_LINEAR";

			// Token: 0x040006A6 RID: 1702
			[Token(Token = "0x40006A6")]
			public const string AttenuationQuad = "VLB_ATTENUATION_QUAD";

			// Token: 0x040006A7 RID: 1703
			[Token(Token = "0x40006A7")]
			public const string Shadow = "VLB_SHADOW";

			// Token: 0x040006A8 RID: 1704
			[Token(Token = "0x40006A8")]
			public const string CookieSingleChannel = "VLB_COOKIE_1CHANNEL";

			// Token: 0x040006A9 RID: 1705
			[Token(Token = "0x40006A9")]
			public const string CookieRGBA = "VLB_COOKIE_RGBA";

			// Token: 0x040006AA RID: 1706
			[Token(Token = "0x40006AA")]
			public const string RaymarchingStepCount = "VLB_RAYMARCHING_STEP_COUNT";
		}
	}
}
