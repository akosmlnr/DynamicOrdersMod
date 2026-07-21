using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		public virtual void Prepare(Material material)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		protected PostProcessingComponentRenderTexture()
		{
		}
	}
}
