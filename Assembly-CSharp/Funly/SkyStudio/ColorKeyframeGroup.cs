using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x8D33D0", Offset = "0x8D25D0", VA = "0x1808D33D0")]
		public ColorKeyframeGroup(string name)
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x8D3350", Offset = "0x8D2550", VA = "0x1808D3350")]
		public ColorKeyframeGroup(string name, ColorKeyframe frame)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x8D30F0", Offset = "0x8D22F0", VA = "0x1808D30F0")]
		public Color ColorForTime(float time)
		{
			return default(Color);
		}
	}
}
