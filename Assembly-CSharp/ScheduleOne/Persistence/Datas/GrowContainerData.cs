using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public class GrowContainerData : GridItemData
	{
		// Token: 0x06001AFF RID: 6911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x605070", Offset = "0x604270", VA = "0x180605070")]
		public GrowContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives)
		{
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x604E00", Offset = "0x604000", VA = "0x180604E00")]
		public void ConvertOldAdditiveFormatToNew()
		{
		}

		// Token: 0x040016FE RID: 5886
		[Token(Token = "0x40016FE")]
		[FieldOffset(Offset = "0x58")]
		public string SoilID;

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x60")]
		public float SoilLevel;

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0x64")]
		public int RemainingSoilUses;

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		[FieldOffset(Offset = "0x68")]
		public float WaterLevel;

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		[FieldOffset(Offset = "0x70")]
		public string[] AppliedAdditives;
	}
}
