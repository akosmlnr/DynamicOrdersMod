using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	public interface IBaseKeyframe
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060008C7 RID: 2247
		[Token(Token = "0x170001C2")]
		string id
		{
			[Token(Token = "0x60008C7")]
			get;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060008C8 RID: 2248
		// (set) Token: 0x060008C9 RID: 2249
		[Token(Token = "0x170001C3")]
		float time
		{
			[Token(Token = "0x60008C8")]
			get;
			[Token(Token = "0x60008C9")]
			set;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060008CA RID: 2250
		// (set) Token: 0x060008CB RID: 2251
		[Token(Token = "0x170001C4")]
		InterpolationCurve interpolationCurve
		{
			[Token(Token = "0x60008CA")]
			get;
			[Token(Token = "0x60008CB")]
			set;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060008CC RID: 2252
		// (set) Token: 0x060008CD RID: 2253
		[Token(Token = "0x170001C5")]
		InterpolationDirection interpolationDirection
		{
			[Token(Token = "0x60008CC")]
			get;
			[Token(Token = "0x60008CD")]
			set;
		}
	}
}
