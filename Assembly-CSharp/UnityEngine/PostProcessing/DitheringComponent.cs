using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000032")]
		public override bool active
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x56B480", Offset = "0x56A680", VA = "0x18056B480", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x56B130", Offset = "0x56A330", VA = "0x18056B130", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x56B020", Offset = "0x56A220", VA = "0x18056B020")]
		private void LoadNoiseTextures()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x56B150", Offset = "0x56A350", VA = "0x18056B150", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x56B440", Offset = "0x56A640", VA = "0x18056B440")]
		public DitheringComponent()
		{
		}

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D[] noiseTextures;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x28")]
		private int textureIndex;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		private const int k_TextureCount = 64;

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		private static class Uniforms
		{
			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DitheringTex;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _DitheringCoords;
		}
	}
}
