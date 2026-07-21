using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	public class FilledPackaging_StoredItem : StoredItem
	{
		// Token: 0x06003A3C RID: 14908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x7FABC0", Offset = "0x7F9DC0", VA = "0x1807FABC0", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x7FACA0", Offset = "0x7F9EA0", VA = "0x1807FACA0")]
		public FilledPackaging_StoredItem()
		{
		}

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x68")]
		public MultiTypeVisualsSetter Visuals;
	}
}
