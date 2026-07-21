using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x8D34C0", Offset = "0x8D26C0", VA = "0x1808D34C0")]
		public ColorKeyframe(Color c, float time)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x8D3420", Offset = "0x8D2620", VA = "0x1808D3420")]
		public ColorKeyframe(ColorKeyframe keyframe)
		{
		}

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x28")]
		public Color color;
	}
}
