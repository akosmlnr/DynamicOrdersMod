using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public interface IKeyframeGroup
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600088D RID: 2189
		// (set) Token: 0x0600088E RID: 2190
		[Token(Token = "0x170001BA")]
		string name
		{
			[Token(Token = "0x600088D")]
			get;
			[Token(Token = "0x600088E")]
			set;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600088F RID: 2191
		[Token(Token = "0x170001BB")]
		string id
		{
			[Token(Token = "0x600088F")]
			get;
		}

		// Token: 0x06000890 RID: 2192
		[Token(Token = "0x6000890")]
		void SortKeyframes();

		// Token: 0x06000891 RID: 2193
		[Token(Token = "0x6000891")]
		void TrimToSingleKeyframe();

		// Token: 0x06000892 RID: 2194
		[Token(Token = "0x6000892")]
		void RemoveKeyFrame(IBaseKeyframe keyframe);

		// Token: 0x06000893 RID: 2195
		[Token(Token = "0x6000893")]
		int GetKeyFrameCount();
	}
}
