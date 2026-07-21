using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	public class SoilPourerData : GridItemData
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public SoilPourerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID)
		{
		}

		// Token: 0x04001717 RID: 5911
		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x58")]
		public string SoilID;
	}
}
