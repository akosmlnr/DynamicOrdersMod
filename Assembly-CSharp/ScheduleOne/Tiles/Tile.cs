using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Temperature;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x170003D3")]
		public float CosmeticTileTemperature
		{
			[Token(Token = "0x600128B")]
			[Address(RVA = "0xB2B650", Offset = "0xB2A850", VA = "0x180B2B650")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x170003D4")]
		public float TileTemperature
		{
			[Token(Token = "0x600128C")]
			[Address(RVA = "0xB2B810", Offset = "0xB2AA10", VA = "0x180B2B810")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128D")]
		[Address(RVA = "0xB2B4F0", Offset = "0xB2A6F0", VA = "0x180B2B4F0")]
		public void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128E")]
		[Address(RVA = "0xB2B060", Offset = "0xB2A260", VA = "0x180B2B060")]
		private void Awake()
		{
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128F")]
		[Address(RVA = "0xB2AEC0", Offset = "0xB2A0C0", VA = "0x180B2AEC0")]
		public void AddOccupant(GridItem occ, FootprintTile tile)
		{
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001290")]
		[Address(RVA = "0xB2B520", Offset = "0xB2A720", VA = "0x180B2B520")]
		public void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6001291")]
		[Address(RVA = "0xB2B270", Offset = "0xB2A470", VA = "0x180B2B270", Slot = "4")]
		public virtual bool CanBeBuiltOn()
		{
			return default(bool);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001292")]
		[Address(RVA = "0xB2B330", Offset = "0xB2A530", VA = "0x180B2B330")]
		public List<Tile> GetSurroundingTiles()
		{
			return null;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "5")]
		public virtual bool IsIndoorTile()
		{
			return default(bool);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001294")]
		[Address(RVA = "0xB2B5D0", Offset = "0xB2A7D0", VA = "0x180B2B5D0")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001295")]
		[Address(RVA = "0xB2B510", Offset = "0xB2A710", VA = "0x180B2B510")]
		private void OnCosmeticTemperatureEmittersChanged(string propertyCode, TemperatureEmitterInfo[] emitters)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
		private void OnTemperatureEmittersChanged(TemperatureEmitterInfo[] emitters)
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0xB1E110", Offset = "0xB1D310", VA = "0x180B1E110")]
		public Tile()
		{
		}

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x20")]
		public int x;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x24")]
		public int y;

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float AvailableOffset;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Grid OwnerGrid;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x38")]
		public LightExposureNode LightExposureNode;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x40")]
		[Header("Occupants")]
		public List<GridItem> BuildableOccupants;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x48")]
		public List<FootprintTile> OccupantTiles;

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x50")]
		public Tile.TileChange onTileChanged;

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x58")]
		public Action<Tile, float> onTileTemperatureChanged;

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x60")]
		private float _cosmeticTileTemperature;

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x68")]
		private TemperatureEmitterInfo[] _cachedCosmeticTemperatureEmitters;

		// Token: 0x040010F0 RID: 4336
		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x70")]
		private float _tileTemperature;

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x78")]
		private TemperatureEmitterInfo[] _cachedTemperatureEmitters;

		// Token: 0x02000310 RID: 784
		// (Invoke) Token: 0x06001299 RID: 4761
		[Token(Token = "0x2000310")]
		public delegate void TileChange(Tile thisTile);
	}
}
