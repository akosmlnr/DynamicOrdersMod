using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000965")]
		public StorableItemInstance item
		{
			[Token(Token = "0x6003C39")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C3A")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00011628 File Offset: 0x0000F828
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000966")]
		public bool Destroyed
		{
			[Token(Token = "0x6003C3B")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C3C")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000967")]
		public FootprintTile OriginFootprint
		{
			[Token(Token = "0x6003C3D")]
			[Address(RVA = "0x828DD0", Offset = "0x827FD0", VA = "0x180828DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06003C3E RID: 15422 RVA: 0x00011640 File Offset: 0x0000F840
		[Token(Token = "0x17000968")]
		public int FootprintX
		{
			[Token(Token = "0x6003C3E")]
			[Address(RVA = "0x828AF0", Offset = "0x827CF0", VA = "0x180828AF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x17000969")]
		public int FootprintY
		{
			[Token(Token = "0x6003C3F")]
			[Address(RVA = "0x828C60", Offset = "0x827E60", VA = "0x180828C60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06003C40 RID: 15424 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C41 RID: 15425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096A")]
		public StorageGrid parentGrid
		{
			[Token(Token = "0x6003C40")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C41")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700096B")]
		public List<CoordinatePair> CoordinatePairs
		{
			[Token(Token = "0x6003C42")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x1700096C")]
		public float Rotation
		{
			[Token(Token = "0x6003C43")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x1700096D")]
		public int totalArea
		{
			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x828E30", Offset = "0x828030", VA = "0x180828E30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C45")]
		[Address(RVA = "0x827770", Offset = "0x826970", VA = "0x180827770", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C46")]
		[Address(RVA = "0x827E20", Offset = "0x827020", VA = "0x180827E20", Slot = "5")]
		public virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x828340", Offset = "0x827540", VA = "0x180828340")]
		private void RefreshTransform()
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x827A20", Offset = "0x826C20", VA = "0x180827A20", Slot = "6")]
		public virtual void Destroy()
		{
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x8278F0", Offset = "0x826AF0", VA = "0x1808278F0")]
		public void ClearFootprintOccupancy()
		{
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x828960", Offset = "0x827B60", VA = "0x180828960")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x827840", Offset = "0x826A40", VA = "0x180827840")]
		public void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x827D20", Offset = "0x826F20", VA = "0x180827D20")]
		public FootprintTile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x828A20", Offset = "0x827C20", VA = "0x180828A20")]
		public StoredItem()
		{
		}

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform buildPoint;

		// Token: 0x04002C3A RID: 11322
		[Token(Token = "0x4002C3A")]
		[FieldOffset(Offset = "0x38")]
		public List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x40")]
		private int footprintX;

		// Token: 0x04002C3C RID: 11324
		[Token(Token = "0x4002C3C")]
		[FieldOffset(Offset = "0x44")]
		private int footprintY;

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x50")]
		protected List<CoordinatePair> coordinatePairs;

		// Token: 0x04002C3F RID: 11327
		[Token(Token = "0x4002C3F")]
		[FieldOffset(Offset = "0x58")]
		protected float rotation;

		// Token: 0x04002C40 RID: 11328
		[Token(Token = "0x4002C40")]
		[FieldOffset(Offset = "0x5C")]
		public int xSize;

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x60")]
		public int ySize;
	}
}
