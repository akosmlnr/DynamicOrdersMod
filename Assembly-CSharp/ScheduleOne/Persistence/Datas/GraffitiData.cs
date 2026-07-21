using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public class GraffitiData : SaveData
	{
		// Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x604C60", Offset = "0x603E60", VA = "0x180604C60")]
		public GraffitiData(List<WorldSpraySurfaceData> spraySurfaces)
		{
		}

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0x28")]
		public List<WorldSpraySurfaceData> SpraySurfaces;
	}
}
