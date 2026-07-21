using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x1700095A")]
		public int UnoccupiedTileCount
		{
			[Token(Token = "0x6003C07")]
			[Address(RVA = "0x8255E0", Offset = "0x8247E0", VA = "0x1808255E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x824590", Offset = "0x823790", VA = "0x180824590")]
		private void Awake()
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x824D00", Offset = "0x823F00", VA = "0x180824D00")]
		public void RegisterTile(StorageTile tile)
		{
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x8247E0", Offset = "0x8239E0", VA = "0x1808247E0")]
		public void DeregisterTile(StorageTile tile)
		{
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x824A10", Offset = "0x823C10", VA = "0x180824A10")]
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x824B60", Offset = "0x823D60", VA = "0x180824B60")]
		public StorageTile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x824CA0", Offset = "0x823EA0", VA = "0x180824CA0")]
		public int GetUserEndCapacity()
		{
			return 0;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x824960", Offset = "0x823B60", VA = "0x180824960")]
		public int GetActualY()
		{
			return 0;
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x824900", Offset = "0x823B00", VA = "0x180824900")]
		public int GetActualX()
		{
			return 0;
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x824C60", Offset = "0x823E60", VA = "0x180824C60")]
		public int GetTotalFootprintSize()
		{
			return 0;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x824EE0", Offset = "0x8240E0", VA = "0x180824EE0")]
		public bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			return default(bool);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x824700", Offset = "0x823900", VA = "0x180824700")]
		private int CalculateUnoccupiedTileCount()
		{
			return 0;
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x824ED0", Offset = "0x8240D0", VA = "0x180824ED0")]
		private void TileOccupantChanged()
		{
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x825510", Offset = "0x824710", VA = "0x180825510")]
		public StorageGrid()
		{
		}

		// Token: 0x04002C1D RID: 11293
		[Token(Token = "0x4002C1D")]
		[FieldOffset(Offset = "0x0")]
		public static float gridSize;

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x20")]
		public List<StorageTile> storageTiles;

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<CoordinateStorageTilePair> coordinateStorageTilePairs;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x30")]
		private int _unoccupiedTileCount;

		// Token: 0x04002C21 RID: 11297
		[Token(Token = "0x4002C21")]
		[FieldOffset(Offset = "0x34")]
		private bool _unoccupiedTileCountDirty;
	}
}
