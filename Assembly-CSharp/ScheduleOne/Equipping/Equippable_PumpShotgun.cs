using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000959 RID: 2393
	[Token(Token = "0x2000959")]
	public class Equippable_PumpShotgun : Equippable_RangedWeapon
	{
		// Token: 0x06004005 RID: 16389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x854090", Offset = "0x853290", VA = "0x180854090", Slot = "10")]
		protected override Vector3[] GetBulletDirections()
		{
			return null;
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x854240", Offset = "0x853440", VA = "0x180854240")]
		public Equippable_PumpShotgun()
		{
		}

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x1B0")]
		[Header("Shotgun Settings")]
		public int PelletCount;
	}
}
