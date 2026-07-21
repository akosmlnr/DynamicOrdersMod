using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	public class SkyBlender : FeatureBlender
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B3")]
		protected override string featureKey
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x8DCB40", Offset = "0x8DBD40", VA = "0x1808DCB40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "9")]
		protected override ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			return ProfileFeatureBlendingMode.None;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x8DC6F0", Offset = "0x8DB8F0", VA = "0x1808DC6F0", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x8DCA20", Offset = "0x8DBC20", VA = "0x1808DCA20", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x8DCAB0", Offset = "0x8DBCB0", VA = "0x1808DCAB0", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SkyBlender()
		{
		}
	}
}
