using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public T model
		{
			[Token(Token = "0x6000320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000321")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000323")]
		public override PostProcessingModel GetModel()
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		protected PostProcessingComponent()
		{
		}
	}
}
