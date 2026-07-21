using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Temperature;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	[Serializable]
	public class AirConditionerData : GridItemData
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x602080", Offset = "0x601280", VA = "0x180602080")]
		public AirConditionerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, AirConditioner.EMode mode)
		{
		}

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x58")]
		public AirConditioner.EMode Mode;
	}
}
