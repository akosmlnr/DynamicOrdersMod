using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[CreateAssetMenu(fileName = "lightningArtItem.asset", menuName = "Sky Studio/Lightning/Lightning Art Item")]
	public class LightningArtItem : SpriteArtItem
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x8D71A0", Offset = "0x8D63A0", VA = "0x1808D71A0")]
		public LightningArtItem()
		{
		}

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Adjust how the lightning bolt is positioned inside the spawn area container.")]
		public LightningArtItem.Alignment alignment;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Thunder sound clip to play when this lighting bolt is rendered.")]
		public AudioClip thunderSound;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Probability adjustment for this specific lightning bolt. This value is multiplied against the global lightning probability.")]
		[Range(0f, 1f)]
		public float strikeProbability;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 60f)]
		[Tooltip("Size of the lighting bolt.")]
		public float size;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The blending weight of the additive lighting bolt effect")]
		public float intensity;

		// Token: 0x0200019D RID: 413
		[Token(Token = "0x200019D")]
		public enum Alignment
		{
			// Token: 0x040008FA RID: 2298
			[Token(Token = "0x40008FA")]
			ScaleToFit,
			// Token: 0x040008FB RID: 2299
			[Token(Token = "0x40008FB")]
			TopAlign
		}
	}
}
