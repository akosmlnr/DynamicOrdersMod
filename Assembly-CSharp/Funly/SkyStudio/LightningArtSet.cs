using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[CreateAssetMenu(fileName = "LightningArtSet.asset", menuName = "Sky Studio/Lightning/Lightning Art Set")]
	public class LightningArtSet : SpriteArtSet
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public LightningArtSet()
		{
		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("List of lighting bolt art that will be used for customization.")]
		public List<LightningArtItem> lightingStyleItems;
	}
}
