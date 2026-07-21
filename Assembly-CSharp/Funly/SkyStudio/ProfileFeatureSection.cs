using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[Serializable]
	public class ProfileFeatureSection
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x8DA530", Offset = "0x8D9730", VA = "0x1808DA530")]
		public ProfileFeatureSection(string sectionTitle, string sectionKey, ProfileFeatureDefinition[] featureDefinitions)
		{
		}

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x10")]
		public string sectionTitle;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x18")]
		public string sectionKey;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x20")]
		public string sectionIcon;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x28")]
		public ProfileFeatureDefinition[] featureDefinitions;
	}
}
