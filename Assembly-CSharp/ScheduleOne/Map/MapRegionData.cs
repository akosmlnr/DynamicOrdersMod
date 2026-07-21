using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	[Serializable]
	public class MapRegionData
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0000A998 File Offset: 0x00008B98
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public bool IsUnlocked
		{
			[Token(Token = "0x6001D3C")]
			[Address(RVA = "0x4D4760", Offset = "0x4D3960", VA = "0x1804D4760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0x4D4AE0", Offset = "0x4D3CE0", VA = "0x1804D4AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x6247D0", Offset = "0x6239D0", VA = "0x1806247D0")]
		public DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			return null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x6249E0", Offset = "0x623BE0", VA = "0x1806249E0")]
		public void SetUnlocked()
		{
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x6246B0", Offset = "0x6238B0", VA = "0x1806246B0")]
		public List<EMapRegion> GetAdjacentRegions()
		{
			return null;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public MapRegionData()
		{
		}

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x10")]
		public EMapRegion Region;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x20")]
		public bool UnlockedByDefault;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x24")]
		public FullRank RankRequirement;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x30")]
		public NPC[] StartingNPCs;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x38")]
		public Sprite RegionSprite;

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x40")]
		public DeliveryLocation[] RegionDeliveryLocations;

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x48")]
		public MapRegionData.RegionContainer[] AdjacentRegions;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x50")]
		public PolygonalZone RegionBounds;

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		[Serializable]
		public class RegionContainer
		{
			// Token: 0x06001D42 RID: 7490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public RegionContainer()
			{
			}

			// Token: 0x040018AC RID: 6316
			[Token(Token = "0x40018AC")]
			[FieldOffset(Offset = "0x10")]
			public EMapRegion Region;
		}
	}
}
