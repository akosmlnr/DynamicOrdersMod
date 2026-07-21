using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	public class MushroomBedData : GrowContainerData
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x613730", Offset = "0x612930", VA = "0x180613730")]
		public MushroomBedData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives, ShroomColonyData colonyData)
		{
		}

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x78")]
		public ShroomColonyData ShroomColonyData;
	}
}
