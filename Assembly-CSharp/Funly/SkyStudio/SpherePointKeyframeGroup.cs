using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[Serializable]
	public class SpherePointKeyframeGroup : KeyframeGroup<SpherePointKeyframe>
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x8E3D70", Offset = "0x8E2F70", VA = "0x1808E3D70")]
		public SpherePointKeyframeGroup(string name)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x8E3DC0", Offset = "0x8E2FC0", VA = "0x1808E3DC0")]
		public SpherePointKeyframeGroup(string name, SpherePointKeyframe keyframe)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x8E3AA0", Offset = "0x8E2CA0", VA = "0x1808E3AA0")]
		public SpherePoint SpherePointForTime(float time)
		{
			return null;
		}

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		public const float MinHorizontalRotation = -3.1415927f;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		public const float MaxHorizontalRotation = 3.1415927f;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		public const float MinVerticalRotation = -1.5707964f;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		public const float MaxVerticalRotation = 1.5707964f;
	}
}
