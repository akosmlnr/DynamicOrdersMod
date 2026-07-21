using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class RandomMove : MonoBehaviour
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x7B4FF0", Offset = "0x7B41F0", VA = "0x1807B4FF0")]
		private void Update()
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7B5990", Offset = "0x7B4B90", VA = "0x1807B5990")]
		public RandomMove()
		{
		}

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x20")]
		[Range(-10f, 10f)]
		public float right;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x24")]
		[Range(-10f, 10f)]
		public float left;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x28")]
		[Range(-10f, 10f)]
		public float back;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x2C")]
		[Range(-10f, 10f)]
		public float front;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 0.2f)]
		public float speed;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 2f)]
		public float rotationSpeed;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.1f, 2f)]
		public float randomSpeed;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x3C")]
		public bool automatic;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 velocity;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x4C")]
		private int flaskType;
	}
}
