using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	[Serializable]
	public class TextureKeyframe : BaseKeyframe
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x8EE9E0", Offset = "0x8EDBE0", VA = "0x1808EE9E0")]
		public TextureKeyframe(Texture texture, float time)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x8EE940", Offset = "0x8EDB40", VA = "0x1808EE940")]
		public TextureKeyframe(TextureKeyframe keyframe)
		{
		}

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x28")]
		public Texture texture;
	}
}
