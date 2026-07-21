using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	[CreateAssetMenu(fileName = "rainSplashArtItem.asset", menuName = "Sky Studio/Rain/Rain Splash Art Item")]
	public class RainSplashArtItem : SpriteArtItem
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x8DB650", Offset = "0x8DA850", VA = "0x1808DB650")]
		public RainSplashArtItem()
		{
		}

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float intensityMultiplier;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float scaleMultiplier;
	}
}
