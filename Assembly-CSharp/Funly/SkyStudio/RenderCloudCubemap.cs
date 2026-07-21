using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[RequireComponent(typeof(Camera))]
	public class RenderCloudCubemap : MonoBehaviour
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x9FD620", Offset = "0x9FC820", VA = "0x1809FD620")]
		public RenderCloudCubemap()
		{
		}

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		public const string kDefaultFilenamePrefix = "CloudCubemap";

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Filename of the final output cubemap asset. It will be written to the same directory as the current scene.")]
		public string filenamePrefix;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Resolution of each face of the cubemap.")]
		public int faceWidth;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Format for the exported cubemap. RGBColor (Additive texture), RGBAColor (Color with alpha channel), RGBANormal (Normal lighting data encoded).")]
		public RenderCloudCubemap.CubemapTextureFormat textureFormat;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x30")]
		public bool exportFaces;

		// Token: 0x020001E4 RID: 484
		[Token(Token = "0x20001E4")]
		public enum CubemapTextureFormat
		{
			// Token: 0x04000B1F RID: 2847
			[Token(Token = "0x4000B1F")]
			RGBColor,
			// Token: 0x04000B20 RID: 2848
			[Token(Token = "0x4000B20")]
			RGBAColor,
			// Token: 0x04000B21 RID: 2849
			[Token(Token = "0x4000B21")]
			RGBALit
		}
	}
}
