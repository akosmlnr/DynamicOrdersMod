using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	[Serializable]
	public class FootprintMatchData
	{
		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x604120", Offset = "0x603320", VA = "0x180604120")]
		public FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate)
		{
		}

		// Token: 0x0400165B RID: 5723
		[Token(Token = "0x400165B")]
		[FieldOffset(Offset = "0x10")]
		public string TileOwnerGUID;

		// Token: 0x0400165C RID: 5724
		[Token(Token = "0x400165C")]
		[FieldOffset(Offset = "0x18")]
		public int TileIndex;

		// Token: 0x0400165D RID: 5725
		[Token(Token = "0x400165D")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 FootprintCoordinate;
	}
}
