using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
public class ScheduleOneFogPass : ScriptableRenderPass
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x55F8E0", Offset = "0x55EAE0", VA = "0x18055F8E0")]
	public ScheduleOneFogPass(Material material)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x55F870", Offset = "0x55EA70", VA = "0x18055F870")]
	public void Setup(ScheduleOneFogFeature.Settings settings, RTHandle cameraColorTarget)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x55F780", Offset = "0x55E980", VA = "0x18055F780", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x55F350", Offset = "0x55E550", VA = "0x18055F350", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x55F330", Offset = "0x55E530", VA = "0x18055F330")]
	public void Dispose()
	{
	}

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0xE0")]
	private Material _material;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0xE8")]
	private RTHandle _cameraColorTarget;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0xF0")]
	private RTHandle _tempTexture;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0xF8")]
	private Color _color;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x108")]
	private float _start;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x10C")]
	private float _end;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x110")]
	private float _density;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x114")]
	private float _blurStrength;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x118")]
	private float _startHeightFade;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x11C")]
	private float _endHeightFade;
}
