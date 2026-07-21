using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x8D92D0", Offset = "0x8D84D0", VA = "0x1808D92D0")]
		public NumberKeyframe(float time, float value)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x8D9350", Offset = "0x8D8550", VA = "0x1808D9350")]
		public NumberKeyframe(NumberKeyframe keyframe)
		{
		}

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x28")]
		public float value;
	}
}
