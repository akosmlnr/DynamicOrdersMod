using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public abstract class FeatureBlender : MonoBehaviour, IFeatureBlender
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600087E RID: 2174
		[Token(Token = "0x170001B9")]
		protected abstract string featureKey
		{
			[Token(Token = "0x600087E")]
			get;
		}

		// Token: 0x0600087F RID: 2175
		[Token(Token = "0x600087F")]
		protected abstract void BlendBoth(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x06000880 RID: 2176
		[Token(Token = "0x6000880")]
		protected abstract void BlendIn(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x06000881 RID: 2177
		[Token(Token = "0x6000881")]
		protected abstract void BlendOut(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x06000882 RID: 2178 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x8D48B0", Offset = "0x8D3AB0", VA = "0x1808D48B0", Slot = "9")]
		protected virtual ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			return ProfileFeatureBlendingMode.None;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x8D47E0", Offset = "0x8D39E0", VA = "0x1808D47E0", Slot = "10")]
		public virtual void Blend(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected FeatureBlender()
		{
		}
	}
}
