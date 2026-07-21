using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	[Serializable]
	public class ProfileFeatureDefinition
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x8DA440", Offset = "0x8D9640", VA = "0x1808DA440")]
		public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x8DA330", Offset = "0x8D9530", VA = "0x1808DA330")]
		public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x8DA270", Offset = "0x8D9470", VA = "0x1808DA270")]
		public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ProfileFeatureDefinition()
		{
		}

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x10")]
		public string featureKey;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x18")]
		public string[] featureKeys;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x20")]
		public ProfileFeatureDefinition.FeatureType featureType;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x28")]
		public string shaderKeyword;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x30")]
		public string[] shaderKeywords;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x38")]
		public string[] dropdownLabels;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x40")]
		public int dropdownSelectedIndex;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x50")]
		public bool value;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x58")]
		public string tooltip;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x60")]
		public string dependsOnFeature;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x68")]
		public bool dependsOnValue;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x69")]
		public bool isShaderKeywordFeature;

		// Token: 0x020001C4 RID: 452
		[Token(Token = "0x20001C4")]
		public enum FeatureType
		{
			// Token: 0x04000952 RID: 2386
			[Token(Token = "0x4000952")]
			ShaderKeyword,
			// Token: 0x04000953 RID: 2387
			[Token(Token = "0x4000953")]
			BooleanValue,
			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			ShaderKeywordDropdown
		}
	}
}
