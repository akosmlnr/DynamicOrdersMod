using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x79F870", Offset = "0x79EA70", VA = "0x18079F870")]
		private void Start()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x79F8B0", Offset = "0x79EAB0", VA = "0x18079F8B0")]
		private void Update()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x79FC40", Offset = "0x79EE40", VA = "0x18079FC40")]
		public CameraAnimator()
		{
		}

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x20")]
		public float baseHeight;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x24")]
		public float speedY;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x28")]
		public float speedX;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x2C")]
		public float distAcceleration;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x30")]
		public float distSpeed;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 lookAt;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x40")]
		private float y;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x44")]
		private float dy;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x48")]
		private float distDirection;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x4C")]
		private float distSum;
	}
}
