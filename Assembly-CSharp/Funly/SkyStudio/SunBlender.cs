using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public class SunBlender : FeatureBlender
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B5")]
		protected override string featureKey
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x8EE740", Offset = "0x8ED940", VA = "0x1808EE740", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x8EE330", Offset = "0x8ED530", VA = "0x1808EE330", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x8EE5A0", Offset = "0x8ED7A0", VA = "0x1808EE5A0", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x8EE670", Offset = "0x8ED870", VA = "0x1808EE670", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SunBlender()
		{
		}
	}
}
