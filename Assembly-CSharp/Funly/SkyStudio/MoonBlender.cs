using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public class MoonBlender : FeatureBlender
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B0")]
		protected override string featureKey
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x8D86F0", Offset = "0x8D78F0", VA = "0x1808D86F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x8D8380", Offset = "0x8D7580", VA = "0x1808D8380", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x8D85F0", Offset = "0x8D77F0", VA = "0x1808D85F0", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x8D8670", Offset = "0x8D7870", VA = "0x1808D8670", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MoonBlender()
		{
		}
	}
}
