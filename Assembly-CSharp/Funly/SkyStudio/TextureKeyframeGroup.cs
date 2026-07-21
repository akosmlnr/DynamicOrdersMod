using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	[Serializable]
	public class TextureKeyframeGroup : KeyframeGroup<TextureKeyframe>
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x8EE8C0", Offset = "0x8EDAC0", VA = "0x1808EE8C0")]
		public TextureKeyframeGroup(string name, TextureKeyframe keyframe)
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x8EE7B0", Offset = "0x8ED9B0", VA = "0x1808EE7B0")]
		public Texture TextureForTime(float time)
		{
			return null;
		}
	}
}
