using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class VFXRainPass : ScriptableRenderPass
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x563CF0", Offset = "0x562EF0", VA = "0x180563CF0")]
	public void Setup(VFXRainFeature.Settings settings, RTHandle cameraColorTarget, RTHandle cameraDepthTarget)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x563CD0", Offset = "0x562ED0", VA = "0x180563CD0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x5639A0", Offset = "0x562BA0", VA = "0x1805639A0", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
	public void Dispose()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x563F70", Offset = "0x563170", VA = "0x180563F70")]
	public VFXRainPass()
	{
	}

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xE0")]
	private RTHandle _cameraColorTarget;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xE8")]
	private RTHandle _cameraDepthTarget;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xF0")]
	private LayerMask _layerMask;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xF4")]
	private FilteringSettings _filteringSettings;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ShaderTagId[] _shaderTagIds;
}
