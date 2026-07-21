using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
public class GrabScreenFeature : ScriptableRendererFeature
{
	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x558F60", Offset = "0x558160", VA = "0x180558F60", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x558F10", Offset = "0x558110", VA = "0x180558F10", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x559070", Offset = "0x558270", VA = "0x180559070", Slot = "11")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x5590A0", Offset = "0x5582A0", VA = "0x1805590A0")]
	public GrabScreenFeature()
	{
	}

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x20")]
	private GrabScreenFeature.GrabPass grabPass;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x28")]
	private GrabScreenFeature.RenderPass renderPass;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GrabScreenFeature.Settings settings;

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Serializable]
	public class Settings
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x55FAA0", Offset = "0x55ECA0", VA = "0x18055FAA0")]
		public Settings()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x10")]
		public string TextureName;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x18")]
		public RenderPassEvent RenderPassEvent;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask LayerMask;
	}

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class GrabPass : ScriptableRenderPass
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x558E80", Offset = "0x558080", VA = "0x180558E80")]
		public GrabPass(GrabScreenFeature.Settings s)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x558CD0", Offset = "0x557ED0", VA = "0x180558CD0", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x558B70", Offset = "0x557D70", VA = "0x180558B70", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x558B50", Offset = "0x557D50", VA = "0x180558B50")]
		public void Dispose()
		{
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xE0")]
		private GrabScreenFeature.Settings settings;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0xE8")]
		private RTHandle m_GrabbedTextureHandle;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0xF0")]
		private RTHandle m_CameraColorHandle;
	}

	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	private class RenderPass : ScriptableRenderPass
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x55E640", Offset = "0x55D840", VA = "0x18055E640")]
		public RenderPass(GrabScreenFeature.Settings settings)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x55E450", Offset = "0x55D650", VA = "0x18055E450", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xE0")]
		private GrabScreenFeature.Settings settings;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xE8")]
		private List<ShaderTagId> m_ShaderTagIdList;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xF0")]
		private FilteringSettings m_FilteringSettings;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x108")]
		private RenderStateBlock m_RenderStateBlock;
	}
}
