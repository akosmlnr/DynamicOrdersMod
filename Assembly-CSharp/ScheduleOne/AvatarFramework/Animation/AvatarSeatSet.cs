using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x06003836 RID: 14390 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x7EB3B0", Offset = "0x7EA5B0", VA = "0x1807EB3B0")]
		public AvatarSeat GetFirstFreeSeat()
		{
			return null;
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x7EB500", Offset = "0x7EA700", VA = "0x1807EB500")]
		public AvatarSeat GetRandomFreeSeat()
		{
			return null;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AvatarSeatSet()
		{
		}

		// Token: 0x04002932 RID: 10546
		[Token(Token = "0x4002932")]
		[FieldOffset(Offset = "0x20")]
		public AvatarSeat[] Seats;
	}
}
