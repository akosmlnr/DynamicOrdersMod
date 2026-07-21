using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	public class LiquidMeth_Stored : StoredItem
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x817C70", Offset = "0x816E70", VA = "0x180817C70", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x7FACA0", Offset = "0x7F9EA0", VA = "0x1807FACA0")]
		public LiquidMeth_Stored()
		{
		}

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x68")]
		public LiquidMethVisuals Visuals;
	}
}
