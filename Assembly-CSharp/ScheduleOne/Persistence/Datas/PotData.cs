using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	public class PotData : GrowContainerData
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x613730", Offset = "0x612930", VA = "0x180613730")]
		public PotData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives, PlantData plantData)
		{
		}

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x78")]
		public PlantData PlantData;
	}
}
