using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700002F")]
		public override bool active
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x567AC0", Offset = "0x566CC0", VA = "0x180567AC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5677A0", Offset = "0x5669A0", VA = "0x1805677A0", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x5677D0", Offset = "0x5669D0", VA = "0x1805677D0", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x567A80", Offset = "0x566C80", VA = "0x180567A80")]
		public ChromaticAberrationComponent()
		{
		}

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_SpectrumLut;

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		private static class Uniforms
		{
			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _ChromaticAberration_Amount;

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _ChromaticAberration_Spectrum;
		}
	}
}
