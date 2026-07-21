using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001288")]
		[Address(RVA = "0xB1F7E0", Offset = "0xB1E9E0", VA = "0x180B1F7E0")]
		public void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001289")]
		[Address(RVA = "0xB1F910", Offset = "0xB1EB10", VA = "0x180B1F910")]
		public void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128A")]
		[Address(RVA = "0xB1F9F0", Offset = "0xB1EBF0", VA = "0x180B1F9F0")]
		public ProceduralTile()
		{
		}

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public ProceduralTile.EProceduralTileType TileType;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public BuildableItem ParentBuildableItem;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x30")]
		public FootprintTile MatchedFootprintTile;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x38")]
		[Header("Occupants")]
		public List<ProceduralGridItem> Occupants;

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x40")]
		public List<FootprintTile> OccupantTiles;

		// Token: 0x0200030E RID: 782
		[Token(Token = "0x200030E")]
		public enum EProceduralTileType
		{
			// Token: 0x040010E4 RID: 4324
			[Token(Token = "0x40010E4")]
			Rack
		}
	}
}
