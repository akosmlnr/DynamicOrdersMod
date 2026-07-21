using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Beautify.Universal
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	[ExecuteInEditMode]
	public class LUTBlending : MonoBehaviour
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x9F8390", Offset = "0x9F7590", VA = "0x1809F8390")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x9F8420", Offset = "0x9F7620", VA = "0x1809F8420")]
		private void OnValidate()
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x9F83A0", Offset = "0x9F75A0", VA = "0x1809F83A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x9F8390", Offset = "0x9F7590", VA = "0x1809F8390")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x9F8430", Offset = "0x9F7630", VA = "0x1809F8430")]
		private void UpdateBeautifyLUT()
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x9F8830", Offset = "0x9F7A30", VA = "0x1809F8830")]
		public LUTBlending()
		{
		}

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D LUT1;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D LUT2;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float LUT1Intensity;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float LUT2Intensity;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float phase;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x40")]
		public Shader lerpShader;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x48")]
		private float oldPhase;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture rt;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x58")]
		private Material lerpMat;

		// Token: 0x02000201 RID: 513
		[Token(Token = "0x2000201")]
		private static class ShaderParams
		{
			// Token: 0x04000BA6 RID: 2982
			[Token(Token = "0x4000BA6")]
			[FieldOffset(Offset = "0x0")]
			public static int LUT2;

			// Token: 0x04000BA7 RID: 2983
			[Token(Token = "0x4000BA7")]
			[FieldOffset(Offset = "0x4")]
			public static int Phase;
		}
	}
}
