using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x1700003B")]
		public override bool active
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x574D10", Offset = "0x573F10", VA = "0x180574D10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x570DE0", Offset = "0x56FFE0", VA = "0x180570DE0", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00002B50 File Offset: 0x00000D50
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public Vector2 jitterVector
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x574D90", Offset = "0x573F90", VA = "0x180574D90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x574DB0", Offset = "0x573FB0", VA = "0x180574DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5748F0", Offset = "0x573AF0", VA = "0x1805748F0")]
		public void ResetHistory()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x574900", Offset = "0x573B00", VA = "0x180574900")]
		public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5743F0", Offset = "0x5735F0", VA = "0x1805743F0")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x573C30", Offset = "0x572E30", VA = "0x180573C30")]
		private float GetHaltonValue(int index, int radix)
		{
			return 0f;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x573B50", Offset = "0x572D50", VA = "0x180573B50")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x573E50", Offset = "0x573050", VA = "0x180573E50")]
		private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x573C90", Offset = "0x572E90", VA = "0x180573C90")]
		private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x574360", Offset = "0x573560", VA = "0x180574360", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x574CA0", Offset = "0x573EA0", VA = "0x180574CA0")]
		public TaaComponent()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		private const int k_SampleCount = 8;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderBuffer[] m_MRT;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_ResetHistory;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_HistoryTexture;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		private static class Uniforms
		{
			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x0")]
			internal static int _Jitter;

			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			[FieldOffset(Offset = "0x4")]
			internal static int _SharpenParameters;

			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x8")]
			internal static int _FinalBlendParameters;

			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0xC")]
			internal static int _HistoryTex;

			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x10")]
			internal static int _MainTex;
		}
	}
}
