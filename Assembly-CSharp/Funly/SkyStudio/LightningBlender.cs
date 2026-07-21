using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	public class LightningBlender : FeatureBlender
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001AF")]
		protected override string featureKey
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x8D7510", Offset = "0x8D6710", VA = "0x1808D7510", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x8D71D0", Offset = "0x8D63D0", VA = "0x1808D71D0", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x8D7410", Offset = "0x8D6610", VA = "0x1808D7410", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x8D7490", Offset = "0x8D6690", VA = "0x1808D7490", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LightningBlender()
		{
		}
	}
}
