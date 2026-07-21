using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	[RequireComponent(typeof(Camera))]
	public class WeatherDepthCamera : MonoBehaviour
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xA075C0", Offset = "0xA067C0", VA = "0x180A075C0")]
		private void Start()
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xA07630", Offset = "0xA06830", VA = "0x180A07630")]
		private void Update()
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xA07390", Offset = "0xA06590", VA = "0x180A07390")]
		private void RenderOverheadCamera()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xA07190", Offset = "0xA06390", VA = "0x180A07190")]
		private void PrepareRenderTexture()
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xA07690", Offset = "0xA06890", VA = "0x180A07690")]
		public WeatherDepthCamera()
		{
		}

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_DepthCamera;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Shader used to render out depth + normal texture. This should be the sky studio depth shader.")]
		public Shader depthShader;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public RenderTexture overheadDepthTexture;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x38")]
		[Range(1f, 60f)]
		[Tooltip("You can help increase performance by only rendering periodically some number of frames.")]
		public int renderFrameInterval;

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x3C")]
		[Range(128f, 8192f)]
		[Tooltip("The resolution of the texture. Higher resolution uses more rendering time but makes more precise weather along edges.")]
		public int textureResolution;
	}
}
