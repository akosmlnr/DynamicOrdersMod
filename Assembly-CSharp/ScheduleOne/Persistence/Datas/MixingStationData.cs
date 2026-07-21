using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	public class MixingStationData : GridItemData
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x6133E0", Offset = "0x6125E0", VA = "0x1806133E0")]
		public MixingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime)
		{
		}

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet ProductContents;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet MixerContents;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x68")]
		public ItemSet OutputContents;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0x70")]
		public MixOperation CurrentMixOperation;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0x78")]
		public int CurrentMixTime;
	}
}
