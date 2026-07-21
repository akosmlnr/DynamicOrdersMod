using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class ScheduleOneFogFeature : ScriptableRendererFeature
{
	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x55EF20", Offset = "0x55E120", VA = "0x18055EF20", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x55F190", Offset = "0x55E390", VA = "0x18055F190", Slot = "8")]
	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x55EE90", Offset = "0x55E090", VA = "0x18055EE90", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x55F120", Offset = "0x55E320", VA = "0x18055F120", Slot = "11")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x55F290", Offset = "0x55E490", VA = "0x18055F290")]
	public ScheduleOneFogFeature()
	{
	}

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x20")]
	public ScheduleOneFogFeature.Settings _settings;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	private ScheduleOneFogPass _pass;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x30")]
	private Material _material;

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	public class Settings
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x55FB00", Offset = "0x55ED00", VA = "0x18055FB00")]
		public Settings()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		public RenderPassEvent RenderPassEvent;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		public Shader Shader;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		public Color Color;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 100f)]
		public float Start;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 5000f)]
		public float End;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float Density;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		public float BlurStrength;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x40")]
		public float StartHeightFade;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x44")]
		public float EndHeightFade;
	}
}
