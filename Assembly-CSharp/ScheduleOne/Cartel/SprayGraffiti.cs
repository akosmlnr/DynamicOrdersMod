using System;
using Il2CppDummyDll;
using ScheduleOne.Graffiti;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	public class SprayGraffiti : CartelActivity
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x79DD40", Offset = "0x79CF40", VA = "0x18079DD40", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x79DDE0", Offset = "0x79CFE0", VA = "0x18079DDE0")]
		public void SetSpraySurface(EMapRegion region, bool overrideExisting = true)
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x79D9B0", Offset = "0x79CBB0", VA = "0x18079D9B0", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x79E140", Offset = "0x79D340", VA = "0x18079E140")]
		public SprayGraffiti()
		{
		}

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Settings")]
		private float _minimumDistanceFromPlayers;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x48")]
		private WorldSpraySurface _validSpraySurface;
	}
}
