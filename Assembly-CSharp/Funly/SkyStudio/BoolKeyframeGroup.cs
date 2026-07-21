using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x8D2AF0", Offset = "0x8D1CF0", VA = "0x1808D2AF0")]
		public BoolKeyframeGroup(string name)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x8D2A70", Offset = "0x8D1C70", VA = "0x1808D2A70")]
		public BoolKeyframeGroup(string name, BoolKeyframe keyframe)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x8D2900", Offset = "0x8D1B00", VA = "0x1808D2900")]
		public bool BoolForTime(float time)
		{
			return default(bool);
		}
	}
}
