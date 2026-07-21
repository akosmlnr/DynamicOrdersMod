using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public class VerticalBounce : MonoBehaviour
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x7BD6D0", Offset = "0x7BC8D0", VA = "0x1807BD6D0")]
		private void Update()
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x7BD7E0", Offset = "0x7BC9E0", VA = "0x1807BD7E0")]
		public VerticalBounce()
		{
		}

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 0.1f)]
		public float acceleration;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x24")]
		private float direction;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x28")]
		private float y;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x2C")]
		private float speed;
	}
}
