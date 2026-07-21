using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public sealed class RenderTextureFactory : IDisposable
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x69C350", Offset = "0x69B550", VA = "0x18069C350")]
		public RenderTextureFactory()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x69BED0", Offset = "0x69B0D0", VA = "0x18069BED0")]
		public RenderTexture Get(RenderTexture baseRenderTexture)
		{
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x69C070", Offset = "0x69B270", VA = "0x18069C070")]
		public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x69C230", Offset = "0x69B430", VA = "0x18069C230")]
		public void Release(RenderTexture rt)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x69C140", Offset = "0x69B340", VA = "0x18069C140")]
		public void ReleaseAll()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x69BEC0", Offset = "0x69B0C0", VA = "0x18069BEC0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<RenderTexture> m_TemporaryRTs;
	}
}
