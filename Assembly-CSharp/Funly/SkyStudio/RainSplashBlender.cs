using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	public class RainSplashBlender : FeatureBlender
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B2")]
		protected override string featureKey
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x8DBB10", Offset = "0x8DAD10", VA = "0x1808DBB10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8DB680", Offset = "0x8DA880", VA = "0x1808DB680", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8DB970", Offset = "0x8DAB70", VA = "0x1808DB970", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x8DBA40", Offset = "0x8DAC40", VA = "0x1808DBA40", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RainSplashBlender()
		{
		}
	}
}
