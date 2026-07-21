using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20004AA")]
	public class CauldronData : GridItemData
	{
		// Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x602930", Offset = "0x601B30", VA = "0x180602930")]
		public CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality)
		{
		}

		// Token: 0x040016EC RID: 5868
		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet Ingredients;

		// Token: 0x040016ED RID: 5869
		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet Liquid;

		// Token: 0x040016EE RID: 5870
		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x68")]
		public ItemSet Output;

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0x70")]
		public int RemainingCookTime;

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x74")]
		public EQuality InputQuality;
	}
}
