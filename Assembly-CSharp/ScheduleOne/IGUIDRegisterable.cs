using System;
using Il2CppDummyDll;

namespace ScheduleOne
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	public interface IGUIDRegisterable
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000E2F RID: 3631
		[Token(Token = "0x17000329")]
		Guid GUID
		{
			[Token(Token = "0x6000E2F")]
			get;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0xAE9E90", Offset = "0xAE9090", VA = "0x180AE9E90", Slot = "1")]
		void SetGUID(string guid)
		{
		}

		// Token: 0x06000E31 RID: 3633
		[Token(Token = "0x6000E31")]
		void SetGUID(Guid guid);
	}
}
