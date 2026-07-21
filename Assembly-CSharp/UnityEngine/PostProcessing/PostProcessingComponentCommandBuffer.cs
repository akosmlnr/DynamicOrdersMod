using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000325 RID: 805
		[Token(Token = "0x6000325")]
		public abstract CameraEvent GetCameraEvent();

		// Token: 0x06000326 RID: 806
		[Token(Token = "0x6000326")]
		public abstract string GetName();

		// Token: 0x06000327 RID: 807
		[Token(Token = "0x6000327")]
		public abstract void PopulateCommandBuffer(CommandBuffer cb);

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		protected PostProcessingComponentCommandBuffer()
		{
		}
	}
}
