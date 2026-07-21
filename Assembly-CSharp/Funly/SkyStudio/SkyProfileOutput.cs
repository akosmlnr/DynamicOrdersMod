using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public class SkyProfileOutput
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x8E0620", Offset = "0x8DF820", VA = "0x1808E0620")]
		public SkyProfileOutput(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x10")]
		public Color ambientSkyColor;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x20")]
		public Color ambientEquatorColor;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x30")]
		public Color ambientGroundColor;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x40")]
		public Color fogColor;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x50")]
		public float fogEndDistance;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x54")]
		public Color sunLightColor;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x64")]
		public float sunLightIntensity;
	}
}
