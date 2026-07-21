using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x8D2BD0", Offset = "0x8D1DD0", VA = "0x1808D2BD0")]
		public BoolKeyframe(float time, bool value)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x8D2B40", Offset = "0x8D1D40", VA = "0x1808D2B40")]
		public BoolKeyframe(BoolKeyframe keyframe)
		{
		}

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x28")]
		public bool value;
	}
}
