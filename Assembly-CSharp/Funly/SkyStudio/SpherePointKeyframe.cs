using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x8E3F40", Offset = "0x8E3140", VA = "0x1808E3F40")]
		public SpherePointKeyframe(SpherePoint spherePoint, float time)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x8E3E40", Offset = "0x8E3040", VA = "0x1808E3E40")]
		public SpherePointKeyframe(SpherePointKeyframe keyframe)
		{
		}

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x28")]
		public SpherePoint spherePoint;
	}
}
