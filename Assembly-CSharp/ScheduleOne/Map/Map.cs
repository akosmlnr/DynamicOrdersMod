using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	public class Map : Singleton<Map>
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x624B00", Offset = "0x623D00", VA = "0x180624B00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x6253D0", Offset = "0x6245D0", VA = "0x1806253D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x625250", Offset = "0x624450", VA = "0x180625250")]
		private void OnRankUp(FullRank old, FullRank newRank)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x624F50", Offset = "0x624150", VA = "0x180624F50")]
		public MapRegionData GetRegionData(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x625170", Offset = "0x624370", VA = "0x180625170")]
		public List<EMapRegion> GetUnlockedRegions()
		{
			return null;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x625020", Offset = "0x624220", VA = "0x180625020")]
		public EMapRegion GetRegionFromPosition(Vector3 position)
		{
			return EMapRegion.Northtown;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x6255D0", Offset = "0x6247D0", VA = "0x1806255D0")]
		public Map()
		{
		}

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		public const EMapRegion FINAL_REGION = EMapRegion.Uptown;

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		[FieldOffset(Offset = "0x28")]
		public bool UNLOCK_ALL_REGIONS;

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x30")]
		public MapRegionData[] Regions;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public PoliceStation PoliceStation;

		// Token: 0x040018E3 RID: 6371
		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x40")]
		public MedicalCentre MedicalCentre;

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x48")]
		public Transform TreeBounds;
	}
}
