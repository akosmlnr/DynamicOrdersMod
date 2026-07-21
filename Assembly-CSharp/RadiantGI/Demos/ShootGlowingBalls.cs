using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RadiantGI.Demos
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class ShootGlowingBalls : MonoBehaviour
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x7B6830", Offset = "0x7B5A30", VA = "0x1807B6830")]
		private void Start()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ShootGlowingBalls()
		{
		}

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x28")]
		public Transform center;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x30")]
		public GameObject glowingBall;
	}
}
