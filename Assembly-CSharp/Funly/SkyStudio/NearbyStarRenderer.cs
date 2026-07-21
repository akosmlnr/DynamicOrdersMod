using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x8D8910", Offset = "0x8D7B10", VA = "0x1808D8910")]
		private RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x8D8990", Offset = "0x8D7B90", VA = "0x1808D8990")]
		private Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			return null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x8D8E50", Offset = "0x8D8050", VA = "0x1808D8E50")]
		private void WriteDebugTexture(RenderTexture rt, string path)
		{
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x8D8B00", Offset = "0x8D7D00", VA = "0x1808D8B00")]
		private Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			return null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x8D8720", Offset = "0x8D7920", VA = "0x1808D8720", Slot = "4")]
		public override IEnumerator ComputeStarData()
		{
			return null;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x8D8790", Offset = "0x8D7990", VA = "0x1808D8790")]
		private Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			return null;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x8D8E80", Offset = "0x8D8080", VA = "0x1808D8E80")]
		public NearbyStarRenderer()
		{
		}

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		private const int kMaxStars = 2000;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		private const int kStarPointTextureWidth = 2048;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		private const float kStarPaddingRadiusMultipler = 2.1f;
	}
}
