using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public class LiquidLevelPouringSync : MonoBehaviour
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7A7520", Offset = "0x7A6720", VA = "0x1807A7520")]
		private void Start()
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x7A74D0", Offset = "0x7A66D0", VA = "0x1807A74D0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x7A75D0", Offset = "0x7A67D0", VA = "0x1807A75D0")]
		private void UpdateColliderPos()
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x7A77F0", Offset = "0x7A69F0", VA = "0x1807A77F0")]
		public LiquidLevelPouringSync()
		{
		}

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x20")]
		public float fillSpeed;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x24")]
		public float sinkFactor;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x28")]
		private LiquidVolume lv;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody rb;
	}
}
