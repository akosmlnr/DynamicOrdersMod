using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A2C RID: 2604
	[Token(Token = "0x2000A2C")]
	[Serializable]
	public class GraphicsSettings
	{
		// Token: 0x060049EC RID: 18924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public GraphicsSettings()
		{
		}

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x10")]
		public GraphicsSettings.EGraphicsQuality GraphicsQuality;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x14")]
		public GraphicsSettings.EAntiAliasingMode AntiAliasingMode;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x18")]
		public float FOV;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x1C")]
		public bool SSAO;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x1D")]
		public bool GodRays;

		// Token: 0x02000A2D RID: 2605
		[Token(Token = "0x2000A2D")]
		public enum EAntiAliasingMode
		{
			// Token: 0x04003453 RID: 13395
			[Token(Token = "0x4003453")]
			Off,
			// Token: 0x04003454 RID: 13396
			[Token(Token = "0x4003454")]
			FXAA,
			// Token: 0x04003455 RID: 13397
			[Token(Token = "0x4003455")]
			SMAA
		}

		// Token: 0x02000A2E RID: 2606
		[Token(Token = "0x2000A2E")]
		public enum EGraphicsQuality
		{
			// Token: 0x04003457 RID: 13399
			[Token(Token = "0x4003457")]
			Low,
			// Token: 0x04003458 RID: 13400
			[Token(Token = "0x4003458")]
			Medium,
			// Token: 0x04003459 RID: 13401
			[Token(Token = "0x4003459")]
			High,
			// Token: 0x0400345A RID: 13402
			[Token(Token = "0x400345A")]
			Ultra
		}
	}
}
