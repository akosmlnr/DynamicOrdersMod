using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x5C0FD0", Offset = "0x5C01D0", VA = "0x1805C0FD0")]
		public void FixedUpdate()
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x5C1320", Offset = "0x5C0520", VA = "0x1805C1320")]
		public RotateRigidbodyToTarget()
		{
		}

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rigidbody;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 TargetRotation;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x34")]
		public float RotationForce;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x38")]
		public Transform Bitch;
	}
}
