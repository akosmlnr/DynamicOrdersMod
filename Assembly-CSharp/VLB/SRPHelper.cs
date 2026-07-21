using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public static class SRPHelper
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013B")]
		public static string renderPipelineScriptingDefineSymbolAsString
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x7B64A0", Offset = "0x7B56A0", VA = "0x1807B64A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x1700013C")]
		public static RenderPipeline projectRenderPipeline
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
			get
			{
				return RenderPipeline.BuiltIn;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x7B6050", Offset = "0x7B5250", VA = "0x1807B6050")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return RenderPipeline.BuiltIn;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x7B6170", Offset = "0x7B5370", VA = "0x1807B6170")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x7B6240", Offset = "0x7B5440", VA = "0x1807B6240")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x7B62B0", Offset = "0x7B54B0", VA = "0x1807B62B0")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_IsRenderPipelineCached;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x4")]
		private static RenderPipeline m_RenderPipelineCached;
	}
}
