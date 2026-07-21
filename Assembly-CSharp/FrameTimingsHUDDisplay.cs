using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class FrameTimingsHUDDisplay : MonoBehaviour
{
	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x557970", Offset = "0x556B70", VA = "0x180557970")]
	private void Awake()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x557A60", Offset = "0x556C60", VA = "0x180557A60")]
	private void OnGUI()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x557A20", Offset = "0x556C20", VA = "0x180557A20")]
	private void CaptureTimings()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x557F60", Offset = "0x557160", VA = "0x180557F60")]
	public FrameTimingsHUDDisplay()
	{
	}

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x20")]
	private GUIStyle m_Style;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x28")]
	private readonly FrameTiming[] m_FrameTimings;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	public const int SAMPLE_SIZE = 200;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x30")]
	public List<FrameTimingsHUDDisplay.FrameTimingPoint> frameTimingsHistory;

	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public struct FrameTimingPoint
	{
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		public double cpuFrameTime;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x8")]
		public double cpuMainThreadFrameTime;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		public double cpuRenderThreadFrameTime;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x18")]
		public double gpuFrameTime;
	}
}
