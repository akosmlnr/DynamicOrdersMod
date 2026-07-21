using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Funly.SkyStudio
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	[RequireComponent(typeof(UniversalAdditionalCameraData))]
	[RequireComponent(typeof(Camera))]
	public class URPWeatherDepth : MonoBehaviour
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xA06810", Offset = "0xA05A10", VA = "0x180A06810")]
		private void Start()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xA06890", Offset = "0xA05A90", VA = "0x180A06890")]
		private void Update()
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public URPWeatherDepth()
		{
		}

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x20")]
		public RenderTexture renderTexture;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_Camera;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x30")]
		private UniversalAdditionalCameraData m_CameraData;
	}
}
