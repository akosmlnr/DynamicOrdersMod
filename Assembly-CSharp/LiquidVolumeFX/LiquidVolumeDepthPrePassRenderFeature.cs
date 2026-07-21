using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace LiquidVolumeFX
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x8D7540", Offset = "0x8D6740", VA = "0x1808D7540")]
		public static void AddLiquidToBackRenderers(LiquidVolume lv)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x8D7BE0", Offset = "0x8D6DE0", VA = "0x1808D7BE0")]
		public static void RemoveLiquidFromBackRenderers(LiquidVolume lv)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x8D7660", Offset = "0x8D6860", VA = "0x1808D7660")]
		public static void AddLiquidToFrontRenderers(LiquidVolume lv)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x8D7CF0", Offset = "0x8D6EF0", VA = "0x1808D7CF0")]
		public static void RemoveLiquidFromFrontRenderers(LiquidVolume lv)
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x8D7AB0", Offset = "0x8D6CB0", VA = "0x1808D7AB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x8D7920", Offset = "0x8D6B20", VA = "0x1808D7920", Slot = "5")]
		public override void Create()
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x8D7780", Offset = "0x8D6980", VA = "0x1808D7780", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x8D7ED0", Offset = "0x8D70D0", VA = "0x1808D7ED0")]
		public LiquidVolumeDepthPrePassRenderFeature()
		{
		}

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<LiquidVolume> lvBackRenderers;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly List<LiquidVolume> lvFrontRenderers;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Shader shader;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x10")]
		public static bool installed;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x28")]
		private Material mat;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x30")]
		private LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x38")]
		private LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Renders each irregular liquid volume completely before rendering the next one.")]
		public bool interleavedRendering;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x44")]
		public RenderPassEvent renderPassEvent;

		// Token: 0x02000189 RID: 393
		[Token(Token = "0x2000189")]
		private static class ShaderParams
		{
			// Token: 0x04000897 RID: 2199
			[Token(Token = "0x4000897")]
			public const string RTBackBufferName = "_VLBackBufferTexture";

			// Token: 0x04000898 RID: 2200
			[Token(Token = "0x4000898")]
			[FieldOffset(Offset = "0x0")]
			public static int RTBackBuffer;

			// Token: 0x04000899 RID: 2201
			[Token(Token = "0x4000899")]
			public const string RTFrontBufferName = "_VLFrontBufferTexture";

			// Token: 0x0400089A RID: 2202
			[Token(Token = "0x400089A")]
			[FieldOffset(Offset = "0x4")]
			public static int RTFrontBuffer;

			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400089B")]
			[FieldOffset(Offset = "0x8")]
			public static int FlaskThickness;

			// Token: 0x0400089C RID: 2204
			[Token(Token = "0x400089C")]
			[FieldOffset(Offset = "0xC")]
			public static int ForcedInvisible;

			// Token: 0x0400089D RID: 2205
			[Token(Token = "0x400089D")]
			public const string SKW_FP_RENDER_TEXTURE = "LIQUID_VOLUME_FP_RENDER_TEXTURES";
		}

		// Token: 0x0200018A RID: 394
		[Token(Token = "0x200018A")]
		private enum Pass
		{
			// Token: 0x0400089F RID: 2207
			[Token(Token = "0x400089F")]
			BackBuffer,
			// Token: 0x040008A0 RID: 2208
			[Token(Token = "0x40008A0")]
			FrontBuffer
		}

		// Token: 0x0200018B RID: 395
		[Token(Token = "0x200018B")]
		private class DepthPass : ScriptableRenderPass
		{
			// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x8D4430", Offset = "0x8D3630", VA = "0x1808D4430")]
			public DepthPass(Material mat, LiquidVolumeDepthPrePassRenderFeature.Pass pass, RenderPassEvent renderPassEvent)
			{
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x8D4120", Offset = "0x8D3320", VA = "0x1808D4120")]
			public void Setup(LiquidVolumeDepthPrePassRenderFeature feature, ScriptableRenderer renderer)
			{
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x000057F0 File Offset: 0x000039F0
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x8D4170", Offset = "0x8D3370", VA = "0x1808D4170")]
			private int SortByDistanceToCamera(LiquidVolume lv1, LiquidVolume lv2)
			{
				return 0;
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x8D3590", Offset = "0x8D2790", VA = "0x1808D3590", Slot = "6")]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x8D3F30", Offset = "0x8D3130", VA = "0x1808D3F30", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x8D3690", Offset = "0x8D2890", VA = "0x1808D3690")]
			private static void ExecutePass(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData)
			{
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x8D3540", Offset = "0x8D2740", VA = "0x1808D3540")]
			public void CleanUp()
			{
			}

			// Token: 0x040008A1 RID: 2209
			[Token(Token = "0x40008A1")]
			private const string profilerTag = "LiquidVolumeDepthPrePass";

			// Token: 0x040008A2 RID: 2210
			[Token(Token = "0x40008A2")]
			[FieldOffset(Offset = "0xE0")]
			private Material mat;

			// Token: 0x040008A3 RID: 2211
			[Token(Token = "0x40008A3")]
			[FieldOffset(Offset = "0xE8")]
			private int targetNameId;

			// Token: 0x040008A4 RID: 2212
			[Token(Token = "0x40008A4")]
			[FieldOffset(Offset = "0xF0")]
			private RTHandle targetRT;

			// Token: 0x040008A5 RID: 2213
			[Token(Token = "0x40008A5")]
			[FieldOffset(Offset = "0xF8")]
			private int passId;

			// Token: 0x040008A6 RID: 2214
			[Token(Token = "0x40008A6")]
			[FieldOffset(Offset = "0x100")]
			private List<LiquidVolume> lvRenderers;

			// Token: 0x040008A7 RID: 2215
			[Token(Token = "0x40008A7")]
			[FieldOffset(Offset = "0x108")]
			public ScriptableRenderer renderer;

			// Token: 0x040008A8 RID: 2216
			[Token(Token = "0x40008A8")]
			[FieldOffset(Offset = "0x110")]
			public bool interleavedRendering;

			// Token: 0x040008A9 RID: 2217
			[Token(Token = "0x40008A9")]
			[FieldOffset(Offset = "0x0")]
			private static Vector3 currentCameraPosition;

			// Token: 0x040008AA RID: 2218
			[Token(Token = "0x40008AA")]
			[FieldOffset(Offset = "0x118")]
			private readonly LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData;

			// Token: 0x0200018C RID: 396
			[Token(Token = "0x200018C")]
			private class PassData
			{
				// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
				public PassData()
				{
				}

				// Token: 0x040008AB RID: 2219
				[Token(Token = "0x40008AB")]
				[FieldOffset(Offset = "0x10")]
				public Camera cam;

				// Token: 0x040008AC RID: 2220
				[Token(Token = "0x40008AC")]
				[FieldOffset(Offset = "0x18")]
				public CommandBuffer cmd;

				// Token: 0x040008AD RID: 2221
				[Token(Token = "0x40008AD")]
				[FieldOffset(Offset = "0x20")]
				public LiquidVolumeDepthPrePassRenderFeature.DepthPass depthPass;

				// Token: 0x040008AE RID: 2222
				[Token(Token = "0x40008AE")]
				[FieldOffset(Offset = "0x28")]
				public Material mat;

				// Token: 0x040008AF RID: 2223
				[Token(Token = "0x40008AF")]
				[FieldOffset(Offset = "0x30")]
				public RTHandle source;

				// Token: 0x040008B0 RID: 2224
				[Token(Token = "0x40008B0")]
				[FieldOffset(Offset = "0x38")]
				public RTHandle depth;

				// Token: 0x040008B1 RID: 2225
				[Token(Token = "0x40008B1")]
				[FieldOffset(Offset = "0x40")]
				public RenderTextureDescriptor cameraTargetDescriptor;
			}
		}
	}
}
