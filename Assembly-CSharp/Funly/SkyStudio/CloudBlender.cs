using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public class CloudBlender : FeatureBlender
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001AD")]
		protected override string featureKey
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x8D3060", Offset = "0x8D2260", VA = "0x1808D3060", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x8D2C50", Offset = "0x8D1E50", VA = "0x1808D2C50", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x8D2F60", Offset = "0x8D2160", VA = "0x1808D2F60", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x8D2FE0", Offset = "0x8D21E0", VA = "0x1808D2FE0", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CloudBlender()
		{
		}
	}
}
