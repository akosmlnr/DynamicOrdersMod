using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001099")]
		[Address(RVA = "0xB02720", Offset = "0xB01920", VA = "0x180B02720")]
		public PathPoint()
		{
		}

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x20")]
		public List<PathPoint> connections;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x28")]
		public bool unique;
	}
}
