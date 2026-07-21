using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	public class FogBlender : FeatureBlender
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001AE")]
		protected override string featureKey
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x8D4B90", Offset = "0x8D3D90", VA = "0x1808D4B90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x8D4970", Offset = "0x8D3B70", VA = "0x1808D4970", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x8D4A90", Offset = "0x8D3C90", VA = "0x1808D4A90", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x8D4B10", Offset = "0x8D3D10", VA = "0x1808D4B10", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FogBlender()
		{
		}
	}
}
