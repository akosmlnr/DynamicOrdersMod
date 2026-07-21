using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x060012A0 RID: 4768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0xB2A0D0", Offset = "0xB292D0", VA = "0x180B2A0D0", Slot = "4")]
		public virtual void CheckIntersections(bool sort = true)
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012A1")]
		public List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0xB2AA70", Offset = "0xB29C70", VA = "0x180B2AA70")]
		public Tile GetClosestTile()
		{
			return null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0xB2A790", Offset = "0xB29990", VA = "0x180B2A790")]
		public ProceduralTile GetClosestProceduralTile()
		{
			return null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0xB2AD50", Offset = "0xB29F50", VA = "0x180B2AD50")]
		public TileDetector()
		{
		}

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x20")]
		public float detectionRadius;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x24")]
		public ETileDetectionMode tileDetectionMode;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x28")]
		public List<Tile> intersectedTiles;

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x30")]
		public List<Tile> intersectedOutdoorTiles;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x38")]
		public List<Tile> intersectedIndoorTiles;

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x40")]
		public List<StorageTile> intersectedStorageTiles;

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x48")]
		public List<ProceduralTile> intersectedProceduralTiles;
	}
}
