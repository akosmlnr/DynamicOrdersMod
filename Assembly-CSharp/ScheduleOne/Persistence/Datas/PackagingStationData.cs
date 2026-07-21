using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	[Serializable]
	public class PackagingStationData : GridItemData
	{
		// Token: 0x06001B06 RID: 6918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public PackagingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
		{
		}

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Contents;
	}
}
