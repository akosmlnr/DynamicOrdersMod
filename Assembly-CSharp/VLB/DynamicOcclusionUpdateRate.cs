using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		Never = 1,
		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		OnEnable = 2,
		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		OnBeamMove = 4,
		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		EveryXFrames = 8,
		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		OnBeamMoveAndEveryXFrames = 12
	}
}
