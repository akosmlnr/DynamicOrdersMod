using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x1700003E")]
		public override bool active
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x577BE0", Offset = "0x576DE0", VA = "0x180577BE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5778C0", Offset = "0x576AC0", VA = "0x1805778C0", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x577BA0", Offset = "0x576DA0", VA = "0x180577BA0")]
		public VignetteComponent()
		{
		}

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		private static class Uniforms
		{
			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Vignette_Color;

			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Vignette_Center;

			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Vignette_Settings;

			// Token: 0x04000312 RID: 786
			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _Vignette_Mask;

			// Token: 0x04000313 RID: 787
			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _Vignette_Opacity;
		}
	}
}
