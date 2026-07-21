using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	[CreateAssetMenu(fileName = "RainSplashArtSet.asset", menuName = "Sky Studio/Rain/Rain Splash Art Set")]
	public class RainSplashArtSet : SpriteArtSet
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public RainSplashArtSet()
		{
		}

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x18")]
		public List<RainSplashArtItem> rainSplashArtItems;
	}
}
