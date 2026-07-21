using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	public class ProfileGroupSection
	{
		// Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x8DAE10", Offset = "0x8DA010", VA = "0x1808DAE10")]
		public ProfileGroupSection(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, ProfileGroupDefinition[] groups)
		{
		}

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x10")]
		public string sectionTitle;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x18")]
		public string sectionIcon;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x20")]
		public string sectionKey;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x28")]
		public string dependsOnFeature;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x30")]
		public bool dependsOnValue;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x38")]
		public ProfileGroupDefinition[] groups;
	}
}
