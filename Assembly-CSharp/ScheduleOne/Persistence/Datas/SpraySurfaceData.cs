using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Graffiti;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	[Serializable]
	public class SpraySurfaceData : SaveData
	{
		// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x618D00", Offset = "0x617F00", VA = "0x180618D00")]
		public SpraySurfaceData(List<SprayStroke> strokes, bool containsCartelGraffiti)
		{
		}

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0x28")]
		public List<SprayStroke> Strokes;

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0x30")]
		public bool ContainsCartelGraffiti;
	}
}
