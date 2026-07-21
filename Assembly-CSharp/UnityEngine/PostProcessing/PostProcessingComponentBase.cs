using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public abstract class PostProcessingComponentBase
	{
		// Token: 0x0600031A RID: 794 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "4")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600031B RID: 795
		[Token(Token = "0x1700006E")]
		public abstract bool active
		{
			[Token(Token = "0x600031B")]
			get;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x0600031E RID: 798
		[Token(Token = "0x600031E")]
		public abstract PostProcessingModel GetModel();

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		protected PostProcessingComponentBase()
		{
		}

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x10")]
		public PostProcessingContext context;
	}
}
