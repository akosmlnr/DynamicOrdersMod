using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	public static class MapHeightSampler
	{
		// Token: 0x0600491F RID: 18719 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x8F7F90", Offset = "0x8F7190", VA = "0x1808F7F90")]
		public static bool TrySample(float x, float z, out Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		private const float SampleHeight = 100f;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		private const float SampleDistance = 200f;
	}
}
