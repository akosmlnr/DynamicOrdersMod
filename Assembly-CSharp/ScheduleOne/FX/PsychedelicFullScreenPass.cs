using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x02000691 RID: 1681
	[Token(Token = "0x2000691")]
	public class PsychedelicFullScreenPass : ScriptableRenderPass
	{
		// Token: 0x06002B85 RID: 11141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x71E820", Offset = "0x71DA20", VA = "0x18071E820")]
		public PsychedelicFullScreenPass(PsychedelicFullScreenFeature.Settings settings)
		{
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x71E5E0", Offset = "0x71D7E0", VA = "0x18071E5E0", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x71E260", Offset = "0x71D460", VA = "0x18071E260", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x040020C3 RID: 8387
		[Token(Token = "0x40020C3")]
		[FieldOffset(Offset = "0xE0")]
		private PsychedelicFullScreenFeature.Settings _settings;

		// Token: 0x040020C4 RID: 8388
		[Token(Token = "0x40020C4")]
		[FieldOffset(Offset = "0xE8")]
		private RTHandle _source;

		// Token: 0x040020C5 RID: 8389
		[Token(Token = "0x40020C5")]
		[FieldOffset(Offset = "0xF0")]
		private RTHandle _tempTexture;

		// Token: 0x040020C6 RID: 8390
		[Token(Token = "0x40020C6")]
		[FieldOffset(Offset = "0xF8")]
		private Material _material;

		// Token: 0x040020C7 RID: 8391
		[Token(Token = "0x40020C7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BLEND_ID;

		// Token: 0x040020C8 RID: 8392
		[Token(Token = "0x40020C8")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int NOISE_SCALE_ID;

		// Token: 0x040020C9 RID: 8393
		[Token(Token = "0x40020C9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int PAN_SPEED_ID;

		// Token: 0x040020CA RID: 8394
		[Token(Token = "0x40020CA")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int DOES_BOUNCE_ID;

		// Token: 0x040020CB RID: 8395
		[Token(Token = "0x40020CB")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int AMPLITUDE_ID;
	}
}
