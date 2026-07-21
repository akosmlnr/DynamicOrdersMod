using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	public class SkyProfileOverride : MonoBehaviour
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x8E07C0", Offset = "0x8DF9C0", VA = "0x1808E07C0")]
		public void Apply(SkyProfileOutput output, float timeOfDay)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x8E0DB0", Offset = "0x8DFFB0", VA = "0x1808E0DB0")]
		public SkyProfileOverride()
		{
		}

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x20")]
		public SkyProfile SkyProfile;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float Strength;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Masks")]
		public bool AffectAmbientLight;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x2D")]
		public bool AffectFog;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x2E")]
		public bool AffectSunLight;
	}
}
