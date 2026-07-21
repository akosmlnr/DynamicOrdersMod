using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x688C00", Offset = "0x687E00", VA = "0x180688C00")]
		public UsableLightSource()
		{
		}

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.5f, 2f)]
		public float GrowSpeedMultiplier;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x24")]
		public bool isEmitting;
	}
}
