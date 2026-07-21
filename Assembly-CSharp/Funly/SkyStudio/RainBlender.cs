using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	public class RainBlender : FeatureBlender
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B1")]
		protected override string featureKey
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x8DB620", Offset = "0x8DA820", VA = "0x1808DB620", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x8DB040", Offset = "0x8DA240", VA = "0x1808DB040", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x8DB3E0", Offset = "0x8DA5E0", VA = "0x1808DB3E0", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8DB500", Offset = "0x8DA700", VA = "0x1808DB500", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RainBlender()
		{
		}
	}
}
