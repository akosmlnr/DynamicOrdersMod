using System;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2000928")]
	public class Product_Stored : StoredItem
	{
		// Token: 0x06003F2B RID: 16171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x8640E0", Offset = "0x8632E0", VA = "0x1808640E0", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x7FACA0", Offset = "0x7F9EA0", VA = "0x1807FACA0")]
		public Product_Stored()
		{
		}

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x68")]
		public ProductVisualsSetter Visuals;
	}
}
