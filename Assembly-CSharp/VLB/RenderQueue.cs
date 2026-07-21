using System;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public enum RenderQueue
	{
		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		Custom,
		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		Background = 1000,
		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		Geometry = 2000,
		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		AlphaTest = 2450,
		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		GeometryLast = 2500,
		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		Transparent = 3000,
		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		Overlay = 4000
	}
}
