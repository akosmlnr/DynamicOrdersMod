using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	public class Standard3dShaderDefinition : BaseShaderDefinition
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x8EDAC0", Offset = "0x8ECCC0", VA = "0x1808EDAC0")]
		public Standard3dShaderDefinition()
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x8EB730", Offset = "0x8EA930", VA = "0x1808EB730", Slot = "8")]
		protected override ProfileFeatureSection[] ProfileFeatureSection()
		{
			return null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x8E4070", Offset = "0x8E3270", VA = "0x1808E4070", Slot = "9")]
		protected override ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		public const float MaxStarSize = 0.2f;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		public const float MaxStarDensity = 1f;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		public const float MinEdgeFeathering = 0.0001f;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		public const float MinStarFadeBegin = -0.999f;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		public const float MaxSpriteItems = 100000f;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		public const float MinRotationSpeed = -10f;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		public const float MaxRotationSpeed = 10f;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		public const float MaxCloudRotationSpeed = 0.5f;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		public const float MaxHDRValue = 25f;
	}
}
