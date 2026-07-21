using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0xB1AAF0", Offset = "0xB19CF0", VA = "0x180B1AAF0")]
		public void Start()
		{
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0xB1A9D0", Offset = "0xB19BD0", VA = "0x180B1A9D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0xB1A7C0", Offset = "0xB199C0", VA = "0x180B1A7C0")]
		public void MinPass()
		{
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0xB1AC90", Offset = "0xB19E90", VA = "0x180B1AC90")]
		public AnalogueClock()
		{
		}

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x20")]
		public Transform MinHand;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x28")]
		public Transform HourHand;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 RotationAxis;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onNoon;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onMidnight;
	}
}
