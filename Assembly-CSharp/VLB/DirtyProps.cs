using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	[Flags]
	public enum DirtyProps
	{
		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		None = 0,
		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		Intensity = 2,
		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		HDRPExposureWeight = 4,
		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		ColorMode = 8,
		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		Color = 16,
		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		BlendingMode = 32,
		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		Cone = 64,
		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		SideSoftness = 128,
		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		Attenuation = 256,
		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		Dimensions = 512,
		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		RaymarchingQuality = 1024,
		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		Jittering = 2048,
		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		NoiseMode = 4096,
		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		NoiseIntensity = 8192,
		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		NoiseVelocityAndScale = 16384,
		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		CookieProps = 32768,
		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		ShadowProps = 65536,
		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		AllWithoutMaterialChange = 125142,
		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		OnlyMaterialChangeOnly = 5928,
		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		All = 131070
	}
}
