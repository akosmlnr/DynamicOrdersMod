using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class VFXRainFeature : ScriptableRendererFeature
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x5636D0", Offset = "0x5628D0", VA = "0x1805636D0", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x563790", Offset = "0x562990", VA = "0x180563790", Slot = "8")]
	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x563690", Offset = "0x562890", VA = "0x180563690", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x563780", Offset = "0x562980", VA = "0x180563780", Slot = "11")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x563920", Offset = "0x562B20", VA = "0x180563920")]
	public VFXRainFeature()
	{
	}

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x20")]
	public VFXRainFeature.Settings _settings;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x28")]
	private VFXRainPass _pass;

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class Settings
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x55FB40", Offset = "0x55ED40", VA = "0x18055FB40")]
		public Settings()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		public RenderPassEvent RenderPassEvent;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x14")]
		public LayerMask LayerMask;
	}
}
