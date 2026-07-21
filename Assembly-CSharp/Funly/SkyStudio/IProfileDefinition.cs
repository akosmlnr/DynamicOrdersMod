using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	public interface IProfileDefinition
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060008FB RID: 2299
		[Token(Token = "0x170001C9")]
		string shaderName
		{
			[Token(Token = "0x60008FB")]
			get;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008FC RID: 2300
		[Token(Token = "0x170001CA")]
		ProfileFeatureSection[] features
		{
			[Token(Token = "0x60008FC")]
			get;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008FD RID: 2301
		[Token(Token = "0x170001CB")]
		ProfileGroupSection[] groups
		{
			[Token(Token = "0x60008FD")]
			get;
		}

		// Token: 0x060008FE RID: 2302
		[Token(Token = "0x60008FE")]
		ProfileFeatureDefinition GetFeatureDefinition(string featureKey);
	}
}
