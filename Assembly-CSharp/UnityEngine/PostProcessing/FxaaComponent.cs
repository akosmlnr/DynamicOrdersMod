using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x17000035")]
		public override bool active
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x56E560", Offset = "0x56D760", VA = "0x18056E560", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x56E290", Offset = "0x56D490", VA = "0x18056E290")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x56E520", Offset = "0x56D720", VA = "0x18056E520")]
		public FxaaComponent()
		{
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		private static class Uniforms
		{
			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _QualitySettings;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _ConsoleSettings;
		}
	}
}
