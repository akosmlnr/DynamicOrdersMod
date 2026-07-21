using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Graffiti;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[Serializable]
	public class WorldSpraySurfaceData : SpraySurfaceData
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x61D5C0", Offset = "0x61C7C0", VA = "0x18061D5C0")]
		public WorldSpraySurfaceData(List<SprayStroke> strokes, bool containsCartelGraffiti, string guid, bool hasBeenFinalized)
		{
		}

		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		[FieldOffset(Offset = "0x38")]
		public string GUID;

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		[FieldOffset(Offset = "0x40")]
		public bool HasDrawingBeenFinalized;
	}
}
