using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public class TrashContainerData : GridItemData
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public TrashContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, TrashContentData contentData)
		{
		}

		// Token: 0x0400171F RID: 5919
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x58")]
		public TrashContentData ContentData;
	}
}
