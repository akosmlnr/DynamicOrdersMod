using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	[RequireComponent(typeof(Ladder))]
	public class LadderSizeSetter : MonoBehaviour
	{
		// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x622DE0", Offset = "0x621FE0", VA = "0x180622DE0")]
		public LadderSizeSetter()
		{
		}

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Size;
	}
}
