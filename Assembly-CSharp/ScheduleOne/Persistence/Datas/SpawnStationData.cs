using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B9 RID: 1209
	[Token(Token = "0x20004B9")]
	[Serializable]
	public class SpawnStationData : GridItemData
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public SpawnStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
		{
		}

		// Token: 0x04001718 RID: 5912
		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Contents;
	}
}
