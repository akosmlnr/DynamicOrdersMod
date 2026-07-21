using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	[Serializable]
	public class PlaceableStorageData : GridItemData
	{
		// Token: 0x06001B07 RID: 6919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public PlaceableStorageData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
		{
		}

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Contents;
	}
}
