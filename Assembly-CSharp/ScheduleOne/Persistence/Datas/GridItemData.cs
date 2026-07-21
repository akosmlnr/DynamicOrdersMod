using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x604D00", Offset = "0x603F00", VA = "0x180604D00")]
		public GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation)
		{
		}

		// Token: 0x040016FB RID: 5883
		[Token(Token = "0x40016FB")]
		[FieldOffset(Offset = "0x40")]
		public string GridGUID;

		// Token: 0x040016FC RID: 5884
		[Token(Token = "0x40016FC")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 OriginCoordinate;

		// Token: 0x040016FD RID: 5885
		[Token(Token = "0x40016FD")]
		[FieldOffset(Offset = "0x50")]
		public int Rotation;
	}
}
