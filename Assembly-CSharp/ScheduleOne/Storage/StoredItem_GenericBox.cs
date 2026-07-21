using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x06003C54 RID: 15444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x827AF0", Offset = "0x826CF0", VA = "0x180827AF0", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x827D10", Offset = "0x826F10", VA = "0x180827D10")]
		public StoredItem_GenericBox()
		{
		}

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		private const float ReferenceIconWidth = 1024f;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		[SerializeField]
		protected SpriteRenderer icon1;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected SpriteRenderer icon2;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[FieldOffset(Offset = "0x78")]
		[Header("Settings")]
		public float IconScale;
	}
}
