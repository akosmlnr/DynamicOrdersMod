using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class ChemistryStationData : GridItemData
	{
		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x602A90", Offset = "0x601C90", VA = "0x180602A90")]
		public ChemistryStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime)
		{
		}

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet InputContents;

		// Token: 0x040016F2 RID: 5874
		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet OutputContents;

		// Token: 0x040016F3 RID: 5875
		[Token(Token = "0x40016F3")]
		[FieldOffset(Offset = "0x68")]
		public string CurrentRecipeID;

		// Token: 0x040016F4 RID: 5876
		[Token(Token = "0x40016F4")]
		[FieldOffset(Offset = "0x70")]
		public EQuality ProductQuality;

		// Token: 0x040016F5 RID: 5877
		[Token(Token = "0x40016F5")]
		[FieldOffset(Offset = "0x74")]
		public Color StartLiquidColor;

		// Token: 0x040016F6 RID: 5878
		[Token(Token = "0x40016F6")]
		[FieldOffset(Offset = "0x84")]
		public float LiquidLevel;

		// Token: 0x040016F7 RID: 5879
		[Token(Token = "0x40016F7")]
		[FieldOffset(Offset = "0x88")]
		public int CurrentTime;
	}
}
