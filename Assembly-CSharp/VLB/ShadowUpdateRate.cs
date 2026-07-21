using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[Flags]
	public enum ShadowUpdateRate
	{
		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		Never = 1,
		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		OnEnable = 2,
		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		OnBeamMove = 4,
		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		EveryXFrames = 8,
		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		OnBeamMoveAndEveryXFrames = 12
	}
}
