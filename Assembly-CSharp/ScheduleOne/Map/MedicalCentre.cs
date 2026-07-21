using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x625610", Offset = "0x624810", VA = "0x180625610")]
		public MedicalCentre()
		{
		}

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x50")]
		public Transform RespawnPoint;
	}
}
