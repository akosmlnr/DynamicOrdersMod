using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	public class LabOvenData : GridItemData
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x606590", Offset = "0x605790", VA = "0x180606590")]
		public LabOvenData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress)
		{
		}

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[FieldOffset(Offset = "0x58")]
		public ItemSet InputContents;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[FieldOffset(Offset = "0x60")]
		public ItemSet OutputContents;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x68")]
		public string CurrentIngredientID;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0x70")]
		public int CurrentIngredientQuantity;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x74")]
		public EQuality CurrentIngredientQuality;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x78")]
		public string CurrentProductID;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x80")]
		public int CurrentCookProgress;
	}
}
