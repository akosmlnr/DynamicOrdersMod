using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	[Serializable]
	public class BrickPressData : GridItemData
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public BrickPressData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
		{
		}

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Contents;
	}
}
