using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public class DryingRackData : GridItemData
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x603920", Offset = "0x602B20", VA = "0x180603920")]
		public DryingRackData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, DryingOperation[] dryingOperations)
		{
		}

		// Token: 0x040016F8 RID: 5880
		[Token(Token = "0x40016F8")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Input;

		// Token: 0x040016F9 RID: 5881
		[Token(Token = "0x40016F9")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet Output;

		// Token: 0x040016FA RID: 5882
		[Token(Token = "0x40016FA")]
		[FieldOffset(Offset = "0x68")]
		public DryingOperation[] DryingOperations;
	}
}
