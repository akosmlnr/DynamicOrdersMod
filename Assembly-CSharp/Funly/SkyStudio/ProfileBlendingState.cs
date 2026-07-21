using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public struct ProfileBlendingState
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x8DA1F0", Offset = "0x8D93F0", VA = "0x1808DA1F0")]
		public ProfileBlendingState(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay)
		{
		}

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x0")]
		public SkyProfile blendedProfile;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x8")]
		public SkyProfile fromProfile;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x10")]
		public SkyProfile toProfile;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x18")]
		public float progress;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x1C")]
		public float outProgress;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x20")]
		public float inProgress;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x24")]
		public float timeOfDay;
	}
}
