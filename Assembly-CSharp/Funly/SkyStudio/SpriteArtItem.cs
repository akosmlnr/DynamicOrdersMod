using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public class SpriteArtItem : ScriptableObject
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x8E4050", Offset = "0x8E3250", VA = "0x1808E4050")]
		public SpriteArtItem()
		{
		}

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x28")]
		public int rows;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x2C")]
		public int columns;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x30")]
		public int totalFrames;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x34")]
		public int animateSpeed;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Color that will be multiplied against the base lightning bolt text color")]
		public Color tintColor;
	}
}
