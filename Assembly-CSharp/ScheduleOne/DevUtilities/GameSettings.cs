using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A2B RID: 2603
	[Token(Token = "0x2000A2B")]
	[Serializable]
	public class GameSettings
	{
		// Token: 0x060049EB RID: 18923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public GameSettings()
		{
		}

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x10")]
		public bool ConsoleEnabled;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x11")]
		public bool UseRandomizedMixMaps;
	}
}
