using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class PongBall : MonoBehaviour
	{
		// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114D")]
		[Address(RVA = "0xB1E1F0", Offset = "0xB1D3F0", VA = "0x180B1E1F0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x66CDA0", Offset = "0x66BFA0", VA = "0x18066CDA0")]
		public PongBall()
		{
		}

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x20")]
		public Pong Game;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Rect;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody RB;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x38")]
		public float RandomForce;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onHit;
	}
}
