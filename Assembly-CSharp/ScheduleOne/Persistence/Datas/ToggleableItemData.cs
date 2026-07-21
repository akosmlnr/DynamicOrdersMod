using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public class ToggleableItemData : GridItemData
	{
		// Token: 0x06001B0E RID: 6926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x619EC0", Offset = "0x6190C0", VA = "0x180619EC0")]
		public ToggleableItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, bool isOn)
		{
		}

		// Token: 0x0400171D RID: 5917
		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x58")]
		public bool IsOn;
	}
}
