using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	public interface ISightable
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060017F1 RID: 6129
		[Token(Token = "0x17000496")]
		NetworkObject NetworkObject
		{
			[Token(Token = "0x60017F1")]
			get;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060017F2 RID: 6130
		// (set) Token: 0x060017F3 RID: 6131
		[Token(Token = "0x17000497")]
		VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x60017F2")]
			get;
			[Token(Token = "0x60017F3")]
			set;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060017F4 RID: 6132
		[Token(Token = "0x17000498")]
		EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x60017F4")]
			get;
		}

		// Token: 0x060017F5 RID: 6133
		[Token(Token = "0x60017F5")]
		bool IsCurrentlySightable();
	}
}
