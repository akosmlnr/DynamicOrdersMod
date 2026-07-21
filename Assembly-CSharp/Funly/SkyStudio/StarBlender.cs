using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	public class StarBlender : FeatureBlender
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B4")]
		protected override string featureKey
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x8EE2D0", Offset = "0x8ED4D0", VA = "0x1808EE2D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "6")]
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x8EE070", Offset = "0x8ED270", VA = "0x1808EE070", Slot = "7")]
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x8EE160", Offset = "0x8ED360", VA = "0x1808EE160", Slot = "8")]
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x8EE250", Offset = "0x8ED450", VA = "0x1808EE250")]
		private string PropertyKeyForLayer(string key)
		{
			return null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StarBlender()
		{
		}

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 3f)]
		public int starLayer;
	}
}
